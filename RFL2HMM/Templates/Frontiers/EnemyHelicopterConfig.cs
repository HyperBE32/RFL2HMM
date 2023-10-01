using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyHelicopterConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct HeliDamageCol
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x10)] public Vector3 pos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct HeliCommon
    {
        [FieldOffset(0x00)] public float followRotateSpeed;
        [FieldOffset(0x10)] public HeliDamageCol damageCol;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct HeliAttackBase
    {
        [FieldOffset(0x00)] public float life;
        [FieldOffset(0x04)] public float attackInterval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct HeliBullet
    {
        [FieldOffset(0)]  public HeliAttackBase heliAttackBase;
        [FieldOffset(0x08)] public float bulletSpeed;
        [FieldOffset(0x0C)] public float gunRotateSpeed;
        [FieldOffset(0x10)] public byte attackChainNum;
        [FieldOffset(0x14)] public float attackChainInterval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct HeliBomb
    {
        [FieldOffset(0)] public HeliAttackBase heliAttackBase;
        [FieldOffset(0x08)] public float bombSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct EnemyHelicopterConfig
    {
        [FieldOffset(0x00)] public HeliCommon common;
        [FieldOffset(0x30)] public HeliBullet attackBullet;
        [FieldOffset(0x48)] public HeliBomb attackBomb;
    }

}