﻿using SlimDX;
using System.Collections.Generic;
using System.IO;

namespace VmdIO
{
    public interface IVmdFrameData
    {
        uint FrameTime { get; set; }

        void Write(BinaryWriter writer);
    }

    public struct VmdMotionFrameData : IVmdFrameData
    {
        public string Name { get; set; }
        public uint FrameTime { get; set; }
        public Vector3 Pos { get; set; }
        public Quaternion Rot { get; set; }
        public byte[] Physics { get; set; }

        public byte[] InterpolatePointX { get; set; }
        public byte[] InterpolatePointY { get; set; }
        public byte[] InterpolatePointZ { get; set; }
        public byte[] InterpolatePointR { get; set; }

        public Vector2 InterpolationPointX1
        {
            get => new Vector2(InterpolatePointX[0] / 127.0F, InterpolatePointX[1] / 127.0F);
            set
            {
                InterpolatePointX[0] = (byte)(value.X * 127);
                InterpolatePointX[1] = (byte)(value.Y * 127);
            }
        }

        public Vector2 InterpolationPointX2
        {
            get => new Vector2(InterpolatePointX[2] / 127.0F, InterpolatePointX[3] / 127.0F);
            set
            {
                InterpolatePointX[2] = (byte)(value.X * 127);
                InterpolatePointX[3] = (byte)(value.Y * 127);
            }
        }

        public Vector2 InterpolationPointY1
        {
            get => new Vector2(InterpolatePointY[0] / 127.0F, InterpolatePointY[1] / 127.0F);
            set
            {
                InterpolatePointY[0] = (byte)(value.X * 127);
                InterpolatePointY[1] = (byte)(value.Y * 127);
            }
        }

        public Vector2 InterpolationPointY2
        {
            get => new Vector2(InterpolatePointY[2] / 127.0F, InterpolatePointY[3] / 127.0F);
            set
            {
                InterpolatePointY[2] = (byte)(value.X * 127);
                InterpolatePointY[3] = (byte)(value.Y * 127);
            }
        }

        public Vector2 InterpolationPointZ1
        {
            get => new Vector2(InterpolatePointZ[0] / 127.0F, InterpolatePointZ[1] / 127.0F);
            set
            {
                InterpolatePointZ[0] = (byte)(value.X * 127);
                InterpolatePointZ[1] = (byte)(value.Y * 127);
            }
        }

        public Vector2 InterpolationPointZ2
        {
            get => new Vector2(InterpolatePointZ[2] / 127.0F, InterpolatePointZ[3] / 127.0F);
            set
            {
                InterpolatePointZ[2] = (byte)(value.X * 127);
                InterpolatePointZ[3] = (byte)(value.Y * 127);
            }
        }

        public Vector2 InterpolationPointR1
        {
            get => new Vector2(InterpolatePointR[0] / 127.0F, InterpolatePointR[1] / 127.0F);
            set
            {
                InterpolatePointR[0] = (byte)(value.X * 127);
                InterpolatePointR[1] = (byte)(value.Y * 127);
            }
        }

        public Vector2 InterpolationPointR2
        {
            get => new Vector2(InterpolatePointR[2] / 127.0F, InterpolatePointR[3] / 127.0F);
            set
            {
                InterpolatePointR[2] = (byte)(value.X * 127);
                InterpolatePointR[3] = (byte)(value.Y * 127);
            }
        }

        public VmdMotionFrameData(string boneName, uint frameTime, Vector3 pos, Quaternion rot)
        {
            Name = boneName;
            FrameTime = frameTime;
            Pos = pos;
            Rot = rot;
            Physics = new byte[2] { 0, 0 };
            InterpolatePointX = new byte[] { 64, 64, 64, 64 };
            InterpolatePointY = new byte[] { 64, 64, 64, 64 };
            InterpolatePointZ = new byte[] { 64, 64, 64, 64 };
            InterpolatePointR = new byte[] { 64, 64, 64, 64 };
        }

        public void Write(BinaryWriter writer)
        {
            writer.WriteTextWithFixedLength(Name, VocaloidMotionData.BONE_NAME_LENGTH);
            writer.Write(FrameTime);
            writer.Write(Pos);
            writer.Write(Rot);
            WriteInterpolateData(writer);
        }

        private void WriteInterpolateData(BinaryWriter writer)
        {
            byte[][] interpolatePoint = new byte[][] { InterpolatePointX, InterpolatePointY, InterpolatePointZ, InterpolatePointR };

            byte[] distPart = new byte[16];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    distPart[i * 4 + j] = interpolatePoint[j][i];
                }
            }

            byte[] dist = new byte[64];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 16 - i; j++)
                {
                    dist[i * 16 + j] = distPart[j];
                }
            }

            dist[31] = dist[46] = dist[61] = 1;
            dist[2] = Physics[0];
            dist[3] = Physics[1];
            writer.Write(dist);
        }

        public VmdMotionFrameData(BinaryReader reader)
        {
            byte[] bName = reader.ReadBytes(VocaloidMotionData.BONE_NAME_LENGTH);
            Name = new string(VocaloidMotionData.Encoding.GetChars(bName));
            FrameTime = reader.ReadUInt32();
            Pos = reader.ReadVector3();
            Rot = reader.ReadQuaternion();
            Physics = new byte[2];
            InterpolatePointX = new byte[4];
            InterpolatePointY = new byte[4];
            InterpolatePointZ = new byte[4];
            InterpolatePointR = new byte[4];

            byte[] dist = reader.ReadBytes(64);
            Physics[0] = dist[2];
            Physics[1] = dist[3];
            for (int i = 0; i < 4; i++)
            {
                InterpolatePointX[i] = dist[i * 4];
                InterpolatePointY[i] = dist[i * 4 + 16];
                InterpolatePointZ[i] = dist[i * 4 + 32];
                InterpolatePointR[i] = dist[i * 4 + 48];
            }
        }

        public static byte[] ConvertToBytes(Vector2 pos1, Vector2 pos2)
        {
            return new byte[] { (byte)(pos1.X * 127), (byte)(pos1.Y * 127), (byte)(pos2.X * 127), (byte)(pos2.Y * 127) };
        }
    }

    public struct VmdMorphFrameData : IVmdFrameData
    {
        public string Name { get; set; }
        public uint FrameTime { get; set; }
        public float Weigth { get; set; }

        public VmdMorphFrameData(string morphName, uint frameTime, float weight)
        {
            Name = morphName;
            FrameTime = frameTime;
            Weigth = weight;
        }

        public void Write(BinaryWriter writer)
        {
            writer.WriteTextWithFixedLength(Name, VocaloidMotionData.MORPH_NAME_LENGTH);
            writer.Write(FrameTime);
            writer.Write(Weigth);
        }

        public VmdMorphFrameData(BinaryReader reader)
        {
            byte[] bName = reader.ReadBytes(VocaloidMotionData.MORPH_NAME_LENGTH);
            Name = new string(VocaloidMotionData.Encoding.GetChars(bName));
            FrameTime = reader.ReadUInt32();
            Weigth = reader.ReadSingle();
        }
    }

    public struct VmdCameraFrameData : IVmdFrameData
    {
        public uint FrameTime { get; set; }
        public float Length { get; set; }
        public Vector3 Pos { get; set; }
        public Vector3 Rot { get; set; }

        public byte[] InterpolatePointX { get; set; }
        public byte[] InterpolatePointY { get; set; }
        public byte[] InterpolatePointZ { get; set; }
        public byte[] InterpolatePointR { get; set; }
        public byte[] InterpolatePointD { get; set; }
        public byte[] InterpolatePointA { get; set; }

        byte Pers { get; set; }

        public VmdCameraFrameData(uint frameTime, float length, Vector3 pos, Vector3 rot) : this()
        {
            FrameTime = frameTime;
            Length = length;
            Pos = pos;
            Rot = rot;

            InterpolatePointX = new byte[] { 64, 64, 64, 64 };
            InterpolatePointY = new byte[] { 64, 64, 64, 64 };
            InterpolatePointZ = new byte[] { 64, 64, 64, 64 };
            InterpolatePointR = new byte[] { 64, 64, 64, 64 };
            InterpolatePointD = new byte[] { 64, 64, 64, 64 };
            InterpolatePointA = new byte[] { 64, 64, 64, 64 };

            Pers = 0;
        }

        public VmdCameraFrameData(BinaryReader reader)
        {
            FrameTime = reader.ReadUInt32();
            Length = reader.ReadSingle();
            Pos = reader.ReadVector3();
            Rot = reader.ReadVector3();

            InterpolatePointX = reader.ReadBytes(4);
            InterpolatePointY = reader.ReadBytes(4);
            InterpolatePointZ = reader.ReadBytes(4);
            InterpolatePointR = reader.ReadBytes(4);
            InterpolatePointD = reader.ReadBytes(4);
            InterpolatePointA = reader.ReadBytes(4);

            Pers = reader.ReadByte();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(FrameTime);
            writer.Write(Length);
            writer.Write(Pos);
            writer.Write(Rot);
            writer.Write(InterpolatePointX);
            writer.Write(InterpolatePointY);
            writer.Write(InterpolatePointZ);
            writer.Write(InterpolatePointR);
            writer.Write(InterpolatePointD);
            writer.Write(InterpolatePointA);
            writer.Write(Pers);
        }
    }

    public struct VmdLightFrameData : IVmdFrameData
    {
        public uint FrameTime { get; set; }
        public Vector3 RGB { get; set; }
        public Vector3 Pos { get; set; }

        public VmdLightFrameData(uint frameTime, Vector3 rgb, Vector3 pos)
        {
            FrameTime = frameTime;
            RGB = rgb;
            Pos = pos;
        }

        public VmdLightFrameData(BinaryReader reader)
        {
            FrameTime = reader.ReadUInt32();
            RGB = reader.ReadVector3();
            Pos = reader.ReadVector3();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(FrameTime);
            writer.Write(RGB);
            writer.Write(Pos);
        }
    }

    public struct VmdShadowFrameData : IVmdFrameData
    {
        public uint FrameTime { get; set; }
        public byte Mode { get; set; }
        public float Dist { get; set; }

        public VmdShadowFrameData(uint frameTime, byte mode, float dist)
        {
            FrameTime = frameTime;
            Mode = mode;
            Dist = dist;
        }

        public VmdShadowFrameData(BinaryReader reader)
        {
            FrameTime = reader.ReadUInt32();
            Mode = reader.ReadByte();
            Dist = reader.ReadSingle();
        }


        public void Write(BinaryWriter writer)
        {
            writer.Write(FrameTime);
            writer.Write(Mode);
            writer.Write(Dist);
        }

    }

    public struct VmdPropertyFrameData : IVmdFrameData
    {
        public uint FrameTime { get; set; }
        public bool IsVisible { get; set; }
        public Dictionary<string, bool> IKEnabled { get; set; }

        public VmdPropertyFrameData(uint frameTime, bool isVisible)
        {
            FrameTime = frameTime;
            IsVisible = isVisible;
            IKEnabled = new Dictionary<string, bool>();
        }

        public VmdPropertyFrameData(BinaryReader reader)
        {
            FrameTime = reader.ReadUInt32();
            IsVisible = reader.ReadByte() == 0 ? false : true;
            IKEnabled = new Dictionary<string, bool>();

            uint ikCount = reader.ReadUInt32();
            for (int i = 0; i < ikCount; i++)
            {
                byte[] bName = reader.ReadBytes(VocaloidMotionData.IK_NAME_LENGTH);
                IKEnabled.Add(
                    new string(VocaloidMotionData.Encoding.GetChars(bName)),
                    reader.ReadByte() == 0 ? false : true
                );
            }
        }

        public VmdPropertyFrameData(VmdPropertyFrameData frame)
        {
            FrameTime = frame.FrameTime;
            IsVisible = frame.IsVisible;
            IKEnabled = new Dictionary<string, bool>(frame.IKEnabled);
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(FrameTime);
            writer.Write(IsVisible ? (byte)1 : (byte)0);

            if (IKEnabled != null)
            {
                writer.Write(IKEnabled.Count);

                foreach (var pair in IKEnabled)
                {
                    writer.WriteTextWithFixedLength(pair.Key, VocaloidMotionData.IK_NAME_LENGTH);
                    writer.Write(pair.Value ? (byte)1 : (byte)0);
                }
            }
        }

    }
}