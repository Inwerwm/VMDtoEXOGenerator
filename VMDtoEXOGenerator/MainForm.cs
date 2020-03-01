using AviutlExEditObject;
using NAudio.Wave;
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

        private void OpenVMD(string[] path)
        {
            foreach (var s in path)
            {
                using (BinaryReader reader = new BinaryReader(File.Open(s, FileMode.Open)))
                {
                    vmd.Merge(new VocaloidMotionData(reader));
                }
            }
            //同名同時フレームは削除
            vmd.MotionFrames.Distinct(new VmdMotionFrameDataEqualityComparer());
            vmd.MorphFrames.Distinct(new VmdMorphFrameDataEqualityComparer());

            checkedListBoxKey.Items.Clear();
            checkedListBoxKey.Items.AddRange(vmd.GetKeyNames(VocaloidMotionData.GetKeyIgnoring.FirstFrame).ToArray());
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
            SetPlayButtonText(id);
            canChangeTab = false;
        }

        public void SetCheckedKey(int id)
        {
            if (checkedListBoxKey.Items.Count == 0)
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

            if (e.NewValue == CheckState.Checked)
            {
                ObjectList[id].Keys.Add(checkedListBoxKey.Items[e.Index].ToString());
            }
            else
            {
                ObjectList[id].Keys.Remove(checkedListBoxKey.Items[e.Index].ToString());
            }
        }

        private void buttonAPlay_Click(object sender, EventArgs e)
        {
            int id = listBoxSetee.SelectedIndex;
            ObjectList[id].PlayAudio(delegate
            {
                SetPlayButtonText(id);
            });
            SetPlayButtonText(id);
        }

        private void SetPlayButtonText(int id)
        {
            buttonAPlay.Text = ObjectList[id].isPlaying() ? "■ 停止" : "▶ 再生";
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            try
            {
                generateExo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void generateExo()
        {
            ExEditObjectData exo = new ExEditObjectData();
            exo.Width = int.Parse(textBoxWidth.Text);
            exo.Height = int.Parse(textBoxHeight.Text);
            exo.FPS = (int)numericFPS.Value;
            exo.AudioRate = int.Parse(textBoxAudioRate.Text);
            exo.AudioCh = (int)numericAudioCh.Value;

            ObjectData.FPS = exo.FPS;
            //音声オブジェクトとそれ以外を分ける
            //音声オブジェクト以外は未実装のため簡略化
            var AudioObjects = ObjectList.Where(o => o.Type == ObjectType.Audio).ToList();
            //var OtherObjects = ObjectList.Where(o => o.Type != ObjectType.Audio).ToList();

            //音声オブジェクトの配置
            if (checkBoxRandomAudio.Checked)
            {
                var rnd = new Random();
                //同キー音声ランダム化ON
                for (int i = 0; i < checkedListBoxKey.Items.Count; i++)
                {
                    var key = checkedListBoxKey.Items[i].ToString();
                    var AudioObjectsPerKey = AudioObjects.Where(o => o.Keys.Contains(key)).ToList();
                    if (AudioObjectsPerKey.Any())
                    {
                        var vmdFrames = GetBasisVmdFrames(key);
                        foreach (var f in vmdFrames)
                        {
                            var o = AudioObjectsPerKey[rnd.Next(0, AudioObjectsPerKey.Count)];
                            exo.ObjectsSafeAdd(o.GetExEditObjectAt((int)f.FrameTime));
                        }
                    }
                }
            }
            else
            {
                foreach (var o in AudioObjects)
                {
                    foreach (var k in o.Keys)
                    {
                        var vmdFrames = GetBasisVmdFrames(k);
                        foreach (var f in vmdFrames)
                        {
                            exo.ObjectsSafeAdd(o.GetExEditObjectAt((int)f.FrameTime));
                        }
                    }
                }
            }

            //その他オブジェクトの配置
            //未実装のためなし

            //exoファイルの書き出し
            exo.Length = exo.Objects.Max(o => o.End);
            using (var writer = new StreamWriter("Generate_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".exo", false, System.Text.Encoding.GetEncoding("shift_jis")))
            {
                exo.Write(writer);
            }

            MessageBox.Show("EXOファイル出力完了");
        }

        private List<IVmdModelFrameData> GetBasisVmdFrames(string key)
        {
            var vmdFrames = new List<IVmdModelFrameData>();
            vmdFrames.AddRange(vmd.MotionFrames.Where(f => f.Name == key).Select(f => (IVmdModelFrameData)f).ToList());
            vmdFrames.AddRange(vmd.MorphFrames.Where(f => f.Name == key).Select(f => (IVmdModelFrameData)f).ToList());
            //初期位置は全てのボーンとモーフが含まれている可能性が高いため除去
            vmdFrames.RemoveAll(f => f.FrameTime == 0);

            vmdFrames.Sort();
            return vmdFrames;
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
        /// <summary>
        /// 30fps
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// 30fps
        /// </summary>
        public int Offset { get; set; }
        public ExEditObject ExObject { get; set; }
        public List<string> Keys { get; private set; }

        private AudioFileReader Audio;
        private static AudioFileReader playingAudio;
        public static WaveOut Player;

        public static int FPS { get; set; }

        public ObjectData(string path, ObjectType type, ExEditObject obj, int offset = 0)
        {
            Path = path;
            Type = type;
            Offset = offset;
            ExObject = obj;
            Keys = new List<string>();

            switch (Type)
            {
                case ObjectType.Audio:
                    Audio = new AudioFileReader(Path);
                    Length = (int)Math.Ceiling(Audio.TotalTime.TotalSeconds * 30);
                    Player = new WaveOut();
                    break;
                case ObjectType.Media:
                case ObjectType.Filter:
                default:
                    Length = 18;
                    break;
            }
        }

        public void PlayAudio(EventHandler<StoppedEventArgs> handler)
        {
            if (Type != ObjectType.Audio)
                return;

            if (Player.PlaybackState != PlaybackState.Playing)
            {
                Audio.Position = 0;
                Player.Init(Audio);
                Player.Play();
                playingAudio = Audio;
                Player.PlaybackStopped += handler;
            }
            else if (playingAudio != Audio)
            {
                Player.Dispose();
                Player = new WaveOut();
                Audio.Position = 0;
                Player.Init(Audio);
                Player.Play();
                playingAudio = Audio;
                Player.PlaybackStopped += handler;
            }
            else
            {
                Player.Stop();
                playingAudio = null;
                Player.PlaybackStopped -= handler;
            }
        }

        public void StopAudio()
        {
            if (Type != ObjectType.Audio)
                return;
            Player.Stop();
        }

        public bool isPlaying()
        {
            if (Type != ObjectType.Audio)
                return false;


            return playingAudio == Audio && Player.PlaybackState == PlaybackState.Playing;
        }

        public ExEditObject GetExEditObjectAt(int startFrame)
        {
            var obj = new ExEditObject(ExObject);
            obj.Start = FpsCorrection(startFrame) + FpsCorrection(Offset);
            obj.End = obj.Start + FpsCorrection(Length);
            return obj;
        }

        private static int FpsCorrection(int value)
        {
            return (int)Math.Ceiling(value * FPS / 30M);
        }
    }
}
