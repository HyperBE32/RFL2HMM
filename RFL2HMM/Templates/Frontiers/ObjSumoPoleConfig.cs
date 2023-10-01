using System.Numerics;
using System.Runtime.InteropServices;

public class ObjSumoPoleConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct ObjSumoPoleColliderConfig
    {
        [FieldOffset(0x00)] public float baseHeight;
        [FieldOffset(0x04)] public float baseRadius;
        [FieldOffset(0x08)] public float baseOffset;
        [FieldOffset(0x0C)] public float poleHeight;
        [FieldOffset(0x10)] public float poleRadius;
        [FieldOffset(0x14)] public float rigidAdditionalHeight;
        [FieldOffset(0x18)] public float ropeThicknessRigid;
        [FieldOffset(0x1C)] public float ropeThicknessDamage;
        [FieldOffset(0x20)] public float ropeThicknessArea;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct ObjSumoPoleSlingShotLookDownCameraConfig
    {
        [FieldOffset(0x00)] public float interpolationTime;
        [FieldOffset(0x04)] public float height;
        [FieldOffset(0x08)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4C)]
    public struct ObjSumoPoleSlingShotConfig
    {
        [FieldOffset(0x00)] public float shotGuideMoveDistance;
        [FieldOffset(0x04)] public float shotRaycastLength;
        [FieldOffset(0x08)] public float sweepCapsuleHeight;
        [FieldOffset(0x0C)] public float shotMoveLengthMax;
        [FieldOffset(0x10)] public int shotReflectCountMax;
        [FieldOffset(0x14)] public int shotReflectOwnerCountMax;
        [FieldOffset(0x18)] public float shotOffset;
        [FieldOffset(0x1C)] public float shotDirAngleLimit;
        [FieldOffset(0x20)] public float shotDirAngleChangeSpeed;
        [FieldOffset(0x24)] public float shotSpeedMin;
        [FieldOffset(0x28)] public float shotSpeedMax;
        [FieldOffset(0x2C)] public float shotSpeedAdd;
        [FieldOffset(0x30)] public float cancelSpeed;
        [FieldOffset(0x34)] public float bendPullLength;
        [FieldOffset(0x38)] public float aimTimeScale;
        [FieldOffset(0x3C)] public float aimLimitTime;
        [FieldOffset(0x40)] public ObjSumoPoleSlingShotLookDownCameraConfig cameraLookDown;
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct ObjSumoPoleSlingshotLineConfig
    {
        [FieldOffset(0x00)] public float width;
        [FieldOffset(0x04)] public float maxDistance;
        [FieldOffset(0x08)] public float tilingDistance;
        [FieldOffset(0x0C)] public float uvScrollSpeedMin;
        [FieldOffset(0x10)] public float uvScrollSpeedMax;
        [FieldOffset(0x14)] public int reflectCountSpeedMax;
        [FieldOffset(0x18)] public Color8 colors__arr0;
        [FieldOffset(0x117)] public Color8 colors__arr1;
        [FieldOffset(0x216)] public Color8 colors__arr2;
        [FieldOffset(0x315)] public Color8 colors__arr3;
        [FieldOffset(0x414)] public Color8 colors__arr4;
        [FieldOffset(0x2C)] public float colorIntensity;
        [FieldOffset(0x30)] public bool colorGradation;
        [FieldOffset(0x31)] public bool colorChangeAll;
    }

    public struct ColorF
    {
        public float A;
        public float R;
        public float G;
        public float B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x48)]
    public struct ObjSumoPoleRopeElectricConfig
    {
        [FieldOffset(0x00)] public float width;
        [FieldOffset(0x04)] public float tilingDistance;
        [FieldOffset(0x08)] public float fluctuationPeriod;
        [FieldOffset(0x0C)] public float fluctuationAmplitude;
        [FieldOffset(0x10)] public float uvScrollSpeed;
        [FieldOffset(0x14)] public ColorF colorPrimary;
        [FieldOffset(0x24)] public Color8 colorVertexEdge;
        [FieldOffset(0x28)] public Color8 colorVertexCenter;
        [FieldOffset(0x2C)] public float colorIntensityAnimTime;
        [FieldOffset(0x30)] public float colorIntensityMin;
        [FieldOffset(0x34)] public float colorIntensityMax;
        [FieldOffset(0x38)] public float patternChangeIntervalTime;
        [FieldOffset(0x3C)] public float edgeWidthScale;
        [FieldOffset(0x40)] public float edgeWidthScaleLength;
        [FieldOffset(0x44)] public float roll;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x6C)]
    public struct ObjSumoPoleRopeConfig
    {
        [FieldOffset(0x00)] public float timeAppear;
        [FieldOffset(0x04)] public float timeDisappear;
        [FieldOffset(0x08)] public int count;
        [FieldOffset(0x0C)] public float swingWidthMin;
        [FieldOffset(0x10)] public float swingWidthMax;
        [FieldOffset(0x14)] public float swingWidthReductionRate;
        [FieldOffset(0x18)] public float swingTime;
        [FieldOffset(0x1C)] public float swingPeriod;
        [FieldOffset(0x20)] public float swingReturnSlowTime;
        [FieldOffset(0x24)] public ObjSumoPoleRopeElectricConfig electric;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x114)]
    public struct ObjSumoPoleConfig
    {
        [FieldOffset(0x00)] public int electricDamageToEnemy;
        [FieldOffset(0x04)] public ObjSumoPoleColliderConfig collider;
        [FieldOffset(0x28)] public ObjSumoPoleSlingShotConfig slingShot;
        [FieldOffset(0x74)] public ObjSumoPoleSlingshotLineConfig line;
        [FieldOffset(0xA8)] public ObjSumoPoleRopeConfig rope;
    }

}