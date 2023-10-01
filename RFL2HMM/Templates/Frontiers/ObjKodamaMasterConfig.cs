using System.Numerics;
using System.Runtime.InteropServices;

public class ObjKodamaMasterConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct KodamaMasterCamera
    {
        [FieldOffset(0x00)] public Vector3 camLookAtOffset;
        [FieldOffset(0x10)] public Vector3 camEyeOffset;
        [FieldOffset(0x20)] public float camFovy;
        [FieldOffset(0x24)] public float camRoll;
        [FieldOffset(0x28)] public float camEaseInTime;
        [FieldOffset(0x2C)] public float camEaseOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct ObjKodamaMasterConfig
    {
        [FieldOffset(0x00)] public float followingDistance;
        [FieldOffset(0x04)] public float followingNormalSpeed;
        [FieldOffset(0x08)] public float followingDecelerationSpeed;
        [FieldOffset(0x0C)] public float followingDecelerationDistance;
        [FieldOffset(0x10)] public float followingHomingDistance;
        [FieldOffset(0x14)] public float followingHomingNormalSpeed;
        [FieldOffset(0x18)] public float followingHomingDecelerationSpeed;
        [FieldOffset(0x1C)] public float followingHomingDecelerationDistance;
        [FieldOffset(0x20)] public float followingHeightPosition;
        [FieldOffset(0x30)] public KodamaMasterCamera beginCamera;
        [FieldOffset(0x60)] public KodamaMasterCamera endCamera;
    }

}