using System.Numerics;
using System.Runtime.InteropServices;

public class FxFieldScanEffectRenderParameterClass
{
    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct FxFieldScanEffectRenderParameter
    {
        [FieldOffset(0)]  public bool enable;
        [FieldOffset(16)] public Vector3 centerPos;
        [FieldOffset(32)] public Color8 color;
        [FieldOffset(36)] public float radius1;
        [FieldOffset(40)] public float radius2;
        [FieldOffset(44)] public float radius3;
        [FieldOffset(48)] public float intensity1;
        [FieldOffset(52)] public float intensity2;
        [FieldOffset(56)] public float intensity3;
        [FieldOffset(60)] public float gridIntensity;
        [FieldOffset(64)] public float innerWidth;
        [FieldOffset(68)] public float gridLineWidth;
        [FieldOffset(72)] public float gridLineSpan;
    }

}