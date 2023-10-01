using System.Numerics;
using System.Runtime.InteropServices;

public class RecordDataClass
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct UnmanagedString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
            get
            {
                if (pValue == 0)
                    return string.Empty;

                return Marshal.PtrToStringAnsi((nint)pValue);
            }

            set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
        }

        public UnmanagedString(string in_value)
        {
            Value = in_value;
        }

        public static implicit operator UnmanagedString(string in_value)
        {
            return new UnmanagedString(in_value);
        }

        public static bool operator ==(UnmanagedString in_left, string in_right)
        {
            return in_left.Value == in_right;
        }

        public static bool operator !=(UnmanagedString in_left, string in_right)
        {
            return !(in_left == in_right);
        }

        public override bool Equals(object in_obj)
        {
            if (in_obj is string str)
                return Value == str;

            return base.Equals(in_obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }

    public enum EventType : sbyte
    {
        KEY = 0,
        INTERVAL = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct EventData
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public EventType type;
        [FieldOffset(0x14)] public float inTime;
        [FieldOffset(0x18)] public float outTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct EventDataArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct NodeInfoInAnim
    {
        [FieldOffset(0x00)] public Vector3 position;
        [FieldOffset(0x10)] public Quaternion rotation;
        [FieldOffset(0x20)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct NodeInfoInAnimArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct NodeData
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public NodeInfoInAnimArray nodeInfos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct NodeDataArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct DeltaMotionInfoInAnim
    {
        [FieldOffset(0x00)] public Vector3 position;
        [FieldOffset(0x10)] public Quaternion rotation;
        [FieldOffset(0x20)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct DeltaMotionInfoInAnimArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct DeltaMotionData
    {
        [FieldOffset(0x00)] public DeltaMotionInfoInAnimArray deltaInfos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x78)]
    public struct AnimData
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public EventDataArray eventDatas;
        [FieldOffset(0x30)] public NodeDataArray nodeDatas;
        [FieldOffset(0x50)] public DeltaMotionData deltaMotionData;
        [FieldOffset(0x70)] public float maxTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct AnimDataArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct RecordData
    {
        [FieldOffset(0x00)] public AnimDataArray animDatas;
    }

}