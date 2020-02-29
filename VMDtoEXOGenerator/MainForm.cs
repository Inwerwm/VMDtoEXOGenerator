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

        List<StrBl> KeyAndBool;
        List<ObjectData> ObjectList;

        bool canTabChange;

        public MainForm()
        {
            InitializeComponent();
            vmd = new VocaloidMotionData();
            exo = new ExEditObjectData();
            ObjectList = new List<ObjectData>();

            canTabChange = false;

            // バージョン表記
            labelVersion.Text = "Version 1.0";
        }

        private void SetCheckedListBoxKey()
        {
            checkedListBoxKey.Items.Clear();
            checkedListBoxKey.Items.AddRange(KeyAndBool.Select(k => k.Str).ToArray());
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

            KeyAndBool = vmd.GetKeyNames(VocaloidMotionData.GetKeyIgnoring.FirstFrame).ConvertAll(n => new StrBl(n));
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
                        if (!ObjectList.Select(o=>o.Path).Contains(str))
                        {
                            exo.Objects.Add(makeAudioObject(str));
                            ObjectList.Add(new ObjectData(str, ObjectType.Audio));
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
            e.Cancel = !canTabChange;
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
            canTabChange = true;
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
            canTabChange = false;
        }

        private void SetAudioParameter(int id)
        {
            numericALayer.Value = exo.Objects[id].Layer;
            numericAStartOffset.Value = ObjectList[id].Offset;

            //makeAudioObject() が ExAudio → ExoStandardPlay の順でオーディオデータを入力
            List<object> pList;

            //ExAudio
            pList = exo.Objects[id].Property[0].ToList();
            //0:Start
            numericAPlayPos.Value = (decimal)(float)pList[0];
            //1:Speed 
            numericAPlaySpeed.Value = (decimal)(float)pList[1];
            //2:Loop
            //3:Linkage
            //4:FilePath
            textBoxAFilePath.Text = (string)pList[4];

            //ExoStandardPlay
            pList = exo.Objects[id].Property[1].ToList();
            //0:Volume
            numericAVolume.Value = (decimal)(float)pList[0];
            //1:Side
            numericAPan.Value = (decimal)(float)pList[1];
        }
    }

    public class StrBl
    {
        public string Str { get; set; }
        public bool Bl { get; set; }

        public StrBl(string str = "", bool bl = false)
        {
            Str = str;
            Bl = bl;
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

        public ObjectData(string path, ObjectType type, int offset = 0)
        {
            Path = path;
            Type = type;
            Offset = offset;
        }
    }
}
