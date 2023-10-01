using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyDefenderConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct RingParameter
    {
        [FieldOffset(0x00)] public float suckedTime;
        [FieldOffset(0x04)] public float launchAngle;
        [FieldOffset(0x08)] public float launchMaxSpeed;
        [FieldOffset(0x0C)] public float launchMinSpeed;
        [FieldOffset(0x10)] public float randomRangeMin;
        [FieldOffset(0x14)] public float randomRangeMax;
        [FieldOffset(0x18)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct EnemyDefenderPatrolConfig
    {
        [FieldOffset(0x00)] public float changeTimeIdlePatrolMin;
        [FieldOffset(0x04)] public float changeTimeIdlePatrolMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct EnemyDefenderCommonConfig
    {
        [FieldOffset(0x00)] public RingParameter ringParam;
        [FieldOffset(0x1C)] public float mass;
        [FieldOffset(0x20)] public float slopeAngleMax;
        [FieldOffset(0x24)] public float checkBarrierDistance;
        [FieldOffset(0x28)] public float colliderRadius;
        [FieldOffset(0x2C)] public float colliderHeight;
        [FieldOffset(0x30)] public float damageColliderRadiusOffset;
        [FieldOffset(0x34)] public float boomerangColliderRadius;
        [FieldOffset(0x38)] public float boomerangColliderHeight;
        [FieldOffset(0x3C)] public float boomerangColliderOffset;
        [FieldOffset(0x40)] public float boomerangCameraKeepTimeMin;
        [FieldOffset(0x44)] public float eyesightDistance;
        [FieldOffset(0x48)] public float eyesightLostDelayTime;
        [FieldOffset(0x4C)] public EnemyDefenderPatrolConfig patrolConfig;
        [FieldOffset(0x54)] public float shieldBlowUpTime;
        [FieldOffset(0x58)] public float shieldBlowUpHeight;
        [FieldOffset(0x5C)] public float shieldBoomerangSpeed;
        [FieldOffset(0x60)] public float shieldBoomerangMinDistance;
        [FieldOffset(0x64)] public float shieldBoomerangMaxDistance;
        [FieldOffset(0x68)] public float killWaitTime;
        [FieldOffset(0x6C)] public float cameraDistance;
        [FieldOffset(0x70)] public float cameraElevation;
        [FieldOffset(0x74)] public int parryBoomerangRound;
        [FieldOffset(0x78)] public float parryBoomerangOffset;
        [FieldOffset(0x7C)] public float parryBoomerangSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct DefenderCommonLevelConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyDefenderLevelConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public DefenderCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xD0)]
    public struct EnemyDefenderConfig
    {
        [FieldOffset(0x00)] public EnemyDefenderCommonConfig commonParams;
        [FieldOffset(0x80)] public EnemyDefenderLevelConfig levelParams__arr0;
        [FieldOffset(0x90)] public EnemyDefenderLevelConfig levelParams__arr1;
        [FieldOffset(0xA0)] public EnemyDefenderLevelConfig levelParams__arr2;
        [FieldOffset(0xB0)] public EnemyDefenderLevelConfig levelParams__arr3;
        [FieldOffset(0xC0)] public EnemyDefenderLevelConfig levelParams__arr4;
    }

}