using System.Numerics;
using System.Runtime.InteropServices;

public class FxFXAAParameterClass
{
    public enum QualityType : sbyte
    {
        QUALITY_LOW = 0,
        QUALITY_MEDIUM = 1,
        QUALITY_HIGH = 2,
        QUALITY_COUNT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct FxFXAAParameter
    {
        [FieldOffset(0)] public QualityType qualityType;
    }

}