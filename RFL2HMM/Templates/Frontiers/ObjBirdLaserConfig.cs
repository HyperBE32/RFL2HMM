using System.Numerics;
using System.Runtime.InteropServices;

public class ObjBirdLaserConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct SpeedInfo
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float acceleration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct ObjBirdLaserConfig
    {
        [FieldOffset(0x00)] public SpeedInfo speedInfoToSonic;
        [FieldOffset(0x0C)] public SpeedInfo speedInfoToBird;
        [FieldOffset(0x18)] public float colliderLength;
        [FieldOffset(0x1C)] public float colliderRadius;
        [FieldOffset(0x20)] public float lifeTime;
        [FieldOffset(0x30)] public Vector3 laserScale;
    }

}