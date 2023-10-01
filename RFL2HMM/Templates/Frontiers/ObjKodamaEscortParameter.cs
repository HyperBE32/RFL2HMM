using System.Numerics;
using System.Runtime.InteropServices;

public class ObjKodamaEscortParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct ObjKodamaEscortParameterElement
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x04)] public float stackingHeight;
        [FieldOffset(0x08)] public float blowAwayLengthMin;
        [FieldOffset(0x0C)] public float blowAwayLengthMax;
        [FieldOffset(0x10)] public float blowAwayHeightMin;
        [FieldOffset(0x14)] public float blowAwayHeightMax;
        [FieldOffset(0x18)] public float modelScale;
        [FieldOffset(0x1C)] public float modelScaleSticking;
        [FieldOffset(0x20)] public float capsuleRadius;
        [FieldOffset(0x24)] public float capsuleHeight;
        [FieldOffset(0x30)] public Vector3 capsuleOffset;
        [FieldOffset(0x40)] public float searchRadius;
        [FieldOffset(0x44)] public float rotationAnglePerSec;
        [FieldOffset(0x48)] public float verticalJumpSpeedMin;
        [FieldOffset(0x4C)] public float verticalJumpSpeedMax;
        [FieldOffset(0x50)] public float horizontalJumpSpeedMin;
        [FieldOffset(0x54)] public float horizontalJumpSpeedMax;
        [FieldOffset(0x58)] public float jumpInterval;
        [FieldOffset(0x5C)] public float contactRadius;
        [FieldOffset(0x60)] public float collectTime;
        [FieldOffset(0x64)] public float splineVelocityY;
        [FieldOffset(0x68)] public float splineVelocityMultiplier;
        [FieldOffset(0x6C)] public float splineJumpTime;
        [FieldOffset(0x70)] public float flockRange;
        [FieldOffset(0x74)] public float spaceHA;
        [FieldOffset(0x78)] public float maxTiltOfEachKodamaBending;
        [FieldOffset(0x7C)] public float bendingTimeDuringStop;
        [FieldOffset(0x80)] public float maxTiltOfEachKodamaBendingStop;
        [FieldOffset(0x84)] public float bendingCycleTimeDuringStay;
        [FieldOffset(0x88)] public float maxTiltOfEachKodamaBendingStay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1B0)]
    public struct ObjKodamaEscortParameter
    {
        [FieldOffset(0x00)] public ObjKodamaEscortParameterElement element__arr0;
        [FieldOffset(0x90)] public ObjKodamaEscortParameterElement element__arr1;
        [FieldOffset(0x120)] public ObjKodamaEscortParameterElement element__arr2;
    }

}