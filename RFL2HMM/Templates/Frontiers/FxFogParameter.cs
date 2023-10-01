using System.Numerics;
using System.Runtime.InteropServices;

public class FxFogParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FxDistanceFogParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector3 color;
        [FieldOffset(0x20)] public float intensity;
        [FieldOffset(0x24)] public float nearDist;
        [FieldOffset(0x28)] public float farDist;
        [FieldOffset(0x2C)] public float influence;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxHeightFogParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector3 color;
        [FieldOffset(0x20)] public float intensity;
        [FieldOffset(0x24)] public float minHeight;
        [FieldOffset(0x28)] public float maxHeight;
        [FieldOffset(0x2C)] public float nearDist;
        [FieldOffset(0x30)] public float farDist;
        [FieldOffset(0x34)] public float influence;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct FxFogParameter
    {
        [FieldOffset(0x00)] public FxDistanceFogParameter distanceFogParam;
        [FieldOffset(0x30)] public FxHeightFogParameter heightFogParam;
    }

}