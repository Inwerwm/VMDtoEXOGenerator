using AviutlExEditObject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VmdIO;

namespace VMDtoEXOGenerator
{
    public partial class MainForm : Form
    {
        VocaloidMotionData vmd;
        ExEditObjectData exo;

        List<(string Name, bool Checked)> Key;
        List<ObjectData> ObjectList;

        bool canChangeTab;
        bool skipCheckListChange;

        public MainForm()
        {
            InitializeComponent();
            vmd = new VocaloidMotionData();
            ObjectList = new List<ObjectData>();

            canChangeTab = false;
            skipCheckListChange = false;
            // バージョン表記
            labelVersion.Text = "Version 1.0";
        }

        private void SetCheckedListBoxKey()
        {
            checkedListBoxKey.Items.Clear();
            checkedListBoxKey.Items.AddRange(Key.Select(k => k.Name).ToArray());
        }

        private void OpenVMD(string[] path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path[0], FileMode.Open)))
            {
                vmd.Read(reader);
            }
            if (path.Length > 1)
            {
                foreach (var s in path.Skip(1))
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(s, FileMode.Open)))
                    {
                        vmd.Merge(new VocaloidMotionData(reader));
                    }
                }
            }
            //同名同時フレームは削除
            vmd.MotionFrames.Distinct(new VmdMotionFrameDataEqualityComparer());
            vmd.MorphFrames.Distinct(new VmdMorphFrameDataEqualityComparer());

            Key = vmd.GetKeyNames(VocaloidMotionData.GetKeyIgnoring.FirstFrame).ConvertAll(n => (n, false));
            SetCheckedListBoxKey();
        }

        private void OpenObjects(string[] path)
        {
            foreach (var str in path)
            {
                switch (Path.GetExtension(str))
                {
                    case ".wav":
                    case ".mp3":
                        if (!ObjectList.Select(o => o.Path).Contains(str))
                        {
                            ObjectList.Add(new ObjectData(str, ObjectType.Audio, makeAudioObject(str)));
                        }
                        break;
                    default:
                        MessageBox.Show(Path.GetExtension(str).Skip(1).ToString() + "ファイルには対応していません");
                        break;
                }
            }

            listBoxSetee.Items.Clear();
            listBoxSetee.Items.AddRange(ObjectList.Select(o => Path.GetFileName(o.Path)).ToArray());
        }

        private ExEditObject makeAudioObject(string path)
        {
            var obj = new ExEditObject();

            obj.Audio = 1;
            obj.Property.Add(new ExoAudio(path));
            obj.Property.Add(new ExoStandardPlay());

            return obj;
        }

        private void tabControlProperty_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //ユーザーによるタブ移動を禁止する
            e.Cancel = !canChangeTab;
        }

        private void buttonOpenVMD_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "VMDファイル(*.vmd)|*.vmd|すべてのファイル(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenVMD(ofd.FileNames);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAllF_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxKey.Items.Count; i++)
            {
                checkedListBoxKey.SetItemChecked(i, false);
            }
        }

        private void buttonAllInv_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxKey.Items.Count; i++)
            {
                checkedListBoxKey.SetItemChecked(i, checkedListBoxKey.GetItemChecked(i) ? false : true);
            }
        }

        private void buttonAddObject_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "音声ファイル(*.wav;*.mp3)|*.wav;*.mp3|すべてのファイル(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenObjects(ofd.FileNames);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxSetee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = listBoxSetee.SelectedIndex;
            canChangeTab = true;
            switch (ObjectList[id].Type)
            {
                case ObjectType.Audio:
                    tabControlProperty.SelectedIndex = 1;
                    SetAudioParameter(id);
                    break;
                case ObjectType.Media:
                    break;
                case ObjectType.Filter:
                    break;
                default:
                    break;
            }
            SetCheckedKey(id);
            canChangeTab = false;
        }

        public void SetCheckedKey(int id)
        {
            if (checkedListBoxKey.Items.Count==0)
                return;

            skipCheckListChange = true;
            for (int i = 0; i < checkedListBoxKey.Items.Count; i++)
            {
                checkedListBoxKey.SetItemChecked(i, ObjectList[id].Keys.Contains(checkedListBoxKey.Items[i].ToString()));
            }
            skipCheckListChange = false;
        }

        private void SetAudioParameter(int id)
        {
            numericALayer.Value = ObjectList[id].ExObject.Layer;
            numericAStartOffset.Value = ObjectList[id].Offset;

            //makeAudioObject() が ExAudio → ExoStandardPlay の順でオーディオデータを入力
            List<object> pList;

            //ExAudio
            pList = ObjectList[id].ExObject.Property[0].ToList();
            //0:Start
            numericAPlayPos.Value = (decimal)(float)pList[0];
            //1:Speed 
            numericAPlaySpeed.Value = (decimal)(float)pList[1];
            //2:Loop
            //3:Linkage
            //4:FilePath
            textBoxAFilePath.Text = (string)pList[4];

            //ExoStandardPlay
            pList = ObjectList[id].ExObject.Property[1].ToList();
            //0:Volume
            numericAVolume.Value = (decimal)(float)pList[0];
            //1:Side
            numericAPan.Value = (decimal)(float)pList[1];
        }

        private void numericAStartOffset_ValueChanged(object sender, EventArgs e)
        {
            int id = listBoxSetee.SelectedIndex;
            ObjectList[id].Offset = (int)numericAStartOffset.Value;
        }

        private void numericALayer_ValueChanged(object sender, EventArgs e)
        {
            int id = listBoxSetee.SelectedIndex;
            ObjectList[id].ExObject.Layer = (int)numericALayer.Value;
        }

        private void numericAPlayPos_ValueChanged(object sender, EventArgs e)
        {
            int id = listBoxSetee.SelectedIndex;
            var l = new List<object> { (float)numericAPlayPos.Value, null, null, null, null };
            ObjectList[id].ExObject.Property[0].SetBy(l);
        }

        private void numericAPlaySpeed_ValueChanged(object sender, EventArgs e)
        {
            int id = listBoxSetee.SelectedIndex;
            var l = new List<object> { null, (float)numericAPlaySpeed.Value, null, null, null };
            ObjectList[id].ExObject.Property[0].SetBy(l);
        }

        private void numericAVolume_ValueChanged(object sender, EventArgs e)
        {
            int id = listBoxSetee.SelectedIndex;
            var l = new List<object> { (float)numericAVolume.Value, null };
            ObjectList[id].ExObject.Property[1].SetBy(l);
        }

        private void numericAPan_ValueChanged(object sender, EventArgs e)
        {
            int id = listBoxSetee.SelectedIndex;
            var l = new List<object> { null, (float)numericAPan.Value };
            ObjectList[id].ExObject.Property[1].SetBy(l);
        }

        private void checkedListBoxKey_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (skipCheckListChange)
                return;

            int id = listBoxSetee.SelectedIndex;
            if (id == -1)
                return;

            if (e.NewValue==CheckState.Checked)
            {
                ObjectList[id].Keys.Add(checkedListBoxKey.Items[e.Index].ToString());
            }
            else
            {
                ObjectList[id].Keys.Remove(checkedListBoxKey.Items[e.Index].ToString());
            }
        }
    }

    public enum ObjectType
    {
        Audio,
        Media,
        Filter
    }
    public class ObjectData
    {
        public string Path { get; set; }
        public ObjectType Type { get; set; }
        public int Offset { get; set; }
        public ExEditObject ExObject { get; set; }
        public List<string> Keys { get; private set; }

        public ObjectData(string path, ObjectType type, ExEditObject obj, int offset = 0)
        {
            Path = path;
            Type = type;
            Offset = offset;
            ExObject = obj;
            Keys = new List<string>();
        }
    }
}
