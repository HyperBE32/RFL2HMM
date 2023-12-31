using System.Numerics;
using System.Runtime.InteropServices;

public class FxSSGIParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct FxSSGIDebugParameter
    {
        [FieldOffset(0)] public bool useDenoise;
        [FieldOffset(4)] public float rayLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct FxSSGIParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(4)]  public float intensity;
        [FieldOffset(8)]  public bool useAlbedo;
        [FieldOffset(9)]  public bool useParameter;
        [FieldOffset(12)] public FxSSGIDebugParameter debugParam;
    }

}