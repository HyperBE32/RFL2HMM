using System.Numerics;
using System.Runtime.InteropServices;

public class ObjStriderBulletConfigClass
{
    public enum ShootingDirection : byte
    {
        Sonic = 0,
        Random = 1,
        NumShootingDirections = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct CommonBulletParam
    {
        [FieldOffset(0x00)] public ShootingDirection shootingDirection;
        [FieldOffset(0x04)] public float lifeTime;
        [FieldOffset(0x08)] public float speedToRail;
        [FieldOffset(0x0C)] public float speed;
        [FieldOffset(0x10)] public float yOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct HomingBulletParam
    {
        [FieldOffset(0)]  public CommonBulletParam commonBulletParam;
        [FieldOffset(0x14)] public float railChangeDelay;
        [FieldOffset(0x18)] public float turnaroundTime;
        [FieldOffset(0x1C)] public float splinePositionDistance;
        [FieldOffset(0x20)] public bool changesRails;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct ReverseHomingBulletParam
    {
        [FieldOffset(0)]  public CommonBulletParam commonBulletParam;
        [FieldOffset(0x14)] public float railChangeDelay;
        [FieldOffset(0x18)] public float turnaroundTime;
        [FieldOffset(0x1C)] public float splinePositionDistance;
        [FieldOffset(0x20)] public bool changesRails;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct SameBodyRailBulletParam
    {
        [FieldOffset(0)] public CommonBulletParam commonBulletParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x5C)]
    public struct ObjStriderBulletConfig
    {
        [FieldOffset(0x00)] public HomingBulletParam homingBulletParam;
        [FieldOffset(0x24)] public ReverseHomingBulletParam reverseHomingBulletParam;
        [FieldOffset(0x48)] public SameBodyRailBulletParam sameBodyRailBulletParam;
    }

}