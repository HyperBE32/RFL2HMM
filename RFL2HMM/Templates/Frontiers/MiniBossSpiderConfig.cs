using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossSpiderConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossCommonConfig
    {
        [FieldOffset(0x00)] public float scoutDistance;
        [FieldOffset(0x04)] public float scoutDistanceOutside;
        [FieldOffset(0x08)] public float zoomDistance;
        [FieldOffset(0x10)] public Vector3 zoomOffset;
        [FieldOffset(0x20)] public Vector3 zoomAngle;
        [FieldOffset(0x30)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct MiniBossSpiderCameraShake
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float magnitude;
        [FieldOffset(0x08)] public int freq;
        [FieldOffset(0x0C)] public float attnRatio;
        [FieldOffset(0x10)] public float shakeRange;
    }

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

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct MiniBossSpiderWaveParam
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float appearRadius;
        [FieldOffset(0x08)] public float keepRadius;
        [FieldOffset(0x0C)] public float disappearRadius;
        [FieldOffset(0x10)] public float heightMin;
        [FieldOffset(0x14)] public float heightMax;
        [FieldOffset(0x18)] public float lifeTime;
        [FieldOffset(0x1C)] public float pauseBeginTime;
        [FieldOffset(0x20)] public float pauseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MiniBossSpiderCameraLockOn
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float minElevation;
        [FieldOffset(0x0C)] public float maxElevation;
        [FieldOffset(0x10)] public float panningSuspensionK;
        [FieldOffset(0x14)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct DebrisParameter
    {
        [FieldOffset(0x00)] public int m_maxNumPieces;
        [FieldOffset(0x04)] public float gravity;
        [FieldOffset(0x08)] public float lifeTime;
        [FieldOffset(0x0C)] public float force;
    }

    public enum MiniBossSpiderBreakType : sbyte
    {
        BREAK_NONE = 0,
        BREAK_LEG = 1,
        BREAK_AIR_LEG = 2,
        BREAK_BOUNCE_LEG = 3,
        BREAK_GIMMICK = 4,
        BREAK_ALL = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossSpiderLevelBandRate
    {
        [FieldOffset(0x00)] public float pressRate;
        [FieldOffset(0x04)] public float stompRate;
        [FieldOffset(0x08)] public float shotRate;
        [FieldOffset(0x0C)] public float chainRate;
        [FieldOffset(0x10)] public float traceRate;
        [FieldOffset(0x14)] public float laserStraightRate;
        [FieldOffset(0x18)] public float laserTraceRate;
        [FieldOffset(0x1C)] public float jumpRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossSpiderLevelBandInterval
    {
        [FieldOffset(0x00)] public float pressInterval;
        [FieldOffset(0x04)] public float stompInterval;
        [FieldOffset(0x08)] public float shotInterval;
        [FieldOffset(0x0C)] public float chainInterval;
        [FieldOffset(0x10)] public float traceInterval;
        [FieldOffset(0x14)] public float laserStaightInterval;
        [FieldOffset(0x18)] public float laserTraceInterval;
        [FieldOffset(0x1C)] public float jumpInterval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC4)]
    public struct MiniBossSpiderActionParam
    {
        [FieldOffset(0x00)] public float nearRange;
        [FieldOffset(0x04)] public MiniBossSpiderLevelBandRate nearRates__arr0;
        [FieldOffset(0x24)] public MiniBossSpiderLevelBandRate nearRates__arr1;
        [FieldOffset(0x44)] public MiniBossSpiderLevelBandRate farRates__arr0;
        [FieldOffset(0x64)] public MiniBossSpiderLevelBandRate farRates__arr1;
        [FieldOffset(0x84)] public MiniBossSpiderLevelBandInterval interval__arr0;
        [FieldOffset(0xA4)] public MiniBossSpiderLevelBandInterval interval__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x5F0)]
    public struct MiniBossSpiderCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
        [FieldOffset(0x40)] public float patrolWalkWaitTimeMin;
        [FieldOffset(0x44)] public float patrolWalkWaitTimeMax;
        [FieldOffset(0x48)] public float jumpSpeed;
        [FieldOffset(0x4C)] public float pressDistance;
        [FieldOffset(0x50)] public float waveDistance;
        [FieldOffset(0x54)] public float waveModelScale;
        [FieldOffset(0x58)] public float waveModelDiameter;
        [FieldOffset(0x5C)] public float waveWaitTime;
        [FieldOffset(0x60)] public float mineDistance;
        [FieldOffset(0x64)] public float shotWaitTime;
        [FieldOffset(0x68)] public float walkWaitTime;
        [FieldOffset(0x6C)] public float laserStraightDistance;
        [FieldOffset(0x70)] public float laserStraightPrepairTime;
        [FieldOffset(0x74)] public float laserStraightTime;
        [FieldOffset(0x78)] public float laserStraightAngle;
        [FieldOffset(0x7C)] public float laserStraightWaitTime;
        [FieldOffset(0x80)] public float laserTraceDistance;
        [FieldOffset(0x84)] public float laserTracePrepairTime;
        [FieldOffset(0x88)] public float laserTraceTime;
        [FieldOffset(0x8C)] public float laserTraceSpeed;
        [FieldOffset(0x90)] public float laserTraceWaitTime;
        [FieldOffset(0x94)] public float chainDistance;
        [FieldOffset(0x98)] public float chainJumpDistance;
        [FieldOffset(0x9C)] public float chainWaitTime;
        [FieldOffset(0xA0)] public float traceDistance;
        [FieldOffset(0xA4)] public float traceJumpDistance;
        [FieldOffset(0xA8)] public float traceSpeed;
        [FieldOffset(0xAC)] public float traceRotSpeed;
        [FieldOffset(0xB0)] public float traceLifeTime;
        [FieldOffset(0xB4)] public float traceWidth;
        [FieldOffset(0xB8)] public float traceHeight;
        [FieldOffset(0xBC)] public float traceAppearDistance;
        [FieldOffset(0xC0)] public float traceKeepDistance;
        [FieldOffset(0xC4)] public float traceDisappearDistance;
        [FieldOffset(0xC8)] public float traceWaitTime;
        [FieldOffset(0xCC)] public float thornSpawnSpeed;
        [FieldOffset(0xD0)] public float thornSpawnRadiusMax;
        [FieldOffset(0xD4)] public float thornLifeTime;
        [FieldOffset(0xD8)] public float thornFlyingSpeed;
        [FieldOffset(0xDC)] public int protecterHp;
        [FieldOffset(0xE0)] public MiniBossSpiderCameraShake cameraShakeWalk;
        [FieldOffset(0xF4)] public MiniBossSpiderCameraShake cameraShakeAttack;
        [FieldOffset(0x108)] public RingParameter ringParam;
        [FieldOffset(0x124)] public MiniBossSpiderWaveParam waveParams__arr0;
        [FieldOffset(0x148)] public MiniBossSpiderWaveParam waveParams__arr1;
        [FieldOffset(0x16C)] public MiniBossSpiderWaveParam waveParams__arr2;
        [FieldOffset(0x190)] public MiniBossSpiderWaveParam waveParams__arr3;
        [FieldOffset(0x1B4)] public MiniBossSpiderWaveParam waveParams__arr4;
        [FieldOffset(0x1D8)] public MiniBossSpiderWaveParam waveParams__arr5;
        [FieldOffset(0x1FC)] public MiniBossSpiderWaveParam waveParams__arr6;
        [FieldOffset(0x220)] public MiniBossSpiderWaveParam waveParams__arr7;
        [FieldOffset(0x244)] public MiniBossSpiderCameraLockOn cameraLockBreakArmor;
        [FieldOffset(0x25C)] public MiniBossSpiderCameraLockOn cameraLockBlownUp;
        [FieldOffset(0x274)] public MiniBossSpiderCameraLockOn cameraLockBlownDown;
        [FieldOffset(0x28C)] public MiniBossSpiderCameraLockOn cameraLockFootUp;
        [FieldOffset(0x2A4)] public MiniBossSpiderCameraLockOn cameraLockFall;
        [FieldOffset(0x2BC)] public DebrisParameter debrisSet;
        [FieldOffset(0x2CC)] public MiniBossSpiderBreakType rotationTypeTable__arr0;
        [FieldOffset(0x2CD)] public MiniBossSpiderBreakType rotationTypeTable__arr1;
        [FieldOffset(0x2CE)] public MiniBossSpiderBreakType rotationTypeTable__arr2;
        [FieldOffset(0x2CF)] public MiniBossSpiderBreakType rotationTypeTable__arr3;
        [FieldOffset(0x2D0)] public MiniBossSpiderBreakType rotationTypeTable__arr4;
        [FieldOffset(0x2D1)] public MiniBossSpiderBreakType rotationTypeTable__arr5;
        [FieldOffset(0x2D2)] public MiniBossSpiderBreakType rotationTypeTable__arr6;
        [FieldOffset(0x2D3)] public MiniBossSpiderBreakType rotationTypeTable__arr7;
        [FieldOffset(0x2D4)] public MiniBossSpiderActionParam rotationActionTable__arr0;
        [FieldOffset(0x398)] public MiniBossSpiderActionParam rotationActionTable__arr1;
        [FieldOffset(0x45C)] public MiniBossSpiderActionParam rotationActionTable__arr2;
        [FieldOffset(0x520)] public MiniBossSpiderActionParam rotationActionTable__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct MiniBossLevelCommonConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float maxStunPoint__arr0;
        [FieldOffset(0x08)] public float maxStunPoint__arr1;
        [FieldOffset(0x0C)] public float maxStunPoint__arr2;
        [FieldOffset(0x10)] public float stunDecreaseStartTime;
        [FieldOffset(0x14)] public float stunDecreaseSpeed;
        [FieldOffset(0x18)] public float maxStaggerPoint__arr0;
        [FieldOffset(0x1C)] public float maxStaggerPoint__arr1;
        [FieldOffset(0x20)] public float maxStaggerPoint__arr2;
        [FieldOffset(0x24)] public float staggerDecreaseStartTime;
        [FieldOffset(0x28)] public float staggerDecreaseSpeed;
        [FieldOffset(0x2C)] public float attackRate;
        [FieldOffset(0x30)] public ushort expItemNum;
        [FieldOffset(0x32)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x54)]
    public struct MiniBossSpiderLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
        [FieldOffset(0x38)] public float attackRate;
        [FieldOffset(0x3C)] public float stunTime;
        [FieldOffset(0x40)] public float downTime;
        [FieldOffset(0x44)] public float downTime2;
        [FieldOffset(0x48)] public float reProtectWaitTime;
        [FieldOffset(0x4C)] public float patrolWalkWaitTimeMin;
        [FieldOffset(0x50)] public float patrolWalkWaitTimeMax;
    }

    public enum MiniBossSpiderLevelBand_MiniBossSpiderBreakType : sbyte
    {
        MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_NONE = 0,
        MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_LEG = 1,
        MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_AIR_LEG = 2,
        MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_BOUNCE_LEG = 3,
        MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_GIMMICK = 4,
        MiniBossSpiderLevelBand_MiniBossSpiderBreakType_BREAK_ALL = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct MiniBossSpiderLevelPhaseAction
    {
        [FieldOffset(0x00)] public sbyte pressType;
        [FieldOffset(0x01)] public byte pressNum;
        [FieldOffset(0x04)] public float pressWaitTime;
        [FieldOffset(0x08)] public sbyte stompType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct MiniBossSpiderLevelPhaseDiving
    {
        [FieldOffset(0x00)] public float divingEndHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x150)]
    public struct MiniBossSpiderLevelBand
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public float phaseChangeHpRatio;
        [FieldOffset(0x08)] public int walkWaveId;
        [FieldOffset(0x0C)] public int stompWaveId;
        [FieldOffset(0x10)] public int pressWaveId;
        [FieldOffset(0x14)] public bool enableCounterKick;
        [FieldOffset(0x15)] public MiniBossSpiderLevelBand_MiniBossSpiderBreakType breakType;
        [FieldOffset(0x18)] public float mineRadius;
        [FieldOffset(0x1C)] public float mineExplodeRadius;
        [FieldOffset(0x20)] public int mineNum;
        [FieldOffset(0x24)] public float mineStartSpeed;
        [FieldOffset(0x28)] public float mineDecelePower;
        [FieldOffset(0x2C)] public float mineMinSpeed;
        [FieldOffset(0x30)] public float mineParriedSpeed;
        [FieldOffset(0x34)] public float mineLifeTime;
        [FieldOffset(0x38)] public float mineEnableParryRate;
        [FieldOffset(0x3C)] public int mineHorizonMaxNum;
        [FieldOffset(0x40)] public int mineVerticalNum;
        [FieldOffset(0x44)] public int shotCount;
        [FieldOffset(0x48)] public float chainLifeTime;
        [FieldOffset(0x4C)] public float chainTraceTime;
        [FieldOffset(0x50)] public float chainSpeed;
        [FieldOffset(0x54)] public float chainWaitTime;
        [FieldOffset(0x58)] public float chainRotateSpeed;
        [FieldOffset(0x5C)] public int chainWaveNum;
        [FieldOffset(0x60)] public bool enableReProtect;
        [FieldOffset(0x64)] public float nearRange;
        [FieldOffset(0x68)] public MiniBossSpiderLevelBandRate nearRates__arr0;
        [FieldOffset(0x88)] public MiniBossSpiderLevelBandRate nearRates__arr1;
        [FieldOffset(0xA8)] public MiniBossSpiderLevelBandRate farRates__arr0;
        [FieldOffset(0xC8)] public MiniBossSpiderLevelBandRate farRates__arr1;
        [FieldOffset(0xE8)] public MiniBossSpiderLevelPhaseAction phases__arr0;
        [FieldOffset(0xF4)] public MiniBossSpiderLevelPhaseAction phases__arr1;
        [FieldOffset(0x100)] public MiniBossSpiderLevelBandInterval interval__arr0;
        [FieldOffset(0x120)] public MiniBossSpiderLevelBandInterval interval__arr1;
        [FieldOffset(0x140)] public MiniBossSpiderLevelPhaseDiving diving__arr0;
        [FieldOffset(0x144)] public MiniBossSpiderLevelPhaseDiving diving__arr1;
        [FieldOffset(0x148)] public float slowRate__arr0;
        [FieldOffset(0x14C)] public float slowRate__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE30)]
    public struct MiniBossSpiderConfig
    {
        [FieldOffset(0x00)] public MiniBossSpiderCommonParam commonParam;
        [FieldOffset(0x5F0)] public MiniBossSpiderLevelParam levelParams__arr0;
        [FieldOffset(0x644)] public MiniBossSpiderLevelParam levelParams__arr1;
        [FieldOffset(0x698)] public MiniBossSpiderLevelParam levelParams__arr2;
        [FieldOffset(0x6EC)] public MiniBossSpiderLevelParam levelParams__arr3;
        [FieldOffset(0x740)] public MiniBossSpiderLevelParam levelParams__arr4;
        [FieldOffset(0x794)] public MiniBossSpiderLevelBand levelBands__arr0;
        [FieldOffset(0x8E4)] public MiniBossSpiderLevelBand levelBands__arr1;
        [FieldOffset(0xA34)] public MiniBossSpiderLevelBand levelBands__arr2;
        [FieldOffset(0xB84)] public MiniBossSpiderLevelBand levelBands__arr3;
        [FieldOffset(0xCD4)] public MiniBossSpiderLevelBand levelBands__arr4;
    }

}