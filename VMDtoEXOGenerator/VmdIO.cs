using SlimDX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VmdIO
{
    class VocaloidMotionData
    {
        public static readonly Encoding Encoding = Encoding.GetEncoding("Shift_JIS");

        public const int HEADER_LENGTH = 30;
        public const int MODEL_NAME_LENGTH = 20;
        public const int BONE_NAME_LENGTH = 15;
        public const int MORPH_NAME_LENGTH = 15;
        public const int IK_NAME_LENGTH = 20;

        // ヘッダ
        public string header = "Vocaloid Motion Data 0002";
        public string ModelName { get; set; }

        public List<VmdMotionFrameData> MotionFrames { get; set; }
        public List<VmdMorphFrameData> MorphFrames { get; set; }
        public List<VmdCameraFrameData> CameraFrames { get; set; }
        public List<VmdLightFrameData> LightFrames { get; set; }
        public List<VmdShadowFrameData> ShadowFrames { get; set; }
        public List<VmdPropertyFrameData> PropertyFrames { get; set; }

        public VocaloidMotionData()
        {
            ModelName = "";
            MotionFrames = new List<VmdMotionFrameData>();
            MorphFrames = new List<VmdMorphFrameData>();
            PropertyFrames = new List<VmdPropertyFrameData>();
        }

        public void Clear()
        {
            header = "Vocaloid Motion Data 0002";
            ModelName = "";
            MotionFrames = new List<VmdMotionFrameData>();
            MorphFrames = new List<VmdMorphFrameData>();
            PropertyFrames = new List<VmdPropertyFrameData>();
        }

        public void Write(BinaryWriter writer)
        {
            writer.WriteTextWithFixedLength(header, HEADER_LENGTH);
            writer.WriteTextWithFixedLength(ModelName, MODEL_NAME_LENGTH);
            WriteVmdFrameData(MotionFrames, writer);
            WriteVmdFrameData(MorphFrames, writer);
            /*
            WriteVmdFrameData(CameraFrames, writer);
            WriteVmdFrameData(LightFrames, writer);
            WriteVmdFrameData(ShadowFrames, writer);
            */
            WriteVmdFrameData(PropertyFrames, writer);
        }

        private void WriteVmdFrameData<T>(T data, BinaryWriter writer) where T : IVmdFrameData
        {
            data.Write(writer);
        }

        private void WriteVmdFrameData<T>(List<T> data, BinaryWriter writer) where T : IVmdFrameData
        {
            int len = data.Count;
            writer.Write(len);

            //vmd読み込み高速化のためフレーム時間逆順で書き込み
            data.Sort((x, y) => y.FrameTime.CompareTo(x.FrameTime));
            for (int i = 0; i < len; i++)
            {
                WriteVmdFrameData(data[i], writer);
            }
        }

        public void Read(BinaryReader reader)
        {
            byte[] bChar = reader.ReadBytes(HEADER_LENGTH);
            header = new string(Encoding.GetChars(bChar));
            bChar = reader.ReadBytes(MODEL_NAME_LENGTH);
            ModelName = new string(Encoding.GetChars(bChar));

            uint len = reader.ReadUInt32();
            for (int i = 0; i < len; i++)
            {
                MotionFrames.Add(new VmdMotionFrameData(reader));
            }

            len = reader.ReadUInt32();
            for (int i = 0; i < len; i++)
            {
                MorphFrames.Add(new VmdMorphFrameData(reader));
            }

            //camera
            len = reader.ReadUInt32();
            for (int i = 0; i < len; i++)
            {
                CameraFrames.Add(new VmdCameraFrameData(reader));
            }

            //light
            len = reader.ReadUInt32();
            for (int i = 0; i < len; i++)
            {
                LightFrames.Add(new VmdLightFrameData(reader));
            }

            //self shadow
            len = reader.ReadUInt32();
            for (int i = 0; i < len; i++)
            {
                ShadowFrames.Add(new VmdShadowFrameData(reader));
            }

            len = reader.ReadUInt32();
            for (int i = 0; i < len; i++)
            {
                PropertyFrames.Add(new VmdPropertyFrameData(reader));
            }
        }
    }

    public static class VmdBinaryIOExtensions
    {
        public static void WriteTextWithFixedLength(this BinaryWriter writer, string text, int fixedLength, string filled = "\0")
        {
            byte[] bytes = VocaloidMotionData.Encoding.GetBytes(text);

            if (bytes.Length > fixedLength)
            {
                byte[] fixedBytes = new byte[fixedLength];
                Array.Copy(bytes, fixedBytes, fixedLength);
                bytes = fixedBytes;
            }

            writer.Write(bytes);

            int remain = fixedLength - bytes.Length;
            if (remain > 0)
            {
                writer.WriteFiller(VocaloidMotionData.Encoding.GetBytes(filled), remain);
            }
        }

        private static void WriteFiller(this BinaryWriter writer, byte[] filler, int fillerLength)
        {
            if (filler.Length <= 0 || fillerLength <= 0) return;

            byte lastData = filler[filler.Length - 1];

            int fillerIdx = 0;
            for (int remain = fillerLength; remain > 0; remain--)
            {
                byte bVal = fillerIdx < filler.Length ? filler[fillerIdx++] : lastData;
                writer.Write(bVal);
            }
        }

        public static void Write(this BinaryWriter writer, Vector2 vec)
        {
            writer.Write(vec.X);
            writer.Write(vec.Y);
        }

        public static void Write(this BinaryWriter writer, Vector3 vec)
        {
            writer.Write(vec.X);
            writer.Write(vec.Y);
            writer.Write(vec.Z);
        }

        public static void Write(this BinaryWriter writer, Vector4 vec)
        {
            writer.Write(vec.X);
            writer.Write(vec.Y);
            writer.Write(vec.Z);
            writer.Write(vec.W);
        }

        public static void Write(this BinaryWriter writer, Quaternion vec)
        {
            writer.Write(vec.X);
            writer.Write(vec.Y);
            writer.Write(vec.Z);
            writer.Write(vec.W);
        }

        public static Vector2 ReadVector2(this BinaryReader reader)
        {
            Vector2 vec = new Vector2();
            vec.X = reader.ReadSingle();
            vec.Y = reader.ReadSingle();
            return vec;
        }

        public static Vector3 ReadVector3(this BinaryReader reader)
        {
            Vector3 vec = new Vector3();
            vec.X = reader.ReadSingle();
            vec.Y = reader.ReadSingle();
            vec.Z = reader.ReadSingle();
            return vec;
        }

        public static Vector4 ReadVector4(this BinaryReader reader)
        {
            Vector4 vec = new Vector4();
            vec.X = reader.ReadSingle();
            vec.Y = reader.ReadSingle();
            vec.Z = reader.ReadSingle();
            vec.W = reader.ReadSingle();
            return vec;
        }

        public static Quaternion ReadQuaternion(this BinaryReader reader)
        {
            Quaternion vec = new Quaternion();
            vec.X = reader.ReadSingle();
            vec.Y = reader.ReadSingle();
            vec.Z = reader.ReadSingle();
            vec.W = reader.ReadSingle();
            return vec;
        }
    }
}
