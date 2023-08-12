using System.Numerics;
using System.Runtime.InteropServices;

public class AmyParametersClass
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct PlayerParamOffensive
    {
        [FieldOffset(0)]  public ushort pointMin;
        [FieldOffset(2)]  public ushort pointMax;
        [FieldOffset(4)]  public float damageRandomRate;
        [FieldOffset(8)]  public float damageRandomRateSS;
        [FieldOffset(12)] public float shapeDamageRate;
        [FieldOffset(16)] public float shapeStunRate;
        [FieldOffset(20)] public float shapeStaggerRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PlayerParamDefensive
    {
        [FieldOffset(0)] public byte rateMin;
        [FieldOffset(1)] public byte rateMax;
        [FieldOffset(2)] public ushort infimumDropRings;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct PlayerParamAttackCommon
    {
        [FieldOffset(0)]  public PlayerParamOffensive offensive;
        [FieldOffset(24)] public PlayerParamDefensive defensive;
        [FieldOffset(28)] public float criticalDamageRate;
        [FieldOffset(32)] public float criticalRate;
        [FieldOffset(36)] public float criticalRateSS;
        [FieldOffset(40)] public float downedDamageRate;
    }

    public enum HitSE : sbyte
    {
        SE_None = -1,
        Weak = 0,
        Strong = 1,
        VeryStrong = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
        	get => Marshal.PtrToStringAnsi((IntPtr)pValue);
        	set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 352)]
    public struct PlayerParamAttackData
    {
        [FieldOffset(0)]   public float damageRate;
        [FieldOffset(4)]   public float damageRateSS;
        [FieldOffset(8)]   public float damageRateAcceleMode;
        [FieldOffset(12)]  public float damageRateManual;
        [FieldOffset(16)]  public float stunPoint;
        [FieldOffset(20)]  public float staggerPoint;
        [FieldOffset(32)]  public Vector3 velocity;
        [FieldOffset(48)]  public float velocityKeepTime;
        [FieldOffset(52)]  public float addComboValue;
        [FieldOffset(56)]  public float addComboValueAccele;
        [FieldOffset(60)]  public float addComboValueSS;
        [FieldOffset(64)]  public float addComboValueAcceleSS;
        [FieldOffset(68)]  public float addQuickCyloopEnergy;
        [FieldOffset(72)]  public float addQuickCyloopEnergyAccele;
        [FieldOffset(76)]  public float addQuickCyloopEnergySS;
        [FieldOffset(80)]  public float addQuickCyloopEnergyAcceleSS;
        [FieldOffset(84)]  public float addQuickCyloopEnergyGuard;
        [FieldOffset(88)]  public float addQuickCyloopEnergyAcceleGuard;
        [FieldOffset(96)]  public Vector3 gimmickVelocity;
        [FieldOffset(112)] public float ignoreTime;
        [FieldOffset(116)] public ushort attributes;
        [FieldOffset(118)] public HitSE se;
        [FieldOffset(120)] public CString hitEffectName;
        [FieldOffset(136)] public CString hitEffectNameSS;
        [FieldOffset(152)] public CString hitStopName;
        [FieldOffset(168)] public CString hitStopNameDead;
        [FieldOffset(184)] public CString hitStopNameDeadBoss;
        [FieldOffset(200)] public CString hitStopNameSS;
        [FieldOffset(216)] public CString hitStopNameDeadSS;
        [FieldOffset(232)] public CString hitCameraShakeName;
        [FieldOffset(248)] public CString hitCameraShakeNameDead;
        [FieldOffset(264)] public CString hitCameraShakeNameDeadBoss;
        [FieldOffset(280)] public CString hitCameraShakeNameSS;
        [FieldOffset(296)] public CString hitCameraShakeNameDeadSS;
        [FieldOffset(312)] public CString hitVibrationName;
        [FieldOffset(328)] public CString hitVibrationNameSS;
    }

    [StructLayout(LayoutKind.Explicit, Size = 15536)]
    public struct PlayerParamAttack
    {
        [FieldOffset(0)]     public PlayerParamAttackCommon common;
        [FieldOffset(48)]    public PlayerParamAttackData spinAttack;
        [FieldOffset(400)]   public PlayerParamAttackData spinDash;
        [FieldOffset(752)]   public PlayerParamAttackData homingAttack;
        [FieldOffset(1104)]  public PlayerParamAttackData homingAttackAir;
        [FieldOffset(1456)]  public PlayerParamAttackData pursuitKick;
        [FieldOffset(1808)]  public PlayerParamAttackData stomping;
        [FieldOffset(2160)]  public PlayerParamAttackData stompingAttack;
        [FieldOffset(2512)]  public PlayerParamAttackData boundStompingLast;
        [FieldOffset(2864)]  public PlayerParamAttackData sliding;
        [FieldOffset(3216)]  public PlayerParamAttackData loopKick;
        [FieldOffset(3568)]  public PlayerParamAttackData crasher;
        [FieldOffset(3920)]  public PlayerParamAttackData spinSlashHoming;
        [FieldOffset(4272)]  public PlayerParamAttackData spinSlash;
        [FieldOffset(4624)]  public PlayerParamAttackData spinSlashLast;
        [FieldOffset(4976)]  public PlayerParamAttackData sonicBoom;
        [FieldOffset(5328)]  public PlayerParamAttackData crossSlash;
        [FieldOffset(5680)]  public PlayerParamAttackData homingShot;
        [FieldOffset(6032)]  public PlayerParamAttackData chargeAttack;
        [FieldOffset(6384)]  public PlayerParamAttackData chargeAttackLast;
        [FieldOffset(6736)]  public PlayerParamAttackData cyloop;
        [FieldOffset(7088)]  public PlayerParamAttackData cyloopQuick;
        [FieldOffset(7440)]  public PlayerParamAttackData cyloopAerial;
        [FieldOffset(7792)]  public PlayerParamAttackData accele1;
        [FieldOffset(8144)]  public PlayerParamAttackData accele2;
        [FieldOffset(8496)]  public PlayerParamAttackData aerialAccele1;
        [FieldOffset(8848)]  public PlayerParamAttackData aerialAccele2;
        [FieldOffset(9200)]  public PlayerParamAttackData comboFinish;
        [FieldOffset(9552)]  public PlayerParamAttackData comboFinishF;
        [FieldOffset(9904)]  public PlayerParamAttackData comboFinishB;
        [FieldOffset(10256)] public PlayerParamAttackData comboFinishL;
        [FieldOffset(10608)] public PlayerParamAttackData comboFinishR;
        [FieldOffset(10960)] public PlayerParamAttackData acceleComboFinish;
        [FieldOffset(11312)] public PlayerParamAttackData acceleComboFinishF;
        [FieldOffset(11664)] public PlayerParamAttackData acceleComboFinishB;
        [FieldOffset(12016)] public PlayerParamAttackData acceleComboFinishL;
        [FieldOffset(12368)] public PlayerParamAttackData acceleComboFinishR;
        [FieldOffset(12720)] public PlayerParamAttackData smash;
        [FieldOffset(13072)] public PlayerParamAttackData smashLast;
        [FieldOffset(13424)] public PlayerParamAttackData slingShot;
        [FieldOffset(13776)] public PlayerParamAttackData knucklesPunch1;
        [FieldOffset(14128)] public PlayerParamAttackData knucklesPunch2;
        [FieldOffset(14480)] public PlayerParamAttackData knucklesUppercut;
        [FieldOffset(14832)] public PlayerParamAttackData amyTarotAttack;
        [FieldOffset(15184)] public PlayerParamAttackData amyTarotRolling;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamWaterAct
    {
        [FieldOffset(0)]  public float resistRate;
        [FieldOffset(4)]  public float breatheBrake;
        [FieldOffset(8)]  public float breatheTime;
        [FieldOffset(12)] public float breatheGravity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct PlayerParamBaseJump
    {
        [FieldOffset(0)]  public float baseSpeed;
        [FieldOffset(4)]  public float upSpeed;
        [FieldOffset(8)]  public float upSpeedAir;
        [FieldOffset(12)] public float edgeSpeed;
        [FieldOffset(16)] public float airActionTime;
        [FieldOffset(20)] public float wallMoveTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct PlayerParamBallMove
    {
        [FieldOffset(0)]  public float maxSpeed;
        [FieldOffset(4)]  public float slidePower;
        [FieldOffset(8)]  public float brakeForce;
        [FieldOffset(12)] public float slidePowerSlalom;
        [FieldOffset(16)] public float brakeForceSlalom;
        [FieldOffset(20)] public float releaseSpeed;
        [FieldOffset(24)] public bool useInput;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamLocusData
    {
        [FieldOffset(0)]  public float width;
        [FieldOffset(4)]  public float distance;
        [FieldOffset(8)]  public float u0;
        [FieldOffset(12)] public float u1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct PlayerParamLocus
    {
        [FieldOffset(0)] public PlayerParamLocusData data__arr0;
        [FieldOffset(16)] public PlayerParamLocusData data__arr1;
        [FieldOffset(32)] public PlayerParamLocusData data__arr2;
        [FieldOffset(48)] public PlayerParamLocusData data__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamAuraTrain
    {
        [FieldOffset(0)]  public float effectSpanTime;
        [FieldOffset(4)]  public float effectLifeTime;
        [FieldOffset(8)]  public float effectOffsetDistance;
        [FieldOffset(12)] public float effectOverlapDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PlayerParamLevel
    {
        [FieldOffset(0)] public byte ringsLevel;
        [FieldOffset(1)] public byte speedLevel;
        [FieldOffset(2)] public byte offensiveLevel;
        [FieldOffset(3)] public byte defensiveLevel;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PlayerParamBarrierWall
    {
        [FieldOffset(0)] public float coolTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct PlayerParamDamageRateLevel
    {
        [FieldOffset(0)] public float rates__arr0;
        [FieldOffset(4)] public float rates__arr1;
        [FieldOffset(8)] public float rates__arr2;
        [FieldOffset(12)] public float rates__arr3;
        [FieldOffset(16)] public float rates__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct PlayerParamDamageRate
    {
        [FieldOffset(0)] public PlayerParamDamageRateLevel diffculties__arr0;
        [FieldOffset(20)] public PlayerParamDamageRateLevel diffculties__arr1;
        [FieldOffset(40)] public PlayerParamDamageRateLevel diffculties__arr2;
        [FieldOffset(60)] public PlayerParamDamageRateLevel diffculties__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 15776)]
    public struct CommonPackage
    {
        [FieldOffset(0)]     public PlayerParamAttack attack;
        [FieldOffset(15536)] public PlayerParamWaterAct wateract;
        [FieldOffset(15552)] public PlayerParamBaseJump basejump;
        [FieldOffset(15576)] public PlayerParamBallMove ballmove;
        [FieldOffset(15604)] public PlayerParamLocus locus;
        [FieldOffset(15668)] public PlayerParamAuraTrain auratrain;
        [FieldOffset(15684)] public PlayerParamLevel level;
        [FieldOffset(15688)] public PlayerParamBarrierWall barrierWall;
        [FieldOffset(15692)] public PlayerParamDamageRate damageRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PlayerParamComboCommon
    {
        [FieldOffset(0)] public float longPressTime;
    }

    public enum ComboMoveType : byte
    {
        Homing = 0,
        Step = 1,
        None = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct PlayerParamComboMove
    {
        [FieldOffset(0)]  public ComboMoveType moveType;
        [FieldOffset(4)]  public float moveInitialSpeed;
        [FieldOffset(8)]  public float moveMaxSpeed;
        [FieldOffset(12)] public float moveAccele;
        [FieldOffset(16)] public float timeout;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct PlayerParamComboMoveCorrection
    {
        [FieldOffset(0)] public float moveSpeed;
        [FieldOffset(4)] public float rotateSpeed;
    }

    public enum Action : sbyte
    {
        Root = 0,
        HomingAttack = 1,
        AerialHomingAttack = 2,
        Pursuit = 3,
        Stomping = 4,
        LoopKick = 5,
        Crasher = 6,
        SpinSlash = 7,
        SonicBoom = 8,
        CrossSlash = 9,
        HomingShot = 10,
        ChargeAttack = 11,
        QuickCyloop = 12,
        AerialQuickCyloop = 13,
        AcceleCombo1 = 14,
        AcceleCombo2 = 15,
        AcceleCombo3 = 16,
        AcceleCombo4 = 17,
        AerialAcceleCombo1 = 18,
        AerialAcceleCombo2 = 19,
        AerialAcceleCombo3 = 20,
        AerialAcceleCombo4 = 21,
        ComboFinish = 22,
        SpinJump = 23,
        Smash = 24,
        Behind = 25,
        Guarded = 26,
        Avoid = 27,
        AirBoost = 28,
        AfterAirBoost = 29,
        KnucklesPunch1 = 30,
        KnucklesPunch2 = 31,
        KnucklesUppercut = 32,
        KnucklesCyKnuckle = 33,
        KnucklesHeatKnuckle = 34,
        AmyTarotAttack = 35,
        AmyTarotRolling = 36,
        AmyCyHammer = 37,
        ActionNum = 38
    }

    [StructLayout(LayoutKind.Explicit, Size = 18)]
    public struct PlayerParamComboTransit
    {
        [FieldOffset(0)]  public Action transitExistTarget__arr0;
        [FieldOffset(1)] public Action transitExistTarget__arr1;
        [FieldOffset(2)] public Action transitExistTarget__arr2;
        [FieldOffset(3)] public Action transitExistTarget__arr3;
        [FieldOffset(4)] public Action transitExistTarget__arr4;
        [FieldOffset(5)] public Action transitExistTarget__arr5;
        [FieldOffset(6)]  public Action transitInAir__arr0;
        [FieldOffset(7)] public Action transitInAir__arr1;
        [FieldOffset(8)] public Action transitInAir__arr2;
        [FieldOffset(9)] public Action transitInAir__arr3;
        [FieldOffset(10)] public Action transitInAir__arr4;
        [FieldOffset(11)] public Action transitInAir__arr5;
        [FieldOffset(12)] public Action transitNotExistTarget__arr0;
        [FieldOffset(13)] public Action transitNotExistTarget__arr1;
        [FieldOffset(14)] public Action transitNotExistTarget__arr2;
        [FieldOffset(15)] public Action transitNotExistTarget__arr3;
        [FieldOffset(16)] public Action transitNotExistTarget__arr4;
        [FieldOffset(17)] public Action transitNotExistTarget__arr5;
    }

    [StructLayout(LayoutKind.Explicit, Size = 630)]
    public struct PlayerParamComboTransitTable
    {
        [FieldOffset(0)]   public PlayerParamComboTransit root;
        [FieldOffset(18)]  public PlayerParamComboTransit homingAttack;
        [FieldOffset(36)]  public PlayerParamComboTransit aerialHoming;
        [FieldOffset(54)]  public PlayerParamComboTransit pursuit;
        [FieldOffset(72)]  public PlayerParamComboTransit stomping;
        [FieldOffset(90)]  public PlayerParamComboTransit loopKick;
        [FieldOffset(108)] public PlayerParamComboTransit crasher;
        [FieldOffset(126)] public PlayerParamComboTransit spinSlash;
        [FieldOffset(144)] public PlayerParamComboTransit sonicBoom;
        [FieldOffset(162)] public PlayerParamComboTransit crossSlash;
        [FieldOffset(180)] public PlayerParamComboTransit homingShot;
        [FieldOffset(198)] public PlayerParamComboTransit chargeAttack;
        [FieldOffset(216)] public PlayerParamComboTransit quickCyloop;
        [FieldOffset(234)] public PlayerParamComboTransit aerialQuickCyloop;
        [FieldOffset(252)] public PlayerParamComboTransit acceleCombo1;
        [FieldOffset(270)] public PlayerParamComboTransit acceleCombo2;
        [FieldOffset(288)] public PlayerParamComboTransit acceleCombo3;
        [FieldOffset(306)] public PlayerParamComboTransit acceleCombo4;
        [FieldOffset(324)] public PlayerParamComboTransit aerialAcceleCombo1;
        [FieldOffset(342)] public PlayerParamComboTransit aerialAcceleCombo2;
        [FieldOffset(360)] public PlayerParamComboTransit aerialAcceleCombo3;
        [FieldOffset(378)] public PlayerParamComboTransit aerialAcceleCombo4;
        [FieldOffset(396)] public PlayerParamComboTransit behind;
        [FieldOffset(414)] public PlayerParamComboTransit guarded;
        [FieldOffset(432)] public PlayerParamComboTransit avoid;
        [FieldOffset(450)] public PlayerParamComboTransit airBoost;
        [FieldOffset(468)] public PlayerParamComboTransit afterAirBoost;
        [FieldOffset(486)] public PlayerParamComboTransit knucklesPunch1;
        [FieldOffset(504)] public PlayerParamComboTransit knucklesPunch2;
        [FieldOffset(522)] public PlayerParamComboTransit knucklesUppercut;
        [FieldOffset(540)] public PlayerParamComboTransit knucklesCyKnuckle;
        [FieldOffset(558)] public PlayerParamComboTransit knucklesHeatKnuckle;
        [FieldOffset(576)] public PlayerParamComboTransit amyTarotAttack;
        [FieldOffset(594)] public PlayerParamComboTransit amyTarotRolling;
        [FieldOffset(612)] public PlayerParamComboTransit amyCyHammer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 684)]
    public struct PlayerParamCombo
    {
        [FieldOffset(0)]  public PlayerParamComboCommon common;
        [FieldOffset(4)]  public PlayerParamComboMove comboMoveSonic;
        [FieldOffset(24)] public PlayerParamComboMove comboMoveSupersonic;
        [FieldOffset(44)] public PlayerParamComboMoveCorrection comboMoveCorrection;
        [FieldOffset(52)] public PlayerParamComboTransitTable comboTable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16464)]
    public struct CommonPackageAmy
    {
        [FieldOffset(0)]     public CommonPackage commonPackage;
        [FieldOffset(15776)] public PlayerParamCombo combo;
    }

    public enum SupportedPlane : sbyte
    {
        Flat = 0,
        Slope = 1,
        Wall = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct PlayerParamCommon
    {
        [FieldOffset(0)]  public float movableMaxSlope;
        [FieldOffset(4)]  public float activeLandingSlope;
        [FieldOffset(8)]  public float activeLandingSlopeInBoost;
        [FieldOffset(12)] public float landingMaxSlope;
        [FieldOffset(16)] public float slidingMaxSlope;
        [FieldOffset(20)] public float wallAngleMaxSlope;
        [FieldOffset(24)] public SupportedPlane onStand;
        [FieldOffset(25)] public SupportedPlane onRunInAir;
        [FieldOffset(26)] public SupportedPlane onRun;
        [FieldOffset(27)] public bool moveHolding;
        [FieldOffset(28)] public bool wallSlideSlowInBoost;
        [FieldOffset(29)] public bool attrWallOnGround;
        [FieldOffset(32)] public float priorityInputTime;
        [FieldOffset(36)] public int capacityRings;
        [FieldOffset(40)] public int capacityRingsLvMax;
        [FieldOffset(44)] public float collectRingRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamSpeedData
    {
        [FieldOffset(0)]  public float initial;
        [FieldOffset(4)]  public float min;
        [FieldOffset(8)]  public float max;
        [FieldOffset(12)] public float minTurn;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct PlayerParamSpeedAcceleData
    {
        [FieldOffset(0)]  public float force;
        [FieldOffset(4)]  public float force2;
        [FieldOffset(8)]  public float damperRange;
        [FieldOffset(12)] public float jerkMin;
        [FieldOffset(16)] public float jerkMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamSpeedAcceleData2
    {
        [FieldOffset(0)]  public float force;
        [FieldOffset(4)]  public float damperRange;
        [FieldOffset(8)]  public float jerkMin;
        [FieldOffset(12)] public float jerkMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 224)]
    public struct PlayerParamSpeed
    {
        [FieldOffset(0)]   public PlayerParamSpeedData normal;
        [FieldOffset(16)]  public PlayerParamSpeedData normal2;
        [FieldOffset(32)]  public PlayerParamSpeedData boost;
        [FieldOffset(48)]  public PlayerParamSpeedData boost2;
        [FieldOffset(64)]  public PlayerParamSpeedData boostLvMax;
        [FieldOffset(80)]  public PlayerParamSpeedData boostLvMax2;
        [FieldOffset(96)]  public float maxSpeedOver;
        [FieldOffset(100)] public float opitonMaxSpeedLimitMin;
        [FieldOffset(104)] public float opitonMaxSpeedLimitMax;
        [FieldOffset(108)] public float thresholdStopSpeed;
        [FieldOffset(112)] public float maxFallSpeed;
        [FieldOffset(116)] public PlayerParamSpeedAcceleData accele;
        [FieldOffset(136)] public PlayerParamSpeedAcceleData decele;
        [FieldOffset(156)] public PlayerParamSpeedAcceleData2 deceleNeutralMin;
        [FieldOffset(172)] public PlayerParamSpeedAcceleData2 deceleNeutralMax;
        [FieldOffset(188)] public float acceleAuto;
        [FieldOffset(192)] public float deceleAuto;
        [FieldOffset(196)] public float turnDeceleAngleMin;
        [FieldOffset(200)] public float turnDeceleAngleMax;
        [FieldOffset(204)] public float maxGravityAccele;
        [FieldOffset(208)] public float maxGravityDecele;
        [FieldOffset(212)] public float deceleSquat;
        [FieldOffset(216)] public float acceleSensitive;
        [FieldOffset(220)] public float boostAnimSpeedInWater;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct PlayerParamRotation
    {
        [FieldOffset(0)]  public float baseRotateForce;
        [FieldOffset(4)]  public float baseRotateForce2;
        [FieldOffset(8)]  public float baseRotateForceSpeed;
        [FieldOffset(12)] public float minRotateForce;
        [FieldOffset(16)] public float maxRotateForce;
        [FieldOffset(20)] public bool angleRotateForceDecayEnabled;
        [FieldOffset(24)] public float frontRotateRatio;
        [FieldOffset(28)] public float rotationForceDecaySpeed;
        [FieldOffset(32)] public float rotationForceDecayRate;
        [FieldOffset(36)] public float rotationForceDecayMax;
        [FieldOffset(40)] public float autorunRotateForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct PlayerParamRunning
    {
        [FieldOffset(0)]  public float walkSpeed;
        [FieldOffset(4)]  public float sneakingSpeed;
        [FieldOffset(8)]  public float animSpeedSneak;
        [FieldOffset(12)] public float animSpeedWalk;
        [FieldOffset(16)] public float animSpeedRun;
        [FieldOffset(20)] public float animSpeedBoost;
        [FieldOffset(24)] public float animLRBlendSampleTime;
        [FieldOffset(28)] public float animLRBlendAngleMin;
        [FieldOffset(32)] public float animLRBlendAngleMax;
        [FieldOffset(36)] public float animLRBlendSpeed;
        [FieldOffset(40)] public float animLRBlendSpeedToCenter;
        [FieldOffset(44)] public float minChangeWalkTime;
        [FieldOffset(48)] public float fallAnimationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamBalanceData
    {
        [FieldOffset(0)]  public float rotateSpeedMinFB;
        [FieldOffset(4)]  public float rotateSpeedMaxFB;
        [FieldOffset(8)]  public float rotateSpeedMinLR;
        [FieldOffset(12)] public float rotateSpeedMaxLR;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamBalance
    {
        [FieldOffset(0)]  public PlayerParamBalanceData standard;
        [FieldOffset(16)] public PlayerParamBalanceData loop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct PlayerParamBrake
    {
        [FieldOffset(0)]  public float initialSpeedRatio;
        [FieldOffset(4)]  public float maxSpeed;
        [FieldOffset(8)]  public float forceLand;
        [FieldOffset(12)] public float forceAir;
        [FieldOffset(16)] public float endSpeed;
        [FieldOffset(20)] public float stopTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamTurn
    {
        [FieldOffset(0)]  public float thresholdSpeed;
        [FieldOffset(4)]  public float thresholdAngle;
        [FieldOffset(8)]  public float turnAfterSpeed;
        [FieldOffset(12)] public bool stopEdge;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct PlayerParamJump
    {
        [FieldOffset(0)]  public float preActionTime;
        [FieldOffset(4)]  public float longPressTime;
        [FieldOffset(8)]  public float addForceTime;
        [FieldOffset(12)] public float force;
        [FieldOffset(16)] public float addForce;
        [FieldOffset(20)] public float forceMin;
        [FieldOffset(24)] public float gravitySize;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct PlayerParamJumpSpeed
    {
        [FieldOffset(0)]  public float acceleForce;
        [FieldOffset(4)]  public float deceleForce;
        [FieldOffset(8)]  public float deceleNeutralForce;
        [FieldOffset(12)] public float deceleBackForce;
        [FieldOffset(16)] public float limitMin;
        [FieldOffset(20)] public float limitUpSpeed;
        [FieldOffset(24)] public float rotationForce;
        [FieldOffset(28)] public float rotationForceDecaySpeed;
        [FieldOffset(32)] public float rotationForceDecayRate;
        [FieldOffset(36)] public float rotationForceDecayMax;
        [FieldOffset(40)] public float baseAirDragScaleMin;
        [FieldOffset(44)] public float baseAirDragScaleMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct PlayerParamDoubleJump
    {
        [FieldOffset(0)] public float initialSpeed;
        [FieldOffset(4)] public float bounceSpeed;
        [FieldOffset(8)] public float limitSpeedMin;
    }

    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public struct PlayerParamFall
    {
        [FieldOffset(0)]  public float thresholdVertSpeed;
        [FieldOffset(4)]  public float tolerateJumpTime;
        [FieldOffset(8)]  public float fallEndDelayTime;
        [FieldOffset(12)] public float fallEndFadeTime;
        [FieldOffset(16)] public float acceleForce;
        [FieldOffset(20)] public float deceleForce;
        [FieldOffset(24)] public float overSpeedDeceleForce;
        [FieldOffset(28)] public float rotationForce;
        [FieldOffset(32)] public float rotationForceDecaySpeed;
        [FieldOffset(36)] public float rotationForceDecayRate;
        [FieldOffset(40)] public float rotationForceDecayMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PlayerParamDamageCommon
    {
        [FieldOffset(0)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct PlayerParamDamageNormal
    {
        [FieldOffset(0)]  public float initialHorzSpeed;
        [FieldOffset(4)]  public float initialVertSpeed;
        [FieldOffset(8)]  public float deceleForce;
        [FieldOffset(12)] public float transitFallTime;
        [FieldOffset(16)] public float gravityScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PlayerParamDamageTurnBack
    {
        [FieldOffset(0)] public float fixedTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct PlayerParamDamageBlowOff
    {
        [FieldOffset(0)]  public float initialHorzSpeed;
        [FieldOffset(4)]  public float initialVertSpeed;
        [FieldOffset(8)]  public float deceleForceInAir;
        [FieldOffset(12)] public float deceleForceOnGround;
        [FieldOffset(16)] public float gravityScale;
        [FieldOffset(20)] public float downTime;
        [FieldOffset(24)] public float transitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamDamageGuarded
    {
        [FieldOffset(0)]  public float vertSpeed;
        [FieldOffset(4)]  public float horzSpeed;
        [FieldOffset(8)]  public float deceleForce;
        [FieldOffset(12)] public float transitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamDamageRunning
    {
        [FieldOffset(0)]  public float actionTime;
        [FieldOffset(4)]  public float minSpeed;
        [FieldOffset(8)]  public float lossSpeed;
        [FieldOffset(12)] public float lossTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PlayerParamDamageQuake
    {
        [FieldOffset(0)] public float actionTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamDamageLava
    {
        [FieldOffset(0)]  public Vector3 jumpVelocity;
        [FieldOffset(16)] public float gravitySize;
        [FieldOffset(20)] public float invincibleTime;
        [FieldOffset(24)] public float noActionTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct PlayerParamDamage
    {
        [FieldOffset(0)]   public PlayerParamDamageCommon common;
        [FieldOffset(4)]   public PlayerParamDamageNormal normal;
        [FieldOffset(24)]  public PlayerParamDamageTurnBack turnBack;
        [FieldOffset(28)]  public PlayerParamDamageBlowOff blowOff;
        [FieldOffset(56)]  public PlayerParamDamageGuarded guarded;
        [FieldOffset(72)]  public PlayerParamDamageGuarded guardedSS;
        [FieldOffset(88)]  public PlayerParamDamageRunning running;
        [FieldOffset(104)] public PlayerParamDamageQuake quake;
        [FieldOffset(112)] public PlayerParamDamageLava lava;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct PlayerParamDeadNormal
    {
        [FieldOffset(0)] public float invincibleTime;
        [FieldOffset(4)] public float initialHorzSpeed;
        [FieldOffset(8)] public float initialVertSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct PlayerParamDead
    {
        [FieldOffset(0)] public PlayerParamDeadNormal normal;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct PlayerParamSliding
    {
        [FieldOffset(0)]  public float minSpeed;
        [FieldOffset(4)]  public float endSpeed;
        [FieldOffset(8)]  public float deceleJerk;
        [FieldOffset(12)] public float deceleJerkContinue;
        [FieldOffset(16)] public float deceleForceMax;
        [FieldOffset(20)] public float baseRotateForce;
        [FieldOffset(24)] public float baseRotateForceSpeed;
        [FieldOffset(28)] public float maxRotateForce;
        [FieldOffset(32)] public float frontRotateRatio;
        [FieldOffset(36)] public float rotationForceAutoRun;
        [FieldOffset(40)] public float movableMaxSlope;
        [FieldOffset(44)] public float gravitySize;
        [FieldOffset(48)] public float minContinueTime;
        [FieldOffset(52)] public float maxAutoRunTime;
        [FieldOffset(56)] public float endSpeedAutoRun;
        [FieldOffset(60)] public float loopKickTransitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamStomping
    {
        [FieldOffset(0)]  public float initialSpeed;
        [FieldOffset(4)]  public float initialAccele;
        [FieldOffset(8)]  public float maxAccele;
        [FieldOffset(12)] public float jerk;
        [FieldOffset(16)] public float maxFallSpeed;
        [FieldOffset(20)] public float angle;
        [FieldOffset(24)] public float landingCancelTime;
        [FieldOffset(28)] public float boundStompingCollisionScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct PlayerParamGrind
    {
        [FieldOffset(0)]  public float maxSpeed;
        [FieldOffset(4)]  public float maxBoostSpeed;
        [FieldOffset(8)]  public float acceleForce;
        [FieldOffset(12)] public float deceleForce;
        [FieldOffset(16)] public float limitSpeedMin;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct PlayerParamFallSlope
    {
        [FieldOffset(0)]  public float initialSpeed;
        [FieldOffset(4)]  public float maxSpeed;
        [FieldOffset(8)]  public float brakeAngle;
        [FieldOffset(12)] public float highBrakeAngle;
        [FieldOffset(16)] public float brakeForce;
        [FieldOffset(20)] public float brakeForceHigh;
        [FieldOffset(24)] public float gravitySize;
        [FieldOffset(28)] public float gravitySizeAir;
        [FieldOffset(32)] public float endSpeedFront;
        [FieldOffset(36)] public float endSpeedBack;
        [FieldOffset(40)] public float reverseFallTime;
        [FieldOffset(44)] public float fallToSlipTime;
        [FieldOffset(48)] public float slipIdlingTime;
        [FieldOffset(52)] public float minSlipTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct PlayerParamFallFlip
    {
        [FieldOffset(0)] public float thresholdSpeed;
        [FieldOffset(4)] public float maxSpeed;
        [FieldOffset(8)] public float flipAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public struct PlayerParamTumble
    {
        [FieldOffset(0)]   public bool enabled;
        [FieldOffset(4)]   public float sideSpinAngle;
        [FieldOffset(8)]   public float initialVertSpeed;
        [FieldOffset(12)]  public float gravitySize;
        [FieldOffset(16)]  public float gravitySize2;
        [FieldOffset(20)]  public float deceleForceInAir;
        [FieldOffset(24)]  public float minSpeedInAir;
        [FieldOffset(28)]  public float rotateEaseTimeLeftRight;
        [FieldOffset(32)]  public float rotateEaseTimeFrontBack;
        [FieldOffset(36)]  public float rotateSpeedMinLeftRight;
        [FieldOffset(40)]  public float rotateSpeedMaxLeftRight;
        [FieldOffset(44)]  public float rotateSpeedMinFrontBack;
        [FieldOffset(48)]  public float rotateSpeedMaxFrontBack;
        [FieldOffset(52)]  public float angleLeftRightStagger;
        [FieldOffset(56)]  public float angleLeftRightRoll;
        [FieldOffset(60)]  public float angleFrontBackRoll;
        [FieldOffset(64)]  public float angleBigRoll;
        [FieldOffset(68)]  public float inRunTime;
        [FieldOffset(72)]  public float inAirTime;
        [FieldOffset(76)]  public float rollSpeedFront;
        [FieldOffset(80)]  public float bigRollVelocityRatio;
        [FieldOffset(84)]  public float dropDashHoldTime;
        [FieldOffset(88)]  public float airBrakeVertSpeed;
        [FieldOffset(92)]  public float airBrakeForce;
        [FieldOffset(96)]  public float airTrickHeight;
        [FieldOffset(100)] public float airTrickTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamSpinAttack
    {
        [FieldOffset(0)]  public float jumpForce;
        [FieldOffset(4)]  public float jumpAddForce;
        [FieldOffset(8)]  public float addTime;
        [FieldOffset(12)] public float acceleForce;
        [FieldOffset(16)] public float deceleForce;
        [FieldOffset(20)] public float brakeForce;
        [FieldOffset(24)] public float limitSpeedMin;
        [FieldOffset(28)] public float limitSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct PlayerParamHomingAttackData
    {
        [FieldOffset(0)] public float speed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamHomingBounceData
    {
        [FieldOffset(0)]  public float bounceVertSpeed;
        [FieldOffset(4)]  public float bounceHorzSpeed;
        [FieldOffset(8)]  public float bounceAcceleForce;
        [FieldOffset(12)] public float bounceDeceleForce;
        [FieldOffset(16)] public float bounceAngleWidth;
        [FieldOffset(20)] public float bounceTime;
        [FieldOffset(24)] public float attackDownTime;
        [FieldOffset(28)] public float attackDownTimeForStomp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public struct PlayerParamHomingAttack
    {
        [FieldOffset(0)]   public PlayerParamHomingAttackData sonic;
        [FieldOffset(4)]   public PlayerParamHomingAttackData supersonic;
        [FieldOffset(8)]   public PlayerParamHomingBounceData sonicBounce;
        [FieldOffset(40)]  public PlayerParamHomingBounceData sonicBounceWeak;
        [FieldOffset(72)]  public PlayerParamHomingBounceData sonicBounceStorm;
        [FieldOffset(104)] public PlayerParamHomingBounceData sonicBounceStormSwirl;
        [FieldOffset(136)] public PlayerParamHomingBounceData supersonicBounce;
        [FieldOffset(168)] public float cameraEaseInTime;
        [FieldOffset(172)] public float cameraEaseOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamHitEnemy
    {
        [FieldOffset(0)]  public float bounceVertSpeed;
        [FieldOffset(4)]  public float bounceHorzSpeed;
        [FieldOffset(8)]  public float attackDownTime;
        [FieldOffset(12)] public float enableHomingTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct SpeedParam
    {
        [FieldOffset(0)]  public float maxVertSpeed;
        [FieldOffset(4)]  public float acceleVertForce;
        [FieldOffset(8)]  public float maxHorzSpeed;
        [FieldOffset(12)] public float acceleHorzForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public struct PlayerParamDiving
    {
        [FieldOffset(0)]  public SpeedParam normal;
        [FieldOffset(16)] public SpeedParam fast;
        [FieldOffset(32)] public SpeedParam damaged;
        [FieldOffset(48)] public SpeedParam ringdash;
        [FieldOffset(64)] public float startHeight;
        [FieldOffset(68)] public float startSpeed;
        [FieldOffset(72)] public float deceleVertForce;
        [FieldOffset(76)] public float deceleHorzForce;
        [FieldOffset(80)] public float deceleNeutralForce;
        [FieldOffset(84)] public float damageTime;
        [FieldOffset(88)] public float ringdashTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct PlayerParamFan
    {
        [FieldOffset(0)]  public float damperV;
        [FieldOffset(4)]  public float damperH;
        [FieldOffset(8)]  public float accelRate;
        [FieldOffset(12)] public float moveForceFV;
        [FieldOffset(16)] public float moveForceSV;
        [FieldOffset(20)] public float jumpCheckSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct PlayerParamBackflip
    {
        [FieldOffset(0)]  public float jumpSpeed;
        [FieldOffset(4)]  public float backSpeed;
        [FieldOffset(8)]  public float downAccel;
        [FieldOffset(12)] public float damperV;
        [FieldOffset(16)] public float damperH;
        [FieldOffset(20)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamSlowMove
    {
        [FieldOffset(0)]  public float startSpeed;
        [FieldOffset(4)]  public float maxSpeed;
        [FieldOffset(8)]  public float accel;
        [FieldOffset(12)] public float brake;
        [FieldOffset(16)] public float damageSpeed;
        [FieldOffset(20)] public float damageBrake;
        [FieldOffset(24)] public float steeringSpeed;
        [FieldOffset(28)] public float endSteeringSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamSpin
    {
        [FieldOffset(0)]  public float startSlopeAngle;
        [FieldOffset(4)]  public float endSlopeAngle;
        [FieldOffset(8)]  public float startSpeed;
        [FieldOffset(12)] public float endSpeed;
        [FieldOffset(16)] public float stickAngle;
        [FieldOffset(20)] public float brake;
        [FieldOffset(24)] public float forceBrake;
        [FieldOffset(28)] public float maxSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 136)]
    public struct PlayerParamWallMove
    {
        [FieldOffset(0)]   public float maxSpeed;
        [FieldOffset(4)]   public float walkSpeed;
        [FieldOffset(8)]   public float walkSpeedMax;
        [FieldOffset(12)]  public float runSpeed;
        [FieldOffset(16)]  public float runSpeedMax;
        [FieldOffset(20)]  public float walkSpeedOnMesh;
        [FieldOffset(24)]  public float walkSpeedOnMeshMax;
        [FieldOffset(28)]  public float runSpeedOnMesh;
        [FieldOffset(32)]  public float runSpeedOnMeshMax;
        [FieldOffset(36)]  public float minAccessSpeed;
        [FieldOffset(40)]  public float stickSpeed;
        [FieldOffset(44)]  public float gravity;
        [FieldOffset(48)]  public float accel;
        [FieldOffset(52)]  public float brake;
        [FieldOffset(56)]  public float stopBrake;
        [FieldOffset(60)]  public float fallSpeed;
        [FieldOffset(64)]  public float steeringSpeed1;
        [FieldOffset(68)]  public float steeringSpeed2;
        [FieldOffset(72)]  public float startSteeringSpeed;
        [FieldOffset(76)]  public float endSteeringSpeed;
        [FieldOffset(80)]  public float startTime;
        [FieldOffset(84)]  public float useEnergySpeedBase;
        [FieldOffset(88)]  public float useEnergySpeedBaseOnMesh;
        [FieldOffset(92)]  public float useEnergySpeedVal;
        [FieldOffset(96)]  public float useEnergySpeedValOnMesh;
        [FieldOffset(100)] public float useEnergyAngle;
        [FieldOffset(104)] public float useEnergyAngleOnMesh;
        [FieldOffset(108)] public float brakeStartEnergy;
        [FieldOffset(112)] public float brakeStartEnergyOnMesh;
        [FieldOffset(116)] public float homingSearchDistanceNear;
        [FieldOffset(120)] public float homingSearchDistanceFar;
        [FieldOffset(124)] public float wallBumpHeightUpper;
        [FieldOffset(128)] public float wallBumpHeightUnder;
        [FieldOffset(132)] public float recoveryCheckTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct PlayerParamWallJump
    {
        [FieldOffset(0)]  public float gravitySize;
        [FieldOffset(4)]  public float minTime;
        [FieldOffset(8)]  public float maxTime;
        [FieldOffset(12)] public float stopTime;
        [FieldOffset(16)] public float maxDownSpeed;
        [FieldOffset(20)] public float fallGroundDistance;
        [FieldOffset(24)] public float frontForce;
        [FieldOffset(28)] public float upForce;
        [FieldOffset(32)] public float impulseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public struct PlayerParamClimbing
    {
        [FieldOffset(0)]  public float stepSpeedFront;
        [FieldOffset(4)]  public float stepSpeedFrontDash;
        [FieldOffset(8)]  public float stepSpeedSide;
        [FieldOffset(12)] public float stepSpeedSideDash;
        [FieldOffset(16)] public float stepSpeedBack;
        [FieldOffset(20)] public float stepDashRate;
        [FieldOffset(24)] public float maxAnimSpeed;
        [FieldOffset(28)] public float exhaustAngle;
        [FieldOffset(32)] public float exhaustAngleOnMesh;
        [FieldOffset(36)] public float exhaustBase;
        [FieldOffset(40)] public float exhaustBaseOnMesh;
        [FieldOffset(44)] public float exhaustRate;
        [FieldOffset(48)] public float exhaustRateOnMesh;
        [FieldOffset(52)] public float useGrabGaugeSpeed;
        [FieldOffset(56)] public float useGrabGaugeSpeedOnMesh;
        [FieldOffset(60)] public float useGrabGaugeTurbo;
        [FieldOffset(64)] public float useGrabGaugeTurboOnMesh;
        [FieldOffset(68)] public float homingSearchDistanceNear;
        [FieldOffset(72)] public float homingSearchDistanceFar;
        [FieldOffset(76)] public float resetAngle;
        [FieldOffset(80)] public float recoveryCheckTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct PlayerParamSlideDown
    {
        [FieldOffset(0)]  public float time;
        [FieldOffset(4)]  public float speed;
        [FieldOffset(8)]  public float speedOnMesh;
        [FieldOffset(12)] public float accel;
        [FieldOffset(16)] public float brake;
        [FieldOffset(20)] public float brakeOnMesh;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct PlayerParamBoost
    {
        [FieldOffset(0)]  public float consumptionRate;
        [FieldOffset(4)]  public float consumptionRateSS;
        [FieldOffset(8)]  public float recoveryRate;
        [FieldOffset(12)] public float recoveryRateSS;
        [FieldOffset(16)] public float reigniteRatio;
        [FieldOffset(20)] public float recoveryByRing;
        [FieldOffset(24)] public float recoveryByAttack;
        [FieldOffset(28)] public float blurPowers__arr0;
        [FieldOffset(32)] public float blurPowers__arr1;
        [FieldOffset(36)] public float blurPowers__arr2;
        [FieldOffset(40)] public float blurEaseInTime;
        [FieldOffset(44)] public float blurEaseOutTime;
        [FieldOffset(48)] public float endSpeed;
        [FieldOffset(52)] public float powerBoostCoolTime;
        [FieldOffset(56)] public float infinityBoostTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct PlayerParamAirBoost
    {
        [FieldOffset(0)]  public float startHSpeed;
        [FieldOffset(4)]  public float startHSpeedMax;
        [FieldOffset(8)]  public float startVSpeed;
        [FieldOffset(12)] public float minHSpeed;
        [FieldOffset(16)] public float minHSpeedMax;
        [FieldOffset(20)] public float brakeTime;
        [FieldOffset(24)] public float minKeepTime;
        [FieldOffset(28)] public float maxKeepTime;
        [FieldOffset(32)] public float maxTime;
        [FieldOffset(36)] public float gravityRate;
        [FieldOffset(40)] public float steeringSpeed;
        [FieldOffset(44)] public float additionalTransitTime;
        [FieldOffset(48)] public float supersonicTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamAutorun
    {
        [FieldOffset(0)]  public float initialSideSpeed;
        [FieldOffset(4)]  public float acceleSideForce;
        [FieldOffset(8)]  public float deceleSideForce;
        [FieldOffset(12)] public float maxSideSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamSideStep
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float brakeForce;
        [FieldOffset(8)]  public float motionSpeedRatio;
        [FieldOffset(12)] public float stepSpeed;
        [FieldOffset(16)] public float maxStepDistance;
        [FieldOffset(20)] public float minStepDistance;
        [FieldOffset(24)] public float maxStepSpeed;
        [FieldOffset(28)] public float minStepSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayerParamSideStep2
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float brakeForce;
        [FieldOffset(8)]  public float motionSpeedRatio;
        [FieldOffset(12)] public float stepSpeed;
        [FieldOffset(16)] public float maxStepDistance;
        [FieldOffset(20)] public float minStepDistance;
        [FieldOffset(24)] public float maxStepSpeed;
        [FieldOffset(28)] public float minStepSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct PlayerParamQuickStep
    {
        [FieldOffset(0)]  public float needSpeed;
        [FieldOffset(4)]  public float acceleForce;
        [FieldOffset(8)]  public float acceleSideForce;
        [FieldOffset(12)] public float stepInitialSpeed;
        [FieldOffset(16)] public float avoidForce;
        [FieldOffset(20)] public float justBoostForce;
        [FieldOffset(24)] public float justBoostMax;
        [FieldOffset(28)] public float justBoostTime;
        [FieldOffset(32)] public float justBoostBrake;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct PlayerParamParry
    {
        [FieldOffset(0)]  public float minRecieveTime;
        [FieldOffset(4)]  public float maxRecieveTime;
        [FieldOffset(8)]  public float frozenTime;
        [FieldOffset(12)] public float justEffectEasein;
        [FieldOffset(16)] public float justEffectEaseout;
        [FieldOffset(20)] public float justEffectTime;
        [FieldOffset(24)] public float justEffectEasein2;
        [FieldOffset(28)] public float justEffectEaseout2;
        [FieldOffset(32)] public float justEffectTime2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PlayerParamAvoidData
    {
        [FieldOffset(0)]  public float speed;
        [FieldOffset(4)]  public float damper;
        [FieldOffset(8)]  public float parryTime;
        [FieldOffset(12)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 148)]
    public struct PlayerParamAvoid
    {
        [FieldOffset(0)]   public float time;
        [FieldOffset(4)]   public float fixedTime;
        [FieldOffset(8)]   public float reentryInputPriorityTime;
        [FieldOffset(12)]  public float reentryTime;
        [FieldOffset(16)]  public float frontAngle;
        [FieldOffset(20)]  public float backAngle;
        [FieldOffset(24)]  public float addFallSpeed;
        [FieldOffset(28)]  public PlayerParamAvoidData data__arr0;
        [FieldOffset(44)] public PlayerParamAvoidData data__arr1;
        [FieldOffset(60)] public PlayerParamAvoidData data__arr2;
        [FieldOffset(76)] public PlayerParamAvoidData data__arr3;
        [FieldOffset(92)] public PlayerParamAvoidData data__arr4;
        [FieldOffset(108)] public PlayerParamAvoidData data__arr5;
        [FieldOffset(124)] public PlayerParamAvoidData data__arr6;
        [FieldOffset(140)] public float baseDistance;
        [FieldOffset(144)] public float limitAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2144)]
    public struct ModePackage
    {
        [FieldOffset(0)]    public PlayerParamCommon common;
        [FieldOffset(48)]   public PlayerParamSpeed speed;
        [FieldOffset(272)]  public PlayerParamRotation rotation;
        [FieldOffset(316)]  public PlayerParamRunning running;
        [FieldOffset(368)]  public PlayerParamBalance balance;
        [FieldOffset(400)]  public PlayerParamBrake brake;
        [FieldOffset(424)]  public PlayerParamTurn turn;
        [FieldOffset(440)]  public PlayerParamJump jump;
        [FieldOffset(468)]  public PlayerParamJumpSpeed jumpSpeed;
        [FieldOffset(516)]  public PlayerParamDoubleJump doubleJump;
        [FieldOffset(528)]  public PlayerParamFall fall;
        [FieldOffset(576)]  public PlayerParamDamage damage;
        [FieldOffset(720)]  public PlayerParamDead dead;
        [FieldOffset(732)]  public PlayerParamSliding sliding;
        [FieldOffset(796)]  public PlayerParamStomping stomping;
        [FieldOffset(828)]  public PlayerParamGrind grind;
        [FieldOffset(848)]  public PlayerParamFallSlope fallSlope;
        [FieldOffset(904)]  public PlayerParamFallFlip fallFlip;
        [FieldOffset(916)]  public PlayerParamTumble tumble;
        [FieldOffset(1020)] public PlayerParamSpinAttack spinAttack;
        [FieldOffset(1052)] public PlayerParamHomingAttack homingAttack;
        [FieldOffset(1228)] public PlayerParamHitEnemy hitEnemy;
        [FieldOffset(1244)] public PlayerParamDiving diving;
        [FieldOffset(1336)] public PlayerParamFan fan;
        [FieldOffset(1360)] public PlayerParamBackflip backflip;
        [FieldOffset(1384)] public PlayerParamSlowMove slowmove;
        [FieldOffset(1416)] public PlayerParamSpin spin;
        [FieldOffset(1448)] public PlayerParamWallMove wallmove;
        [FieldOffset(1584)] public PlayerParamWallJump walljump;
        [FieldOffset(1620)] public PlayerParamClimbing climbing;
        [FieldOffset(1704)] public PlayerParamSlideDown slidedown;
        [FieldOffset(1728)] public PlayerParamBoost boost;
        [FieldOffset(1788)] public PlayerParamAirBoost airboost;
        [FieldOffset(1840)] public PlayerParamAutorun autorun;
        [FieldOffset(1856)] public PlayerParamSideStep sidestep;
        [FieldOffset(1888)] public PlayerParamSideStep2 sidestep2;
        [FieldOffset(1920)] public PlayerParamQuickStep quickstep;
        [FieldOffset(1956)] public PlayerParamParry parry;
        [FieldOffset(1992)] public PlayerParamAvoid avoid;
    }

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct AmyParamPropellerJump
    {
        [FieldOffset(0)]  public float initialSpeed;
        [FieldOffset(4)]  public float bounceSpeed;
        [FieldOffset(8)]  public float limitSpeedMin;
        [FieldOffset(12)] public float maxFallSpeed;
        [FieldOffset(16)] public float fallGravitySize;
        [FieldOffset(20)] public float minDuration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct AmyParamHighJump
    {
        [FieldOffset(0)] public float jumpForce;
        [FieldOffset(4)] public float longPressTime;
    }

    public enum Condition : sbyte
    {
        Time = 0,
        Animation = 1
    }

    public enum Shape : sbyte
    {
        Sphere = 0,
        Cylinder = 1,
        Box = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct PlayerParamAttackCollider
    {
        [FieldOffset(0)]  public Condition condition;
        [FieldOffset(1)]  public sbyte count;
        [FieldOffset(4)]  public float spanTime;
        [FieldOffset(8)]  public Shape shape;
        [FieldOffset(16)] public Vector3 shapeSize;
        [FieldOffset(32)] public Vector3 shapeOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public struct AmyParamTarotAttack
    {
        [FieldOffset(0)]  public PlayerParamAttackCollider hit;
        [FieldOffset(48)] public PlayerParamAttackCollider rollingHit;
        [FieldOffset(96)] public float longPressTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct AmyParamCyHammer
    {
        [FieldOffset(0)] public float radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public struct AmyParamAirCyHammer
    {
        [FieldOffset(0)]  public float acceleForce;
        [FieldOffset(4)]  public float deceleForce;
        [FieldOffset(8)]  public float overSpeedDeceleForce;
        [FieldOffset(12)] public float rotationForce;
        [FieldOffset(16)] public float rotationForceDecaySpeed;
        [FieldOffset(20)] public float rotationForceDecayRate;
        [FieldOffset(24)] public float rotationForceDecayMax;
        [FieldOffset(28)] public float airRadius;
        [FieldOffset(32)] public float groundRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct PlayerParamSpinBoostSpeed
    {
        [FieldOffset(0)]  public float initialSpeed;
        [FieldOffset(4)]  public float maxSpeed;
        [FieldOffset(8)]  public PlayerParamSpeedAcceleData accele;
        [FieldOffset(28)] public PlayerParamSpeedAcceleData decele;
        [FieldOffset(48)] public float baseRotateForce;
        [FieldOffset(52)] public float minTurnSpeed;
        [FieldOffset(56)] public float turnDeceleAngleMin;
        [FieldOffset(60)] public float turnDeceleAngleMax;
    }

    public enum AirAccelMode : sbyte
    {
        Alawys = 0,
        AirAccelMode_None = 1,
        Speed = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 248)]
    public struct PlayerParamSpinBoost
    {
        [FieldOffset(0)]   public float forceRunTime;
        [FieldOffset(4)]   public float initialRunTime;
        [FieldOffset(8)]   public PlayerParamSpinBoostSpeed speedBall;
        [FieldOffset(72)]  public PlayerParamSpinBoostSpeed speedBoost;
        [FieldOffset(136)] public PlayerParamSpeedAcceleData2 deceleNeutralMin;
        [FieldOffset(152)] public PlayerParamSpeedAcceleData2 deceleNeutralMax;
        [FieldOffset(168)] public float gravitySize;
        [FieldOffset(172)] public float gravityBeginTime;
        [FieldOffset(176)] public float gravityMaxTime;
        [FieldOffset(180)] public float gravitySizeMinInAir;
        [FieldOffset(184)] public float gravitySizeMaxInAir;
        [FieldOffset(188)] public float maxGravityAccele;
        [FieldOffset(192)] public float maxGravityDecele;
        [FieldOffset(196)] public float inAirTime;
        [FieldOffset(200)] public float spinBoostEndSpeed;
        [FieldOffset(204)] public float jumpOutAngle;
        [FieldOffset(208)] public float jumpOutSpeed;
        [FieldOffset(212)] public bool humpJumpOut;
        [FieldOffset(213)] public AirAccelMode airAccelMode;
        [FieldOffset(216)] public float airAccelVertSpeedThreshold;
        [FieldOffset(220)] public float chargeRotateForce;
        [FieldOffset(224)] public float chargeRotateForceMinAngle;
        [FieldOffset(228)] public float chargeRotateForceMaxAngle;
        [FieldOffset(232)] public CString cameraShakeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2576)]
    public struct ModePackageAmy
    {
        [FieldOffset(0)]    public ModePackage modePackage;
        [FieldOffset(2144)] public AmyParamPropellerJump propellerJump;
        [FieldOffset(2168)] public AmyParamHighJump highJump;
        [FieldOffset(2176)] public AmyParamTarotAttack tarotAttack;
        [FieldOffset(2288)] public AmyParamCyHammer cyHammer;
        [FieldOffset(2292)] public AmyParamAirCyHammer airCyHammer;
        [FieldOffset(2328)] public PlayerParamSpinBoost spinBoost;
    }

    [StructLayout(LayoutKind.Explicit, Size = 424)]
    public struct WaterModePackage
    {
        [FieldOffset(0)]   public PlayerParamSpeed speed;
        [FieldOffset(224)] public PlayerParamJump jump;
        [FieldOffset(252)] public PlayerParamJumpSpeed jumpSpeed;
        [FieldOffset(300)] public PlayerParamDoubleJump doubleJump;
        [FieldOffset(312)] public PlayerParamBoost boost;
        [FieldOffset(372)] public PlayerParamAirBoost airboost;
    }

    [StructLayout(LayoutKind.Explicit, Size = 19472)]
    public struct AmyParameters
    {
        [FieldOffset(0)]     public CommonPackageAmy common;
        [FieldOffset(16464)] public ModePackageAmy forwardView;
        [FieldOffset(19040)] public WaterModePackage water;
    }

}