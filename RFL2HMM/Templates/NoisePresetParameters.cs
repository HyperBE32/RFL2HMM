using System.Numerics;
using System.Runtime.InteropServices;

public class NoisePresetParametersClass
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct UVShift
    {
        [FieldOffset(0)]  public float blockLNoiseSizeX;
        [FieldOffset(4)]  public float blockLNoiseSizeY;
        [FieldOffset(8)]  public float blockHNoiseSizeX;
        [FieldOffset(12)] public float blockHNoiseSizeY;
        [FieldOffset(16)] public float bNoiseHighRate;
        [FieldOffset(20)] public float intensity;
        [FieldOffset(24)] public float pixelShiftIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct ColorShift
    {
        [FieldOffset(0)]  public float blockLNoiseSize;
        [FieldOffset(4)]  public float blockHNoiseSize;
        [FieldOffset(8)]  public float bNoiseHighRate;
        [FieldOffset(12)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct InterlaceNoise
    {
        [FieldOffset(0)]  public float blockLNoiseSize;
        [FieldOffset(4)]  public float blockHNoiseSize;
        [FieldOffset(8)]  public float bNoiseHighRate;
        [FieldOffset(12)] public float intensity;
        [FieldOffset(16)] public float dropout;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct ColorDropout
    {
        [FieldOffset(0)]  public float blockLNoiseSizeX;
        [FieldOffset(4)]  public float blockLNoiseSizeY;
        [FieldOffset(8)]  public float blockHNoiseSizeX;
        [FieldOffset(12)] public float blockHNoiseSizeY;
        [FieldOffset(16)] public float bNoiseHighRate;
        [FieldOffset(20)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct InvertColor
    {
        [FieldOffset(0)]  public float blockLNoiseSizeX;
        [FieldOffset(4)]  public float blockLNoiseSizeY;
        [FieldOffset(8)]  public float blockHNoiseSizeX;
        [FieldOffset(12)] public float blockHNoiseSizeY;
        [FieldOffset(16)] public float bNoiseHighRate;
        [FieldOffset(20)] public float intensity;
        [FieldOffset(24)] public float invertAllRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct GlayScaleColor
    {
        [FieldOffset(0)]  public float blockLNoiseSizeX;
        [FieldOffset(4)]  public float blockLNoiseSizeY;
        [FieldOffset(8)]  public float blockHNoiseSizeX;
        [FieldOffset(12)] public float blockHNoiseSizeY;
        [FieldOffset(16)] public float bNoiseHighRate;
        [FieldOffset(20)] public float intensity;
        [FieldOffset(24)] public float invertAllRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 164)]
    public struct FxCyberSpaceStartNoiseParameter
    {
        [FieldOffset(0)]   public bool enable;
        [FieldOffset(4)]   public UVShift uvShift;
        [FieldOffset(32)]  public ColorShift colorShift;
        [FieldOffset(48)]  public InterlaceNoise interlaceNoise;
        [FieldOffset(68)]  public ColorDropout colorDrop;
        [FieldOffset(92)]  public InvertColor invertColor;
        [FieldOffset(120)] public GlayScaleColor glayscaleColor;
        [FieldOffset(148)] public float noiseSpeed;
        [FieldOffset(152)] public float noiseBias;
        [FieldOffset(156)] public float noiseWaveAmplitude;
        [FieldOffset(160)] public float noiseWaveCycle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1312)]
    public struct NoisePresetParameters
    {
        [FieldOffset(0)] public FxCyberSpaceStartNoiseParameter presets__arr0;
        [FieldOffset(164)] public FxCyberSpaceStartNoiseParameter presets__arr1;
        [FieldOffset(328)] public FxCyberSpaceStartNoiseParameter presets__arr2;
        [FieldOffset(492)] public FxCyberSpaceStartNoiseParameter presets__arr3;
        [FieldOffset(656)] public FxCyberSpaceStartNoiseParameter presets__arr4;
        [FieldOffset(820)] public FxCyberSpaceStartNoiseParameter presets__arr5;
        [FieldOffset(984)] public FxCyberSpaceStartNoiseParameter presets__arr6;
        [FieldOffset(1148)] public FxCyberSpaceStartNoiseParameter presets__arr7;
    }

}