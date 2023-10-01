using System.Numerics;
using System.Runtime.InteropServices;

public class SequenceParameterClass
{
    public enum SequenceType : byte
    {
        SequenceSensor = 0,
        ObjItem = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct SequenceParameter
    {
        [FieldOffset(0x00)] public float suckedTime;
        [FieldOffset(0x04)] public SequenceType sequenceType;
    }

}