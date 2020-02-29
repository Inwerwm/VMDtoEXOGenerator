using System.Collections.Generic;
using System.IO;

namespace AviutlExEditObject
{
    class ExEditObjectData
    {
        public int Width { set; get; }
        public int Height { set; get; }
        public int FPS { set; get; }
        public int Scale { set; get; }
        public int Length { set; get; }
        public int AudioRate { set; get; }
        public int AudioCh { set; get; }

        public List<ExEditObject> Objects { private set; get; }

        public ExEditObjectData()
        {
            Width = 1920;
            Height = 1080;
            FPS = 30;
            Scale = 1;
            Length = 0;
            AudioRate = 44100;
            AudioCh = 2;

            Objects = new List<ExEditObject>();
        }

        public void Write(StreamWriter streamWriter)
        {
            streamWriter.Write(ToString());
            for (int i = 0; i < Objects.Count; i++)
            {
                streamWriter.Write(Objects[i].ToString(i));
            }
        }

        public override string ToString()
        {
            string output;
            output = "[exedit]\r\n";
            output += "width=" + Width.ToString() + "\r\n";
            output += "height=" + Height.ToString() + "\r\n";
            output += "rate=" + FPS.ToString() + "\r\n";
            output += "scale=" + Scale.ToString() + "\r\n";
            output += "length=" + Length.ToString() + "\r\n";
            output += "audio_rate=" + AudioRate.ToString() + "\r\n";
            output += "audio_ch=" + AudioCh.ToString() + "\r\n";
            return output;
        }
    }

    public class ExEditObject
    {
        public int Start { set; get; }
        public int End { set; get; }
        public int Layer { set; get; }
        public int Overlay { set; get; }
        public int Camera { set; get; }
        public int Audio { set; get; }
        public int Chain { set; get; }

        public List<IExObjectType> Property { private set; get; }
        public int Count { get { return Property.Count; } }

        public ExEditObject()
        {
            Start = 0;
            End = 0;
            Layer = 1;
            Overlay = 1;
            Camera = 0;
            Audio = 0;
            Chain = 0;

            Property = new List<IExObjectType>();
        }

        public string ToString(int index)
        {
            string output;

            output = "[" + index.ToString() + "]" + "\r\n";
            output += "start=" + Start.ToString() + "\r\n";
            output += "end=" + End.ToString() + "\r\n";
            output += "layer=" + Layer.ToString() + "\r\n";
            output += "overlay=" + Overlay.ToString() + "\r\n";
            output += "camera=" + Camera.ToString() + "\r\n";
            output += "audio=" + Audio.ToString() + "\r\n";
            output += "chain=" + Chain.ToString() + "\r\n";

            for (int i = 0; i < Property.Count; i++)
            {
                output += "[" + index.ToString() + "." + i.ToString() + "]" + "\r\n";
                output += Property[i].ToString();
            }

            return output;
        }
    }

    public interface IExObjectType
    {
        string ToString();

        /// <summary>
        /// 最終手段 なるべく使うべからず
        /// </summary>
        /// <returns>プロパティのobjectにキャストされた値が実装順に並んだList</returns>
        List<object> ToList();

        /// <summary>
        /// 最終手段 できるならコンストラクタでの上書きを使うこと
        /// </summary>
        /// <param name="list">プロパティの値を実装順に並べたList</param>
        void SetBy(List<object> list);
    }

    public class ExoAudio : IExObjectType
    {
        public float Start { get; set; }
        public float Speed { get; set; }
        public bool Loop { get; set; }
        public bool Linkage { get; set; }
        public string FilePath { get; set; }

        public ExoAudio(string filePath, float start = 0, float speed = 100, bool loop = false, bool linkage = false)
        {
            Start = start;
            Speed = speed;
            Loop = loop;
            Linkage = linkage;
            FilePath = filePath;
        }

        public override string ToString()
        {
            string output;
            output = "_name=音声ファイル\r\n";
            output += "再生位置=" + Start.ToString() + "\r\n";
            output += "再生速度=" + Speed.ToString() + "\r\n";
            output += "ループ再生=" + (Loop ? 1 : 0).ToString() + "\r\n";
            output += "動画ファイルと連携=" + (Linkage ? 1 : 0).ToString() + "\r\n";
            output += "file=" + FilePath + "\r\n";
            return output;
        }

        public List<object> ToList()
        {
            return new List<object> { Start, Speed, Loop, Linkage, FilePath };
        }

        public void SetBy(List<object> list)
        {
            if (list[0] != null)
                Start = (float)list[0];
            if (list[1] != null)
                Speed = (float)list[1];
            if (list[2] != null)
                Loop = (bool)list[2];
            if (list[3] != null)
                Linkage = (bool)list[3];
            if (list[4] != null)
                FilePath = (string)list[4];
        }
    }

    public class ExoStandardPlay : IExObjectType
    {
        public float Volume { get; set; }
        public float Side { get; set; }

        public ExoStandardPlay(float volume = 100, float side = 0)
        {
            Volume = volume;
            Side = side;
        }

        public override string ToString()
        {
            string output;
            output = "_name=標準再生\r\n";
            output += "音量=" + Volume.ToString() + "\r\n";
            output += "左右=" + Side.ToString() + "\r\n";
            return output;
        }

        public List<object> ToList()
        {
            return new List<object> { Volume, Side };
        }

        public void SetBy(List<object> list)
        {
            if (list[0] != null)
                Volume = (float)list[0];
            if (list[1] != null)
                Side = (float)list[1];
        }
    }
}
