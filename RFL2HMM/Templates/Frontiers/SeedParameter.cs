using System.Numerics;
using System.Runtime.InteropServices;

public class SeedParameterClass
{
    public enum SeedType : byte
    {
        SeedSensor = 0,
        ObjItem = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct SeedParameter
    {
        [FieldOffset(0x00)] public float suckedTime;
        [FieldOffset(0x04)] public SeedType seedType;
    }

}