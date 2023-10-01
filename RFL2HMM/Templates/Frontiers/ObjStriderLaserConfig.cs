using System.Numerics;
using System.Runtime.InteropServices;

public class ObjStriderLaserConfigClass
{
    public struct ColorF
    {
        public float A;
        public float R;
        public float G;
        public float B;
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct ArcLaserConfig
    {
        [FieldOffset(0x00)] public float arrivalTime;
        [FieldOffset(0x04)] public byte numPatterns;
        [FieldOffset(0x08)] public float radius;
        [FieldOffset(0x0C)] public float tilingDistance;
        [FieldOffset(0x10)] public float fluctuationPeriod;
        [FieldOffset(0x14)] public float fluctuationAmplitude;
        [FieldOffset(0x18)] public float uvScrollSpeed;
        [FieldOffset(0x1C)] public ColorF colorPrimary;
        [FieldOffset(0x2C)] public Color8 colorVertexEdge;
        [FieldOffset(0x30)] public Color8 colorVertexCenter;
        [FieldOffset(0x34)] public float colorIntensity;
        [FieldOffset(0x38)] public float patternChangeIntervalTime;
        [FieldOffset(0x3C)] public float edgeWidthScale;
        [FieldOffset(0x40)] public float edgeWidthScaleLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x64)]
    public struct ObjStriderLaserConfig
    {
        [FieldOffset(0x00)] public float lifeTime;
        [FieldOffset(0x04)] public float degreeVelocityPrePostLaser;
        [FieldOffset(0x08)] public float degreeVelocity;
        [FieldOffset(0x0C)] public float degreeToRotate;
        [FieldOffset(0x10)] public float radius;
        [FieldOffset(0x14)] public float collisionRadius;
        [FieldOffset(0x18)] public float minStartingPointOffset;
        [FieldOffset(0x1C)] public float maxStartingPointOffset;
        [FieldOffset(0x20)] public ArcLaserConfig arcLaserConfig;
    }

}