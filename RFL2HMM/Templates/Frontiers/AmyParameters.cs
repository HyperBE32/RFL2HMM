using System.Numerics;
using System.Runtime.InteropServices;

public class AmyParametersClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamOffensive
    {
        [FieldOffset(0x00)] public ushort pointMin;
        [FieldOffset(0x02)] public ushort pointMax;
        [FieldOffset(0x04)] public float damageRandomRate;
        [FieldOffset(0x08)] public float damageRandomRateSS;
        [FieldOffset(0x0C)] public float shapeDamageRate;
        [FieldOffset(0x10)] public float shapeStunRate;
        [FieldOffset(0x14)] public float shapeStaggerRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamDefensive
    {
        [FieldOffset(0x00)] public byte rateMin;
        [FieldOffset(0x01)] public byte rateMax;
        [FieldOffset(0x02)] public ushort infimumDropRings;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct PlayerParamAttackCommon
    {
        [FieldOffset(0x00)] public PlayerParamOffensive offensive;
        [FieldOffset(0x18)] public PlayerParamDefensive defensive;
        [FieldOffset(0x1C)] public float criticalDamageRate;
        [FieldOffset(0x20)] public float criticalRate;
        [FieldOffset(0x24)] public float criticalRateSS;
        [FieldOffset(0x28)] public float downedDamageRate;
    }

    public enum HitSE : sbyte
    {
        SE_None = -1,
        Weak = 0,
        Strong = 1,
        VeryStrong = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct UnmanagedString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
            get
            {
                if (pValue == 0)
                    return string.Empty;

                return Marshal.PtrToStringAnsi((nint)pValue);
            }

            set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
        }

        public UnmanagedString(string in_value)
        {
            Value = in_value;
        }

        public static implicit operator UnmanagedString(string in_value)
        {
            return new UnmanagedString(in_value);
        }

        public static bool operator ==(UnmanagedString in_left, string in_right)
        {
            return in_left.Value == in_right;
        }

        public static bool operator !=(UnmanagedString in_left, string in_right)
        {
            return !(in_left == in_right);
        }

        public override bool Equals(object in_obj)
        {
            if (in_obj is string str)
                return Value == str;

            return base.Equals(in_obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x160)]
    public struct PlayerParamAttackData
    {
        [FieldOffset(0x00)] public float damageRate;
        [FieldOffset(0x04)] public float damageRateSS;
        [FieldOffset(0x08)] public ushort pointMin;
        [FieldOffset(0x0A)] public ushort pointMax;
        [FieldOffset(0x0C)] public float damageRateAcceleMode;
        [FieldOffset(0x10)] public float damageRateManual;
        [FieldOffset(0x14)] public float stunPoint;
        [FieldOffset(0x18)] public float staggerPoint;
        [FieldOffset(0x20)] public Vector3 velocity;
        [FieldOffset(0x30)] public float velocityKeepTime;
        [FieldOffset(0x34)] public float addComboValue;
        [FieldOffset(0x38)] public float addComboValueAccele;
        [FieldOffset(0x3C)] public float addComboValueSS;
        [FieldOffset(0x40)] public float addComboValueAcceleSS;
        [FieldOffset(0x44)] public float addQuickCyloopEnergy;
        [FieldOffset(0x48)] public float addQuickCyloopEnergyAccele;
        [FieldOffset(0x4C)] public float addQuickCyloopEnergySS;
        [FieldOffset(0x50)] public float addQuickCyloopEnergyAcceleSS;
        [FieldOffset(0x54)] public float addQuickCyloopEnergyGuard;
        [FieldOffset(0x58)] public float addQuickCyloopEnergyAcceleGuard;
        [FieldOffset(0x60)] public Vector3 gimmickVelocity;
        [FieldOffset(0x70)] public float ignoreTime;
        [FieldOffset(0x74)] public uint attributes;
        [FieldOffset(0x78)] public HitSE se;
        [FieldOffset(0x80)] public UnmanagedString hitEffectName;
        [FieldOffset(0x90)] public UnmanagedString hitEffectNameSS;
        [FieldOffset(0xA0)] public UnmanagedString hitStopName;
        [FieldOffset(0xB0)] public UnmanagedString hitStopNameDead;
        [FieldOffset(0xC0)] public UnmanagedString hitStopNameDeadBoss;
        [FieldOffset(0xD0)] public UnmanagedString hitStopNameSS;
        [FieldOffset(0xE0)] public UnmanagedString hitStopNameDeadSS;
        [FieldOffset(0xF0)] public UnmanagedString hitCameraShakeName;
        [FieldOffset(0x100)] public UnmanagedString hitCameraShakeNameDead;
        [FieldOffset(0x110)] public UnmanagedString hitCameraShakeNameDeadBoss;
        [FieldOffset(0x120)] public UnmanagedString hitCameraShakeNameSS;
        [FieldOffset(0x130)] public UnmanagedString hitCameraShakeNameDeadSS;
        [FieldOffset(0x140)] public UnmanagedString hitVibrationName;
        [FieldOffset(0x150)] public UnmanagedString hitVibrationNameSS;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4A70)]
    public struct PlayerParamAttack
    {
        [FieldOffset(0x00)] public PlayerParamAttackCommon common;
        [FieldOffset(0x30)] public PlayerParamAttackData spinAttack;
        [FieldOffset(0x190)] public PlayerParamAttackData spinDash;
        [FieldOffset(0x2F0)] public PlayerParamAttackData homingAttack;
        [FieldOffset(0x450)] public PlayerParamAttackData homingAttackAir;
        [FieldOffset(0x5B0)] public PlayerParamAttackData pursuitKick;
        [FieldOffset(0x710)] public PlayerParamAttackData stomping;
        [FieldOffset(0x870)] public PlayerParamAttackData stompingAttack;
        [FieldOffset(0x9D0)] public PlayerParamAttackData boundStompingLast;
        [FieldOffset(0xB30)] public PlayerParamAttackData sliding;
        [FieldOffset(0xC90)] public PlayerParamAttackData loopKick;
        [FieldOffset(0xDF0)] public PlayerParamAttackData crasher;
        [FieldOffset(0xF50)] public PlayerParamAttackData spinSlashHoming;
        [FieldOffset(0x10B0)] public PlayerParamAttackData spinSlash;
        [FieldOffset(0x1210)] public PlayerParamAttackData spinSlashLast;
        [FieldOffset(0x1370)] public PlayerParamAttackData sonicBoom;
        [FieldOffset(0x14D0)] public PlayerParamAttackData crossSlash;
        [FieldOffset(0x1630)] public PlayerParamAttackData homingShot;
        [FieldOffset(0x1790)] public PlayerParamAttackData chargeAttack;
        [FieldOffset(0x18F0)] public PlayerParamAttackData chargeAttackLast;
        [FieldOffset(0x1A50)] public PlayerParamAttackData cyloop;
        [FieldOffset(0x1BB0)] public PlayerParamAttackData cyloopQuick;
        [FieldOffset(0x1D10)] public PlayerParamAttackData cyloopAerial;
        [FieldOffset(0x1E70)] public PlayerParamAttackData accele1;
        [FieldOffset(0x1FD0)] public PlayerParamAttackData accele2;
        [FieldOffset(0x2130)] public PlayerParamAttackData aerialAccele1;
        [FieldOffset(0x2290)] public PlayerParamAttackData aerialAccele2;
        [FieldOffset(0x23F0)] public PlayerParamAttackData comboFinish;
        [FieldOffset(0x2550)] public PlayerParamAttackData comboFinishF;
        [FieldOffset(0x26B0)] public PlayerParamAttackData comboFinishB;
        [FieldOffset(0x2810)] public PlayerParamAttackData comboFinishL;
        [FieldOffset(0x2970)] public PlayerParamAttackData comboFinishR;
        [FieldOffset(0x2AD0)] public PlayerParamAttackData acceleComboFinish;
        [FieldOffset(0x2C30)] public PlayerParamAttackData acceleComboFinishF;
        [FieldOffset(0x2D90)] public PlayerParamAttackData acceleComboFinishB;
        [FieldOffset(0x2EF0)] public PlayerParamAttackData acceleComboFinishL;
        [FieldOffset(0x3050)] public PlayerParamAttackData acceleComboFinishR;
        [FieldOffset(0x31B0)] public PlayerParamAttackData smash;
        [FieldOffset(0x3310)] public PlayerParamAttackData smashLast;
        [FieldOffset(0x3470)] public PlayerParamAttackData slingShot;
        [FieldOffset(0x35D0)] public PlayerParamAttackData knucklesPunch1;
        [FieldOffset(0x3730)] public PlayerParamAttackData knucklesPunch2;
        [FieldOffset(0x3890)] public PlayerParamAttackData knucklesUppercut;
        [FieldOffset(0x39F0)] public PlayerParamAttackData knucklesHeatKnuckle;
        [FieldOffset(0x3B50)] public PlayerParamAttackData knucklesHeatKnuckleLast;
        [FieldOffset(0x3CB0)] public PlayerParamAttackData amyTarotAttack;
        [FieldOffset(0x3E10)] public PlayerParamAttackData amyTarotAttack2;
        [FieldOffset(0x3F70)] public PlayerParamAttackData amyTarotRolling;
        [FieldOffset(0x40D0)] public PlayerParamAttackData amyCharmAttack;
        [FieldOffset(0x4230)] public PlayerParamAttackData amyTarotBoost;
        [FieldOffset(0x4390)] public PlayerParamAttackData tailsSpanner;
        [FieldOffset(0x44F0)] public PlayerParamAttackData tailsSpannerFloat;
        [FieldOffset(0x4650)] public PlayerParamAttackData tailsPowerBoost;
        [FieldOffset(0x47B0)] public PlayerParamAttackData tailsWaveCannon;
        [FieldOffset(0x4910)] public PlayerParamAttackData tailsWaveCannonFinish;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamWaterAct
    {
        [FieldOffset(0x00)] public float resistRate;
        [FieldOffset(0x04)] public float breatheBrake;
        [FieldOffset(0x08)] public float breatheTime;
        [FieldOffset(0x0C)] public float breatheGravity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamBaseJump
    {
        [FieldOffset(0x00)] public float baseSpeed;
        [FieldOffset(0x04)] public float upSpeed;
        [FieldOffset(0x08)] public float upSpeedAir;
        [FieldOffset(0x0C)] public float edgeSpeed;
        [FieldOffset(0x10)] public float airActionTime;
        [FieldOffset(0x14)] public float wallMoveTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamBallMove
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float slidePower;
        [FieldOffset(0x08)] public float brakeForce;
        [FieldOffset(0x0C)] public float slidePowerSlalom;
        [FieldOffset(0x10)] public float brakeForceSlalom;
        [FieldOffset(0x14)] public float releaseSpeed;
        [FieldOffset(0x18)] public bool useInput;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamLocusData
    {
        [FieldOffset(0x00)] public float width;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float u0;
        [FieldOffset(0x0C)] public float u1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamLocus
    {
        [FieldOffset(0x00)] public PlayerParamLocusData data__arr0;
        [FieldOffset(0x10)] public PlayerParamLocusData data__arr1;
        [FieldOffset(0x20)] public PlayerParamLocusData data__arr2;
        [FieldOffset(0x30)] public PlayerParamLocusData data__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamAuraTrain
    {
        [FieldOffset(0x00)] public float effectSpanTime;
        [FieldOffset(0x04)] public float effectLifeTime;
        [FieldOffset(0x08)] public float effectOffsetDistance;
        [FieldOffset(0x0C)] public float effectOverlapDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamLevel
    {
        [FieldOffset(0x00)] public byte ringsLevel;
        [FieldOffset(0x01)] public byte speedLevel;
        [FieldOffset(0x02)] public byte offensiveLevel;
        [FieldOffset(0x03)] public byte defensiveLevel;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamBarrierWall
    {
        [FieldOffset(0x00)] public float coolTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamDamageRateLevel
    {
        [FieldOffset(0x00)] public float rates__arr0;
        [FieldOffset(0x04)] public float rates__arr1;
        [FieldOffset(0x08)] public float rates__arr2;
        [FieldOffset(0x0C)] public float rates__arr3;
        [FieldOffset(0x10)] public float rates__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct PlayerParamDamageRate
    {
        [FieldOffset(0x00)] public PlayerParamDamageRateLevel diffculties__arr0;
        [FieldOffset(0x14)] public PlayerParamDamageRateLevel diffculties__arr1;
        [FieldOffset(0x28)] public PlayerParamDamageRateLevel diffculties__arr2;
        [FieldOffset(0x3C)] public PlayerParamDamageRateLevel diffculties__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamAcceleMode
    {
        [FieldOffset(0x00)] public float declineSpeed;
        [FieldOffset(0x04)] public float declineSpeedAccele;
        [FieldOffset(0x08)] public float lossDamaged;
        [FieldOffset(0x0C)] public float lossDamagedAccele;
        [FieldOffset(0x10)] public uint comboRateAccele;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4B70)]
    public struct CommonPackage
    {
        [FieldOffset(0x00)] public PlayerParamAttack attack;
        [FieldOffset(0x4A70)] public PlayerParamWaterAct wateract;
        [FieldOffset(0x4A80)] public PlayerParamBaseJump basejump;
        [FieldOffset(0x4A98)] public PlayerParamBallMove ballmove;
        [FieldOffset(0x4AB4)] public PlayerParamLocus locus;
        [FieldOffset(0x4AF4)] public PlayerParamAuraTrain auratrain;
        [FieldOffset(0x4B04)] public PlayerParamLevel level;
        [FieldOffset(0x4B08)] public PlayerParamBarrierWall barrierWall;
        [FieldOffset(0x4B0C)] public PlayerParamDamageRate damageRate;
        [FieldOffset(0x4B5C)] public PlayerParamAcceleMode acceleMode;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamComboCommon
    {
        [FieldOffset(0x00)] public float longPressTime;
    }

    public enum ComboMoveType : byte
    {
        Homing = 0,
        Step = 1,
        None = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamComboMove
    {
        [FieldOffset(0x00)] public ComboMoveType moveType;
        [FieldOffset(0x04)] public float moveInitialSpeed;
        [FieldOffset(0x08)] public float moveMaxSpeed;
        [FieldOffset(0x0C)] public float moveAccele;
        [FieldOffset(0x10)] public float timeout;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct PlayerParamComboMoveCorrection
    {
        [FieldOffset(0x00)] public float moveSpeed;
        [FieldOffset(0x04)] public float rotateSpeed;
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
        AmyTarotAttack2 = 36,
        AmyTarotRolling = 37,
        AmyCyHammer = 38,
        AmyCharmAttack = 39,
        TailsSpanner = 40,
        ActionNum = 41
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x12)]
    public struct PlayerParamComboTransit
    {
        [FieldOffset(0x00)] public Action transitExistTarget__arr0;
        [FieldOffset(0x01)] public Action transitExistTarget__arr1;
        [FieldOffset(0x02)] public Action transitExistTarget__arr2;
        [FieldOffset(0x03)] public Action transitExistTarget__arr3;
        [FieldOffset(0x04)] public Action transitExistTarget__arr4;
        [FieldOffset(0x05)] public Action transitExistTarget__arr5;
        [FieldOffset(0x06)] public Action transitInAir__arr0;
        [FieldOffset(0x07)] public Action transitInAir__arr1;
        [FieldOffset(0x08)] public Action transitInAir__arr2;
        [FieldOffset(0x09)] public Action transitInAir__arr3;
        [FieldOffset(0x0A)] public Action transitInAir__arr4;
        [FieldOffset(0x0B)] public Action transitInAir__arr5;
        [FieldOffset(0x0C)] public Action transitNotExistTarget__arr0;
        [FieldOffset(0x0D)] public Action transitNotExistTarget__arr1;
        [FieldOffset(0x0E)] public Action transitNotExistTarget__arr2;
        [FieldOffset(0x0F)] public Action transitNotExistTarget__arr3;
        [FieldOffset(0x10)] public Action transitNotExistTarget__arr4;
        [FieldOffset(0x11)] public Action transitNotExistTarget__arr5;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2AC)]
    public struct PlayerParamComboTransitTable
    {
        [FieldOffset(0x00)] public PlayerParamComboTransit root;
        [FieldOffset(0x12)] public PlayerParamComboTransit homingAttack;
        [FieldOffset(0x24)] public PlayerParamComboTransit aerialHoming;
        [FieldOffset(0x36)] public PlayerParamComboTransit pursuit;
        [FieldOffset(0x48)] public PlayerParamComboTransit stomping;
        [FieldOffset(0x5A)] public PlayerParamComboTransit loopKick;
        [FieldOffset(0x6C)] public PlayerParamComboTransit crasher;
        [FieldOffset(0x7E)] public PlayerParamComboTransit spinSlash;
        [FieldOffset(0x90)] public PlayerParamComboTransit sonicBoom;
        [FieldOffset(0xA2)] public PlayerParamComboTransit crossSlash;
        [FieldOffset(0xB4)] public PlayerParamComboTransit homingShot;
        [FieldOffset(0xC6)] public PlayerParamComboTransit chargeAttack;
        [FieldOffset(0xD8)] public PlayerParamComboTransit quickCyloop;
        [FieldOffset(0xEA)] public PlayerParamComboTransit aerialQuickCyloop;
        [FieldOffset(0xFC)] public PlayerParamComboTransit acceleCombo1;
        [FieldOffset(0x10E)] public PlayerParamComboTransit acceleCombo2;
        [FieldOffset(0x120)] public PlayerParamComboTransit acceleCombo3;
        [FieldOffset(0x132)] public PlayerParamComboTransit acceleCombo4;
        [FieldOffset(0x144)] public PlayerParamComboTransit aerialAcceleCombo1;
        [FieldOffset(0x156)] public PlayerParamComboTransit aerialAcceleCombo2;
        [FieldOffset(0x168)] public PlayerParamComboTransit aerialAcceleCombo3;
        [FieldOffset(0x17A)] public PlayerParamComboTransit aerialAcceleCombo4;
        [FieldOffset(0x18C)] public PlayerParamComboTransit behind;
        [FieldOffset(0x19E)] public PlayerParamComboTransit guarded;
        [FieldOffset(0x1B0)] public PlayerParamComboTransit avoid;
        [FieldOffset(0x1C2)] public PlayerParamComboTransit airBoost;
        [FieldOffset(0x1D4)] public PlayerParamComboTransit afterAirBoost;
        [FieldOffset(0x1E6)] public PlayerParamComboTransit knucklesPunch1;
        [FieldOffset(0x1F8)] public PlayerParamComboTransit knucklesPunch2;
        [FieldOffset(0x20A)] public PlayerParamComboTransit knucklesUppercut;
        [FieldOffset(0x21C)] public PlayerParamComboTransit knucklesCyKnuckle;
        [FieldOffset(0x22E)] public PlayerParamComboTransit knucklesHeatKnuckle;
        [FieldOffset(0x240)] public PlayerParamComboTransit amyTarotAttack;
        [FieldOffset(0x252)] public PlayerParamComboTransit amyTarotAttack2;
        [FieldOffset(0x264)] public PlayerParamComboTransit amyTarotRolling;
        [FieldOffset(0x276)] public PlayerParamComboTransit amyCyHammer;
        [FieldOffset(0x288)] public PlayerParamComboTransit amyCharmAttack;
        [FieldOffset(0x29A)] public PlayerParamComboTransit tailsSpanner;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2E0)]
    public struct PlayerParamCombo
    {
        [FieldOffset(0x00)] public PlayerParamComboCommon common;
        [FieldOffset(0x04)] public PlayerParamComboMove comboMoveSonic;
        [FieldOffset(0x18)] public PlayerParamComboMove comboMoveSupersonic;
        [FieldOffset(0x2C)] public PlayerParamComboMoveCorrection comboMoveCorrection;
        [FieldOffset(0x34)] public PlayerParamComboTransitTable comboTable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct AmyParamParryDebuff
    {
        [FieldOffset(0x00)] public uint damagePoint;
        [FieldOffset(0x04)] public float effectTime;
        [FieldOffset(0x08)] public float initTime;
        [FieldOffset(0x0C)] public float spanTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct CyloopSlashEffectBaseParameter
    {
        [FieldOffset(0x00)] public int m_divideCircle;
        [FieldOffset(0x04)] public float m_circleRadius;
        [FieldOffset(0x08)] public float m_circleWaveCycle;
        [FieldOffset(0x0C)] public float m_circleWaveWidth;
        [FieldOffset(0x10)] public float m_circleWaveSpeed;
        [FieldOffset(0x14)] public Vector2 m_scale;
        [FieldOffset(0x20)] public UnmanagedString m_textureName;
        [FieldOffset(0x30)] public float m_flowSpeed;
        [FieldOffset(0x34)] public float m_twistCycle;
        [FieldOffset(0x38)] public float m_rollCycle;
        [FieldOffset(0x3C)] public float m_rollPhase;
        [FieldOffset(0x40)] public float m_alphaHeadDistance;
        [FieldOffset(0x44)] public float m_alphaTailDistance;
        [FieldOffset(0x48)] public float m_offsetCycle;
        [FieldOffset(0x4C)] public float m_offsetPhase;
        [FieldOffset(0x50)] public float m_offsetRadius;
    }

    public struct ColorF
    {
        public float A;
        public float R;
        public float G;
        public float B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA8)]
    public struct CyloopTransparentLocusParameter
    {
        [FieldOffset(0)]   public CyloopSlashEffectBaseParameter cyloopSlashEffectBaseParameter;
        [FieldOffset(0x58)] public ColorF m_color0;
        [FieldOffset(0x68)] public ColorF m_color1;
        [FieldOffset(0x78)] public float m_luminance;
        [FieldOffset(0x7C)] public ColorF m_flashColor0;
        [FieldOffset(0x8C)] public ColorF m_flashColor1;
        [FieldOffset(0x9C)] public float m_flashLuminance;
        [FieldOffset(0xA0)] public float m_flashTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct OpaqueLineUvCell
    {
        [FieldOffset(0x00)] public float scale;
        [FieldOffset(0x04)] public float speedX;
        [FieldOffset(0x08)] public float speedY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct CyloopOpaqueLocusParameter
    {
        [FieldOffset(0)]   public CyloopSlashEffectBaseParameter cyloopSlashEffectBaseParameter;
        [FieldOffset(0x58)] public ColorF m_color;
        [FieldOffset(0x68)] public float m_alphaThreshold;
        [FieldOffset(0x6C)] public OpaqueLineUvCell m_uvCells__arr0;
        [FieldOffset(0x78)] public OpaqueLineUvCell m_uvCells__arr1;
        [FieldOffset(0x84)] public float m_uvLineScaleX;
        [FieldOffset(0x88)] public float m_uvLineScaleY;
        [FieldOffset(0x8C)] public ColorF m_flashColor;
        [FieldOffset(0x9C)] public float m_flashTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xF0)]
    public struct CyloopCrossLineParameter
    {
        [FieldOffset(0x00)] public UnmanagedString m_textureNamePattern;
        [FieldOffset(0x10)] public UnmanagedString m_textureNameDist;
        [FieldOffset(0x20)] public ColorF startColor;
        [FieldOffset(0x30)] public ColorF endColor;
        [FieldOffset(0x40)] public float startColorLuminance;
        [FieldOffset(0x44)] public float endColorLuminance;
        [FieldOffset(0x48)] public ColorF startColorFlash;
        [FieldOffset(0x58)] public ColorF endColorFlash;
        [FieldOffset(0x68)] public float startColorLuminanceFlash;
        [FieldOffset(0x6C)] public float endColorLuminanceFlash;
        [FieldOffset(0x70)] public float flashTime;
        [FieldOffset(0x74)] public float patternDepth;
        [FieldOffset(0x78)] public float patternScrollSpeed;
        [FieldOffset(0x7C)] public float patternDarkness;
        [FieldOffset(0x80)] public float patternScale;
        [FieldOffset(0x84)] public float glitchResX;
        [FieldOffset(0x88)] public float glitchResY;
        [FieldOffset(0x8C)] public float glitchOffset;
        [FieldOffset(0x90)] public float glitchMaxLength;
        [FieldOffset(0x94)] public float startGlitchScrollSpeed;
        [FieldOffset(0x98)] public float startGlitchChangeSpeed;
        [FieldOffset(0x9C)] public float startGlitchShift;
        [FieldOffset(0xA0)] public float startGlitchContrust;
        [FieldOffset(0xA4)] public float endGlitchScrollSpeed;
        [FieldOffset(0xA8)] public float endGlitchChangeSpeed;
        [FieldOffset(0xAC)] public float endGlitchShift;
        [FieldOffset(0xB0)] public float endGlitchContrust;
        [FieldOffset(0xB4)] public float lineWidth;
        [FieldOffset(0xB8)] public float lineDisplayWidth;
        [FieldOffset(0xBC)] public float lineBlackEdgeWidth;
        [FieldOffset(0xC0)] public float lineBlackEdgeIntensity;
        [FieldOffset(0xC4)] public float lineBlackEdgeNormalFade;
        [FieldOffset(0xC8)] public float distNoiseScale;
        [FieldOffset(0xCC)] public float distLowNoiseScale;
        [FieldOffset(0xD0)] public float distHighNoiseScale;
        [FieldOffset(0xD4)] public float distNoiseRate;
        [FieldOffset(0xD8)] public float distScrollSpeed;
        [FieldOffset(0xDC)] public float distIntensity;
        [FieldOffset(0xE0)] public float dissolve;
        [FieldOffset(0xE4)] public float dissolveRate;
        [FieldOffset(0xE8)] public float heightOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4E0)]
    public struct CyloopLocusParameter
    {
        [FieldOffset(0x00)] public int m_numTransparentLines;
        [FieldOffset(0x08)] public CyloopTransparentLocusParameter m_transparentLines__arr0;
        [FieldOffset(0xB0)] public CyloopTransparentLocusParameter m_transparentLines__arr1;
        [FieldOffset(0x158)] public CyloopTransparentLocusParameter m_transparentLines__arr2;
        [FieldOffset(0x200)] public int m_numOpaqueLines;
        [FieldOffset(0x208)] public CyloopOpaqueLocusParameter m_opaqueLines__arr0;
        [FieldOffset(0x2A8)] public CyloopOpaqueLocusParameter m_opaqueLines__arr1;
        [FieldOffset(0x348)] public CyloopOpaqueLocusParameter m_opaqueLines__arr2;
        [FieldOffset(0x3E8)] public int m_numCrossLines;
        [FieldOffset(0x3F0)] public CyloopCrossLineParameter m_crossline;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct CyloopDropItemWeightParameter
    {
        [FieldOffset(0x00)] public uint noneWeight;
        [FieldOffset(0x04)] public uint ring10Weight;
        [FieldOffset(0x08)] public uint powerSeedWeight;
        [FieldOffset(0x0C)] public uint guardSeedWeight;
        [FieldOffset(0x10)] public uint sequenceItemWeight;
        [FieldOffset(0x14)] public uint portalBitWeight;
        [FieldOffset(0x18)] public uint skillPieceWeight;
        [FieldOffset(0x1C)] public uint skillPieceAmyWeight;
        [FieldOffset(0x20)] public uint skillPieceKnucklesWeight;
        [FieldOffset(0x24)] public uint skillPieceTailsWeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct CyloopDropItemParameter
    {
        [FieldOffset(0x00)] public CyloopDropItemWeightParameter weight;
        [FieldOffset(0x28)] public CyloopDropItemWeightParameter weight2;
        [FieldOffset(0x50)] public uint numRings;
        [FieldOffset(0x54)] public uint numRings2;
        [FieldOffset(0x58)] public uint num10Rings;
        [FieldOffset(0x5C)] public uint numSkillPieces;
        [FieldOffset(0x60)] public uint skillPieceExp;
        [FieldOffset(0x64)] public float rareDropCoolTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct CyloopShapeWindCountParameter
    {
        [FieldOffset(0x00)] public float damageRate;
        [FieldOffset(0x04)] public float stunRate;
        [FieldOffset(0x08)] public float staggerRate;
        [FieldOffset(0x0C)] public float velocityRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct CyloopShapeWindEffectParaemter
    {
        [FieldOffset(0x00)] public CyloopShapeWindCountParameter param__arr0;
        [FieldOffset(0x10)] public CyloopShapeWindCountParameter param__arr1;
        [FieldOffset(0x20)] public CyloopShapeWindCountParameter param__arr2;
        [FieldOffset(0x30)] public CyloopShapeWindCountParameter param__arr3;
        [FieldOffset(0x40)] public CyloopShapeWindCountParameter param__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct CyloopShapeEffectParameter
    {
        [FieldOffset(0x00)] public CyloopShapeWindEffectParaemter wind;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1460)]
    public struct PlayerParamCyloop
    {
        [FieldOffset(0x00)] public CyloopLocusParameter locus;
        [FieldOffset(0x4E0)] public CyloopLocusParameter locusQuick;
        [FieldOffset(0x9C0)] public CyloopLocusParameter locusSuperSonic;
        [FieldOffset(0xEA0)] public CyloopLocusParameter locusSuperSonicQuick;
        [FieldOffset(0x1380)] public ColorF auraColor;
        [FieldOffset(0x1390)] public CyloopDropItemParameter dropItem;
        [FieldOffset(0x13F8)] public float needSpeed;
        [FieldOffset(0x13FC)] public CyloopShapeEffectParameter shapeEffect;
        [FieldOffset(0x144C)] public float lossQuickCyloopEnergy;
        [FieldOffset(0x1450)] public float recoveryQuickCyloopEnergyByTime;
        [FieldOffset(0x1454)] public float recoveryQuickCyloopEnergyByTimeInMinigame;
        [FieldOffset(0x1458)] public float recoveryFriendsQuickCyloopEnergyByRing;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x62C0)]
    public struct CommonPackageAmy
    {
        [FieldOffset(0)]     public CommonPackage commonPackage;
        [FieldOffset(0x4B70)] public PlayerParamCombo combo;
        [FieldOffset(0x4E50)] public AmyParamParryDebuff parryDebuff;
        [FieldOffset(0x4E60)] public PlayerParamCyloop cyloop;
    }

    public enum SupportedPlane : sbyte
    {
        Flat = 0,
        Slope = 1,
        Wall = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct PlayerParamCommon
    {
        [FieldOffset(0x00)] public float movableMaxSlope;
        [FieldOffset(0x04)] public float activeLandingSlope;
        [FieldOffset(0x08)] public float activeLandingSlopeInBoost;
        [FieldOffset(0x0C)] public float landingMaxSlope;
        [FieldOffset(0x10)] public float slidingMaxSlope;
        [FieldOffset(0x14)] public float wallAngleMaxSlope;
        [FieldOffset(0x18)] public SupportedPlane onStand;
        [FieldOffset(0x19)] public SupportedPlane onRunInAir;
        [FieldOffset(0x1A)] public SupportedPlane onRun;
        [FieldOffset(0x1B)] public bool moveHolding;
        [FieldOffset(0x1C)] public bool wallSlideSlowInBoost;
        [FieldOffset(0x1D)] public bool attrWallOnGround;
        [FieldOffset(0x20)] public float priorityInputTime;
        [FieldOffset(0x24)] public int capacityRings;
        [FieldOffset(0x28)] public int capacityRingsLvMax;
        [FieldOffset(0x2C)] public float collectRingRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamSpeedData
    {
        [FieldOffset(0x00)] public float initial;
        [FieldOffset(0x04)] public float min;
        [FieldOffset(0x08)] public float max;
        [FieldOffset(0x0C)] public float minTurn;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamSpeedAcceleData
    {
        [FieldOffset(0x00)] public float force;
        [FieldOffset(0x04)] public float force2;
        [FieldOffset(0x08)] public float damperRange;
        [FieldOffset(0x0C)] public float jerkMin;
        [FieldOffset(0x10)] public float jerkMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamSpeedAcceleData2
    {
        [FieldOffset(0x00)] public float force;
        [FieldOffset(0x04)] public float damperRange;
        [FieldOffset(0x08)] public float jerkMin;
        [FieldOffset(0x0C)] public float jerkMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE0)]
    public struct PlayerParamSpeed
    {
        [FieldOffset(0x00)] public PlayerParamSpeedData normal;
        [FieldOffset(0x10)] public PlayerParamSpeedData normal2;
        [FieldOffset(0x20)] public PlayerParamSpeedData boost;
        [FieldOffset(0x30)] public PlayerParamSpeedData boost2;
        [FieldOffset(0x40)] public PlayerParamSpeedData boostLvMax;
        [FieldOffset(0x50)] public PlayerParamSpeedData boostLvMax2;
        [FieldOffset(0x60)] public float maxSpeedOver;
        [FieldOffset(0x64)] public float opitonMaxSpeedLimitMin;
        [FieldOffset(0x68)] public float opitonMaxSpeedLimitMax;
        [FieldOffset(0x6C)] public float thresholdStopSpeed;
        [FieldOffset(0x70)] public float maxFallSpeed;
        [FieldOffset(0x74)] public PlayerParamSpeedAcceleData accele;
        [FieldOffset(0x88)] public PlayerParamSpeedAcceleData decele;
        [FieldOffset(0x9C)] public PlayerParamSpeedAcceleData2 deceleNeutralMin;
        [FieldOffset(0xAC)] public PlayerParamSpeedAcceleData2 deceleNeutralMax;
        [FieldOffset(0xBC)] public float acceleAuto;
        [FieldOffset(0xC0)] public float deceleAuto;
        [FieldOffset(0xC4)] public float turnDeceleAngleMin;
        [FieldOffset(0xC8)] public float turnDeceleAngleMax;
        [FieldOffset(0xCC)] public float maxGravityAccele;
        [FieldOffset(0xD0)] public float maxGravityDecele;
        [FieldOffset(0xD4)] public float deceleSquat;
        [FieldOffset(0xD8)] public float acceleSensitive;
        [FieldOffset(0xDC)] public float boostAnimSpeedInWater;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct PlayerParamRotation
    {
        [FieldOffset(0x00)] public float baseRotateForce;
        [FieldOffset(0x04)] public float baseRotateForce2;
        [FieldOffset(0x08)] public float baseRotateForceSpeed;
        [FieldOffset(0x0C)] public float minRotateForce;
        [FieldOffset(0x10)] public float maxRotateForce;
        [FieldOffset(0x14)] public bool angleRotateForceDecayEnabled;
        [FieldOffset(0x18)] public float frontRotateRatio;
        [FieldOffset(0x1C)] public float rotationForceDecaySpeed;
        [FieldOffset(0x20)] public float rotationForceDecayRate;
        [FieldOffset(0x24)] public float rotationForceDecayMax;
        [FieldOffset(0x28)] public float autorunRotateForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct PlayerParamRunning
    {
        [FieldOffset(0x00)] public float walkSpeed;
        [FieldOffset(0x04)] public float sneakingSpeed;
        [FieldOffset(0x08)] public float animSpeedSneak;
        [FieldOffset(0x0C)] public float animSpeedWalk;
        [FieldOffset(0x10)] public float animSpeedRun;
        [FieldOffset(0x14)] public float animSpeedBoost;
        [FieldOffset(0x18)] public float animLRBlendSampleTime;
        [FieldOffset(0x1C)] public float animLRBlendAngleMin;
        [FieldOffset(0x20)] public float animLRBlendAngleMax;
        [FieldOffset(0x24)] public float animLRBlendSpeed;
        [FieldOffset(0x28)] public float animLRBlendSpeedToCenter;
        [FieldOffset(0x2C)] public float minChangeWalkTime;
        [FieldOffset(0x30)] public float fallAnimationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamBalanceData
    {
        [FieldOffset(0x00)] public float rotateSpeedMinFB;
        [FieldOffset(0x04)] public float rotateSpeedMaxFB;
        [FieldOffset(0x08)] public float rotateSpeedMinLR;
        [FieldOffset(0x0C)] public float rotateSpeedMaxLR;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamBalance
    {
        [FieldOffset(0x00)] public PlayerParamBalanceData standard;
        [FieldOffset(0x10)] public PlayerParamBalanceData loop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamBrake
    {
        [FieldOffset(0x00)] public float initialSpeedRatio;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float forceLand;
        [FieldOffset(0x0C)] public float forceAir;
        [FieldOffset(0x10)] public float endSpeed;
        [FieldOffset(0x14)] public float stopTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamTurn
    {
        [FieldOffset(0x00)] public float thresholdSpeed;
        [FieldOffset(0x04)] public float thresholdAngle;
        [FieldOffset(0x08)] public float turnAfterSpeed;
        [FieldOffset(0x0C)] public bool stopEdge;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamJump
    {
        [FieldOffset(0x00)] public float preActionTime;
        [FieldOffset(0x04)] public float longPressTime;
        [FieldOffset(0x08)] public float addForceTime;
        [FieldOffset(0x0C)] public float force;
        [FieldOffset(0x10)] public float addForce;
        [FieldOffset(0x14)] public float forceMin;
        [FieldOffset(0x18)] public float gravitySize;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct PlayerParamJumpSpeed
    {
        [FieldOffset(0x00)] public float acceleForce;
        [FieldOffset(0x04)] public float deceleForce;
        [FieldOffset(0x08)] public float deceleNeutralForce;
        [FieldOffset(0x0C)] public float deceleBackForce;
        [FieldOffset(0x10)] public float limitMin;
        [FieldOffset(0x14)] public float limitUpSpeed;
        [FieldOffset(0x18)] public float rotationForce;
        [FieldOffset(0x1C)] public float rotationForceDecaySpeed;
        [FieldOffset(0x20)] public float rotationForceDecayRate;
        [FieldOffset(0x24)] public float rotationForceDecayMax;
        [FieldOffset(0x28)] public float baseAirDragScaleMin;
        [FieldOffset(0x2C)] public float baseAirDragScaleMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDoubleJump
    {
        [FieldOffset(0x00)] public float initialSpeed;
        [FieldOffset(0x04)] public float bounceSpeed;
        [FieldOffset(0x08)] public float limitSpeedMin;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct PlayerParamFall
    {
        [FieldOffset(0x00)] public float thresholdVertSpeed;
        [FieldOffset(0x04)] public float tolerateJumpTime;
        [FieldOffset(0x08)] public float fallEndDelayTime;
        [FieldOffset(0x0C)] public float fallEndFadeTime;
        [FieldOffset(0x10)] public float acceleForce;
        [FieldOffset(0x14)] public float deceleForce;
        [FieldOffset(0x18)] public float overSpeedDeceleForce;
        [FieldOffset(0x1C)] public float rotationForce;
        [FieldOffset(0x20)] public float rotationForceDecaySpeed;
        [FieldOffset(0x24)] public float rotationForceDecayRate;
        [FieldOffset(0x28)] public float rotationForceDecayMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamDamageCommon
    {
        [FieldOffset(0x00)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamDamageNormal
    {
        [FieldOffset(0x00)] public float initialHorzSpeed;
        [FieldOffset(0x04)] public float initialVertSpeed;
        [FieldOffset(0x08)] public float deceleForce;
        [FieldOffset(0x0C)] public float transitFallTime;
        [FieldOffset(0x10)] public float gravityScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamDamageTurnBack
    {
        [FieldOffset(0x00)] public float fixedTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamDamageBlowOff
    {
        [FieldOffset(0x00)] public float initialHorzSpeed;
        [FieldOffset(0x04)] public float initialVertSpeed;
        [FieldOffset(0x08)] public float deceleForceInAir;
        [FieldOffset(0x0C)] public float deceleForceOnGround;
        [FieldOffset(0x10)] public float gravityScale;
        [FieldOffset(0x14)] public float downTime;
        [FieldOffset(0x18)] public float transitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamDamageGuarded
    {
        [FieldOffset(0x00)] public float vertSpeed;
        [FieldOffset(0x04)] public float horzSpeed;
        [FieldOffset(0x08)] public float deceleForce;
        [FieldOffset(0x0C)] public float transitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamDamageRunning
    {
        [FieldOffset(0x00)] public float actionTime;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float lossSpeed;
        [FieldOffset(0x0C)] public float lossTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamDamageQuake
    {
        [FieldOffset(0x00)] public float actionTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamDamageLava
    {
        [FieldOffset(0x00)] public Vector3 jumpVelocity;
        [FieldOffset(0x10)] public float gravitySize;
        [FieldOffset(0x14)] public float invincibleTime;
        [FieldOffset(0x18)] public float noActionTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct PlayerParamDamageMine
    {
        [FieldOffset(0x00)] public Vector3 jumpVelocity;
        [FieldOffset(0x10)] public float gravitySize;
        [FieldOffset(0x14)] public float invincibleTime;
        [FieldOffset(0x18)] public float noActionTime;
        [FieldOffset(0x1C)] public float gravitySizeForFall;
        [FieldOffset(0x20)] public float maxFallSpeed;
        [FieldOffset(0x28)] public UnmanagedString cameraShakeName;
        [FieldOffset(0x38)] public UnmanagedString vibrationName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE0)]
    public struct PlayerParamDamage
    {
        [FieldOffset(0x00)] public PlayerParamDamageCommon common;
        [FieldOffset(0x04)] public PlayerParamDamageNormal normal;
        [FieldOffset(0x18)] public PlayerParamDamageTurnBack turnBack;
        [FieldOffset(0x1C)] public PlayerParamDamageBlowOff blowOff;
        [FieldOffset(0x38)] public PlayerParamDamageGuarded guarded;
        [FieldOffset(0x48)] public PlayerParamDamageGuarded guardedSS;
        [FieldOffset(0x58)] public PlayerParamDamageRunning running;
        [FieldOffset(0x68)] public PlayerParamDamageQuake quake;
        [FieldOffset(0x70)] public PlayerParamDamageLava lava;
        [FieldOffset(0x90)] public PlayerParamDamageMine mine;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDeadNormal
    {
        [FieldOffset(0x00)] public float invincibleTime;
        [FieldOffset(0x04)] public float initialHorzSpeed;
        [FieldOffset(0x08)] public float initialVertSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDead
    {
        [FieldOffset(0x00)] public PlayerParamDeadNormal normal;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamSliding
    {
        [FieldOffset(0x00)] public float minSpeed;
        [FieldOffset(0x04)] public float endSpeed;
        [FieldOffset(0x08)] public float deceleJerk;
        [FieldOffset(0x0C)] public float deceleJerkContinue;
        [FieldOffset(0x10)] public float deceleForceMax;
        [FieldOffset(0x14)] public float baseRotateForce;
        [FieldOffset(0x18)] public float baseRotateForceSpeed;
        [FieldOffset(0x1C)] public float maxRotateForce;
        [FieldOffset(0x20)] public float frontRotateRatio;
        [FieldOffset(0x24)] public float rotationForceAutoRun;
        [FieldOffset(0x28)] public float movableMaxSlope;
        [FieldOffset(0x2C)] public float gravitySize;
        [FieldOffset(0x30)] public float minContinueTime;
        [FieldOffset(0x34)] public float maxAutoRunTime;
        [FieldOffset(0x38)] public float endSpeedAutoRun;
        [FieldOffset(0x3C)] public float loopKickTransitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamStomping
    {
        [FieldOffset(0x00)] public float initialSpeed;
        [FieldOffset(0x04)] public float initialAccele;
        [FieldOffset(0x08)] public float maxAccele;
        [FieldOffset(0x0C)] public float jerk;
        [FieldOffset(0x10)] public float maxFallSpeed;
        [FieldOffset(0x14)] public float angle;
        [FieldOffset(0x18)] public float landingCancelTime;
        [FieldOffset(0x1C)] public float boundStompingCollisionScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamGrind
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float maxBoostSpeed;
        [FieldOffset(0x08)] public float acceleForce;
        [FieldOffset(0x0C)] public float deceleForce;
        [FieldOffset(0x10)] public float limitSpeedMin;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct PlayerParamFallSlope
    {
        [FieldOffset(0x00)] public float initialSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float brakeAngle;
        [FieldOffset(0x0C)] public float highBrakeAngle;
        [FieldOffset(0x10)] public float brakeForce;
        [FieldOffset(0x14)] public float brakeForceHigh;
        [FieldOffset(0x18)] public float gravitySize;
        [FieldOffset(0x1C)] public float gravitySizeAir;
        [FieldOffset(0x20)] public float endSpeedFront;
        [FieldOffset(0x24)] public float endSpeedBack;
        [FieldOffset(0x28)] public float reverseFallTime;
        [FieldOffset(0x2C)] public float fallToSlipTime;
        [FieldOffset(0x30)] public float slipIdlingTime;
        [FieldOffset(0x34)] public float minSlipTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamFallFlip
    {
        [FieldOffset(0x00)] public float thresholdSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float flipAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct PlayerParamTumble
    {
        [FieldOffset(0x00)] public bool enabled;
        [FieldOffset(0x04)] public float sideSpinAngle;
        [FieldOffset(0x08)] public float initialVertSpeed;
        [FieldOffset(0x0C)] public float gravitySize;
        [FieldOffset(0x10)] public float gravitySize2;
        [FieldOffset(0x14)] public float deceleForceInAir;
        [FieldOffset(0x18)] public float minSpeedInAir;
        [FieldOffset(0x1C)] public float rotateEaseTimeLeftRight;
        [FieldOffset(0x20)] public float rotateEaseTimeFrontBack;
        [FieldOffset(0x24)] public float rotateSpeedMinLeftRight;
        [FieldOffset(0x28)] public float rotateSpeedMaxLeftRight;
        [FieldOffset(0x2C)] public float rotateSpeedMinFrontBack;
        [FieldOffset(0x30)] public float rotateSpeedMaxFrontBack;
        [FieldOffset(0x34)] public float angleLeftRightStagger;
        [FieldOffset(0x38)] public float angleLeftRightRoll;
        [FieldOffset(0x3C)] public float angleFrontBackRoll;
        [FieldOffset(0x40)] public float angleBigRoll;
        [FieldOffset(0x44)] public float inRunTime;
        [FieldOffset(0x48)] public float inAirTime;
        [FieldOffset(0x4C)] public float rollSpeedFront;
        [FieldOffset(0x50)] public float bigRollVelocityRatio;
        [FieldOffset(0x54)] public float dropDashHoldTime;
        [FieldOffset(0x58)] public float airBrakeVertSpeed;
        [FieldOffset(0x5C)] public float airBrakeForce;
        [FieldOffset(0x60)] public float airTrickHeight;
        [FieldOffset(0x64)] public float airTrickTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSpinAttack
    {
        [FieldOffset(0x00)] public float jumpForce;
        [FieldOffset(0x04)] public float jumpAddForce;
        [FieldOffset(0x08)] public float addTime;
        [FieldOffset(0x0C)] public float acceleForce;
        [FieldOffset(0x10)] public float deceleForce;
        [FieldOffset(0x14)] public float brakeForce;
        [FieldOffset(0x18)] public float limitSpeedMin;
        [FieldOffset(0x1C)] public float limitSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamHomingAttackData
    {
        [FieldOffset(0x00)] public float speed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamHomingBounceData
    {
        [FieldOffset(0x00)] public float bounceVertSpeed;
        [FieldOffset(0x04)] public float bounceHorzSpeed;
        [FieldOffset(0x08)] public float bounceAcceleForce;
        [FieldOffset(0x0C)] public float bounceDeceleForce;
        [FieldOffset(0x10)] public float bounceAngleWidth;
        [FieldOffset(0x14)] public float bounceTime;
        [FieldOffset(0x18)] public float attackDownTime;
        [FieldOffset(0x1C)] public float attackDownTimeForStomp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB0)]
    public struct PlayerParamHomingAttack
    {
        [FieldOffset(0x00)] public PlayerParamHomingAttackData sonic;
        [FieldOffset(0x04)] public PlayerParamHomingAttackData supersonic;
        [FieldOffset(0x08)] public PlayerParamHomingBounceData sonicBounce;
        [FieldOffset(0x28)] public PlayerParamHomingBounceData sonicBounceWeak;
        [FieldOffset(0x48)] public PlayerParamHomingBounceData sonicBounceStorm;
        [FieldOffset(0x68)] public PlayerParamHomingBounceData sonicBounceStormSwirl;
        [FieldOffset(0x88)] public PlayerParamHomingBounceData supersonicBounce;
        [FieldOffset(0xA8)] public float cameraEaseInTime;
        [FieldOffset(0xAC)] public float cameraEaseOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamHitEnemy
    {
        [FieldOffset(0x00)] public float bounceVertSpeed;
        [FieldOffset(0x04)] public float bounceHorzSpeed;
        [FieldOffset(0x08)] public float attackDownTime;
        [FieldOffset(0x0C)] public float enableHomingTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct SpeedParam
    {
        [FieldOffset(0x00)] public float maxVertSpeed;
        [FieldOffset(0x04)] public float acceleVertForce;
        [FieldOffset(0x08)] public float maxHorzSpeed;
        [FieldOffset(0x0C)] public float acceleHorzForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x5C)]
    public struct PlayerParamDiving
    {
        [FieldOffset(0x00)] public SpeedParam normal;
        [FieldOffset(0x10)] public SpeedParam fast;
        [FieldOffset(0x20)] public SpeedParam damaged;
        [FieldOffset(0x30)] public SpeedParam ringdash;
        [FieldOffset(0x40)] public float startHeight;
        [FieldOffset(0x44)] public float startSpeed;
        [FieldOffset(0x48)] public float deceleVertForce;
        [FieldOffset(0x4C)] public float deceleHorzForce;
        [FieldOffset(0x50)] public float deceleNeutralForce;
        [FieldOffset(0x54)] public float damageTime;
        [FieldOffset(0x58)] public float ringdashTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamFan
    {
        [FieldOffset(0x00)] public float damperV;
        [FieldOffset(0x04)] public float damperH;
        [FieldOffset(0x08)] public float accelRate;
        [FieldOffset(0x0C)] public float moveForceFV;
        [FieldOffset(0x10)] public float moveForceSV;
        [FieldOffset(0x14)] public float jumpCheckSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamBackflip
    {
        [FieldOffset(0x00)] public float jumpSpeed;
        [FieldOffset(0x04)] public float backSpeed;
        [FieldOffset(0x08)] public float downAccel;
        [FieldOffset(0x0C)] public float damperV;
        [FieldOffset(0x10)] public float damperH;
        [FieldOffset(0x14)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSlowMove
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float brake;
        [FieldOffset(0x10)] public float damageSpeed;
        [FieldOffset(0x14)] public float damageBrake;
        [FieldOffset(0x18)] public float steeringSpeed;
        [FieldOffset(0x1C)] public float endSteeringSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSpin
    {
        [FieldOffset(0x00)] public float startSlopeAngle;
        [FieldOffset(0x04)] public float endSlopeAngle;
        [FieldOffset(0x08)] public float startSpeed;
        [FieldOffset(0x0C)] public float endSpeed;
        [FieldOffset(0x10)] public float stickAngle;
        [FieldOffset(0x14)] public float brake;
        [FieldOffset(0x18)] public float forceBrake;
        [FieldOffset(0x1C)] public float maxSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x88)]
    public struct PlayerParamWallMove
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float walkSpeed;
        [FieldOffset(0x08)] public float walkSpeedMax;
        [FieldOffset(0x0C)] public float runSpeed;
        [FieldOffset(0x10)] public float runSpeedMax;
        [FieldOffset(0x14)] public float walkSpeedOnMesh;
        [FieldOffset(0x18)] public float walkSpeedOnMeshMax;
        [FieldOffset(0x1C)] public float runSpeedOnMesh;
        [FieldOffset(0x20)] public float runSpeedOnMeshMax;
        [FieldOffset(0x24)] public float minAccessSpeed;
        [FieldOffset(0x28)] public float stickSpeed;
        [FieldOffset(0x2C)] public float gravity;
        [FieldOffset(0x30)] public float accel;
        [FieldOffset(0x34)] public float brake;
        [FieldOffset(0x38)] public float stopBrake;
        [FieldOffset(0x3C)] public float fallSpeed;
        [FieldOffset(0x40)] public float steeringSpeed1;
        [FieldOffset(0x44)] public float steeringSpeed2;
        [FieldOffset(0x48)] public float startSteeringSpeed;
        [FieldOffset(0x4C)] public float endSteeringSpeed;
        [FieldOffset(0x50)] public float startTime;
        [FieldOffset(0x54)] public float useEnergySpeedBase;
        [FieldOffset(0x58)] public float useEnergySpeedBaseOnMesh;
        [FieldOffset(0x5C)] public float useEnergySpeedVal;
        [FieldOffset(0x60)] public float useEnergySpeedValOnMesh;
        [FieldOffset(0x64)] public float useEnergyAngle;
        [FieldOffset(0x68)] public float useEnergyAngleOnMesh;
        [FieldOffset(0x6C)] public float brakeStartEnergy;
        [FieldOffset(0x70)] public float brakeStartEnergyOnMesh;
        [FieldOffset(0x74)] public float homingSearchDistanceNear;
        [FieldOffset(0x78)] public float homingSearchDistanceFar;
        [FieldOffset(0x7C)] public float wallBumpHeightUpper;
        [FieldOffset(0x80)] public float wallBumpHeightUnder;
        [FieldOffset(0x84)] public float recoveryCheckTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct PlayerParamWallJump
    {
        [FieldOffset(0x00)] public float gravitySize;
        [FieldOffset(0x04)] public float minTime;
        [FieldOffset(0x08)] public float maxTime;
        [FieldOffset(0x0C)] public float stopTime;
        [FieldOffset(0x10)] public float maxDownSpeed;
        [FieldOffset(0x14)] public float fallGroundDistance;
        [FieldOffset(0x18)] public float frontForce;
        [FieldOffset(0x1C)] public float upForce;
        [FieldOffset(0x20)] public float impulseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x54)]
    public struct PlayerParamClimbing
    {
        [FieldOffset(0x00)] public float stepSpeedFront;
        [FieldOffset(0x04)] public float stepSpeedFrontDash;
        [FieldOffset(0x08)] public float stepSpeedSide;
        [FieldOffset(0x0C)] public float stepSpeedSideDash;
        [FieldOffset(0x10)] public float stepSpeedBack;
        [FieldOffset(0x14)] public float stepDashRate;
        [FieldOffset(0x18)] public float maxAnimSpeed;
        [FieldOffset(0x1C)] public float exhaustAngle;
        [FieldOffset(0x20)] public float exhaustAngleOnMesh;
        [FieldOffset(0x24)] public float exhaustBase;
        [FieldOffset(0x28)] public float exhaustBaseOnMesh;
        [FieldOffset(0x2C)] public float exhaustRate;
        [FieldOffset(0x30)] public float exhaustRateOnMesh;
        [FieldOffset(0x34)] public float useGrabGaugeSpeed;
        [FieldOffset(0x38)] public float useGrabGaugeSpeedOnMesh;
        [FieldOffset(0x3C)] public float useGrabGaugeTurbo;
        [FieldOffset(0x40)] public float useGrabGaugeTurboOnMesh;
        [FieldOffset(0x44)] public float homingSearchDistanceNear;
        [FieldOffset(0x48)] public float homingSearchDistanceFar;
        [FieldOffset(0x4C)] public float resetAngle;
        [FieldOffset(0x50)] public float recoveryCheckTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamSlideDown
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float speedOnMesh;
        [FieldOffset(0x0C)] public float accel;
        [FieldOffset(0x10)] public float brake;
        [FieldOffset(0x14)] public float brakeOnMesh;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct PlayerParamBoost
    {
        [FieldOffset(0x00)] public float consumptionRate;
        [FieldOffset(0x04)] public float consumptionRateSS;
        [FieldOffset(0x08)] public float recoveryRate;
        [FieldOffset(0x0C)] public float recoveryRateSS;
        [FieldOffset(0x10)] public float reigniteRatio;
        [FieldOffset(0x14)] public float recoveryByRing;
        [FieldOffset(0x18)] public float recoveryByAttack;
        [FieldOffset(0x1C)] public float blurPowers__arr0;
        [FieldOffset(0x20)] public float blurPowers__arr1;
        [FieldOffset(0x24)] public float blurPowers__arr2;
        [FieldOffset(0x28)] public float blurEaseInTime;
        [FieldOffset(0x2C)] public float blurEaseOutTime;
        [FieldOffset(0x30)] public float endSpeed;
        [FieldOffset(0x34)] public float powerBoostCoolTime;
        [FieldOffset(0x38)] public float infinityBoostTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct PlayerParamAirBoost
    {
        [FieldOffset(0x00)] public float startHSpeed;
        [FieldOffset(0x04)] public float startHSpeedMax;
        [FieldOffset(0x08)] public float startVSpeed;
        [FieldOffset(0x0C)] public float minHSpeed;
        [FieldOffset(0x10)] public float minHSpeedMax;
        [FieldOffset(0x14)] public float brakeTime;
        [FieldOffset(0x18)] public float minKeepTime;
        [FieldOffset(0x1C)] public float maxKeepTime;
        [FieldOffset(0x20)] public float maxTime;
        [FieldOffset(0x24)] public float gravityRate;
        [FieldOffset(0x28)] public float steeringSpeed;
        [FieldOffset(0x2C)] public float additionalTransitTime;
        [FieldOffset(0x30)] public float supersonicTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamAutorun
    {
        [FieldOffset(0x00)] public float initialSideSpeed;
        [FieldOffset(0x04)] public float acceleSideForce;
        [FieldOffset(0x08)] public float deceleSideForce;
        [FieldOffset(0x0C)] public float maxSideSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSideStep
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float brakeForce;
        [FieldOffset(0x08)] public float motionSpeedRatio;
        [FieldOffset(0x0C)] public float stepSpeed;
        [FieldOffset(0x10)] public float maxStepDistance;
        [FieldOffset(0x14)] public float minStepDistance;
        [FieldOffset(0x18)] public float maxStepSpeed;
        [FieldOffset(0x1C)] public float minStepSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSideStep2
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float brakeForce;
        [FieldOffset(0x08)] public float motionSpeedRatio;
        [FieldOffset(0x0C)] public float stepSpeed;
        [FieldOffset(0x10)] public float maxStepDistance;
        [FieldOffset(0x14)] public float minStepDistance;
        [FieldOffset(0x18)] public float maxStepSpeed;
        [FieldOffset(0x1C)] public float minStepSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct PlayerParamQuickStep
    {
        [FieldOffset(0x00)] public float needSpeed;
        [FieldOffset(0x04)] public float acceleForce;
        [FieldOffset(0x08)] public float acceleSideForce;
        [FieldOffset(0x0C)] public float stepInitialSpeed;
        [FieldOffset(0x10)] public float avoidForce;
        [FieldOffset(0x14)] public float justBoostForce;
        [FieldOffset(0x18)] public float justBoostMax;
        [FieldOffset(0x1C)] public float justBoostTime;
        [FieldOffset(0x20)] public float justBoostBrake;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct PlayerParamParry
    {
        [FieldOffset(0x00)] public float minRecieveTime;
        [FieldOffset(0x04)] public float maxRecieveTimes__arr0;
        [FieldOffset(0x08)] public float maxRecieveTimes__arr1;
        [FieldOffset(0x0C)] public float maxRecieveTimes__arr2;
        [FieldOffset(0x10)] public float maxRecieveTimes__arr3;
        [FieldOffset(0x14)] public float justRecieveTimes__arr0;
        [FieldOffset(0x18)] public float justRecieveTimes__arr1;
        [FieldOffset(0x1C)] public float justRecieveTimes__arr2;
        [FieldOffset(0x20)] public float justRecieveTimes__arr3;
        [FieldOffset(0x24)] public float frozenTime;
        [FieldOffset(0x28)] public float justFrozenTime;
        [FieldOffset(0x2C)] public float justEffectEasein;
        [FieldOffset(0x30)] public float justEffectEaseout;
        [FieldOffset(0x34)] public float justEffectTime;
        [FieldOffset(0x38)] public float justEffectEasein2;
        [FieldOffset(0x3C)] public float justEffectEaseout2;
        [FieldOffset(0x40)] public float justEffectTime2;
        [FieldOffset(0x44)] public float justEffectEasein3;
        [FieldOffset(0x48)] public float justEffectEaseout3;
        [FieldOffset(0x4C)] public float justEffectTime3;
        [FieldOffset(0x50)] public UnmanagedString cameraName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamAvoidData
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float damper;
        [FieldOffset(0x08)] public float parryTime;
        [FieldOffset(0x0C)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x94)]
    public struct PlayerParamAvoid
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float fixedTime;
        [FieldOffset(0x08)] public float reentryInputPriorityTime;
        [FieldOffset(0x0C)] public float reentryTime;
        [FieldOffset(0x10)] public float frontAngle;
        [FieldOffset(0x14)] public float backAngle;
        [FieldOffset(0x18)] public float addFallSpeed;
        [FieldOffset(0x1C)] public PlayerParamAvoidData data__arr0;
        [FieldOffset(0x2C)] public PlayerParamAvoidData data__arr1;
        [FieldOffset(0x3C)] public PlayerParamAvoidData data__arr2;
        [FieldOffset(0x4C)] public PlayerParamAvoidData data__arr3;
        [FieldOffset(0x5C)] public PlayerParamAvoidData data__arr4;
        [FieldOffset(0x6C)] public PlayerParamAvoidData data__arr5;
        [FieldOffset(0x7C)] public PlayerParamAvoidData data__arr6;
        [FieldOffset(0x8C)] public float baseDistance;
        [FieldOffset(0x90)] public float limitAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x8F0)]
    public struct ModePackage
    {
        [FieldOffset(0x00)] public PlayerParamCommon common;
        [FieldOffset(0x30)] public PlayerParamSpeed speed;
        [FieldOffset(0x110)] public PlayerParamRotation rotation;
        [FieldOffset(0x13C)] public PlayerParamRunning running;
        [FieldOffset(0x170)] public PlayerParamBalance balance;
        [FieldOffset(0x190)] public PlayerParamBrake brake;
        [FieldOffset(0x1A8)] public PlayerParamTurn turn;
        [FieldOffset(0x1B8)] public PlayerParamJump jump;
        [FieldOffset(0x1D4)] public PlayerParamJumpSpeed jumpSpeed;
        [FieldOffset(0x204)] public PlayerParamDoubleJump doubleJump;
        [FieldOffset(0x210)] public PlayerParamFall fall;
        [FieldOffset(0x240)] public PlayerParamDamage damage;
        [FieldOffset(0x320)] public PlayerParamDead dead;
        [FieldOffset(0x32C)] public PlayerParamSliding sliding;
        [FieldOffset(0x36C)] public PlayerParamStomping stomping;
        [FieldOffset(0x38C)] public PlayerParamGrind grind;
        [FieldOffset(0x3A0)] public PlayerParamFallSlope fallSlope;
        [FieldOffset(0x3D8)] public PlayerParamFallFlip fallFlip;
        [FieldOffset(0x3E4)] public PlayerParamTumble tumble;
        [FieldOffset(0x44C)] public PlayerParamSpinAttack spinAttack;
        [FieldOffset(0x46C)] public PlayerParamHomingAttack homingAttack;
        [FieldOffset(0x51C)] public PlayerParamHitEnemy hitEnemy;
        [FieldOffset(0x52C)] public PlayerParamDiving diving;
        [FieldOffset(0x588)] public PlayerParamFan fan;
        [FieldOffset(0x5A0)] public PlayerParamBackflip backflip;
        [FieldOffset(0x5B8)] public PlayerParamSlowMove slowmove;
        [FieldOffset(0x5D8)] public PlayerParamSpin spin;
        [FieldOffset(0x5F8)] public PlayerParamWallMove wallmove;
        [FieldOffset(0x680)] public PlayerParamWallJump walljump;
        [FieldOffset(0x6A4)] public PlayerParamClimbing climbing;
        [FieldOffset(0x6F8)] public PlayerParamSlideDown slidedown;
        [FieldOffset(0x710)] public PlayerParamBoost boost;
        [FieldOffset(0x74C)] public PlayerParamAirBoost airboost;
        [FieldOffset(0x780)] public PlayerParamAutorun autorun;
        [FieldOffset(0x790)] public PlayerParamSideStep sidestep;
        [FieldOffset(0x7B0)] public PlayerParamSideStep2 sidestep2;
        [FieldOffset(0x7D0)] public PlayerParamQuickStep quickstep;
        [FieldOffset(0x7F8)] public PlayerParamParry parry;
        [FieldOffset(0x858)] public PlayerParamAvoid avoid;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct AmyParamPropellerJump
    {
        [FieldOffset(0x00)] public float initialSpeed;
        [FieldOffset(0x04)] public float bounceSpeed;
        [FieldOffset(0x08)] public float limitSpeedMin;
        [FieldOffset(0x0C)] public float riseDampingStartTime;
        [FieldOffset(0x10)] public float riseDampingRate;
        [FieldOffset(0x14)] public float maxFallSpeed;
        [FieldOffset(0x18)] public float fallGravitySize;
        [FieldOffset(0x1C)] public float minDuration;
        [FieldOffset(0x20)] public float propellerVertSpeedThreshold;
        [FieldOffset(0x24)] public bool holdTransitHover;
        [FieldOffset(0x28)] public float practiceTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct AmyParamStomping
    {
        [FieldOffset(0x00)] public float landAttackScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct AmyParamHighJump
    {
        [FieldOffset(0x00)] public float jumpForce;
        [FieldOffset(0x04)] public float longPressTime;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct PlayerParamAttackCollider
    {
        [FieldOffset(0x00)] public Condition condition;
        [FieldOffset(0x01)] public sbyte count;
        [FieldOffset(0x04)] public float spanTime;
        [FieldOffset(0x08)] public Shape shape;
        [FieldOffset(0x10)] public Vector3 shapeSize;
        [FieldOffset(0x20)] public Vector3 shapeOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct AmyParamTarotAttackSpeed
    {
        [FieldOffset(0x00)] public float initial;
        [FieldOffset(0x04)] public float min;
        [FieldOffset(0x08)] public float max;
        [FieldOffset(0x0C)] public float minTurn;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct AmyParamTarotAttack
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
        [FieldOffset(0x30)] public PlayerParamAttackCollider rollingHit;
        [FieldOffset(0x60)] public AmyParamTarotAttackSpeed speed;
        [FieldOffset(0x70)] public AmyParamTarotAttackSpeed speedRingMax;
        [FieldOffset(0x80)] public float speedEaseInTime;
        [FieldOffset(0x84)] public float speedEaseOutTime;
        [FieldOffset(0x88)] public float minSpeedScale;
        [FieldOffset(0x8C)] public float longPressTime;
        [FieldOffset(0x90)] public float minRollingTime;
        [FieldOffset(0x94)] public float rollingTime;
        [FieldOffset(0x98)] public float stunTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct AmyParamCyHammer
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float effectTime;
        [FieldOffset(0x08)] public float rotateCycleTime;
        [FieldOffset(0x10)] public UnmanagedString cameraShakeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct AmyParamAirCyHammer
    {
        [FieldOffset(0x00)] public float acceleForce;
        [FieldOffset(0x04)] public float deceleForce;
        [FieldOffset(0x08)] public float overSpeedDeceleForce;
        [FieldOffset(0x0C)] public float rotationForce;
        [FieldOffset(0x10)] public float rotationForceDecaySpeed;
        [FieldOffset(0x14)] public float rotationForceDecayRate;
        [FieldOffset(0x18)] public float rotationForceDecayMax;
        [FieldOffset(0x1C)] public float groundRadius;
        [FieldOffset(0x20)] public UnmanagedString cameraShakeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x78)]
    public struct AmyParamCyHammerAppearGimmick
    {
        [FieldOffset(0x00)] public float appearWaitTime;
        [FieldOffset(0x04)] public CyloopDropItemParameter dropItem;
        [FieldOffset(0x6C)] public float airCyHammerBonusScale;
        [FieldOffset(0x70)] public float airCyHammerMinBonusDistance;
        [FieldOffset(0x74)] public float airCyHammerMaxBonusDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct AmyParamTarotBoostSpeed
    {
        [FieldOffset(0x00)] public float buildInitialSpeed;
        [FieldOffset(0x04)] public float buildMinSpeed;
        [FieldOffset(0x08)] public float buildMaxSpeed;
        [FieldOffset(0x0C)] public float buildAirRotationForce;
        [FieldOffset(0x10)] public float initialSpeed;
        [FieldOffset(0x14)] public float maxSpeed;
        [FieldOffset(0x18)] public PlayerParamSpeedAcceleData accele;
        [FieldOffset(0x2C)] public PlayerParamSpeedAcceleData decele;
        [FieldOffset(0x40)] public float baseRotateForce;
        [FieldOffset(0x44)] public float minTurnSpeed;
        [FieldOffset(0x48)] public float turnDeceleAngleMin;
        [FieldOffset(0x4C)] public float turnDeceleAngleMax;
    }

    public enum AirAccelMode : sbyte
    {
        Alawys = 0,
        AirAccelMode_None = 1,
        Speed = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct AmyParamTarotTurnCamera
    {
        [FieldOffset(0x00)] public float minDistance;
        [FieldOffset(0x04)] public float maxDistance;
        [FieldOffset(0x08)] public float followTime;
        [FieldOffset(0x0C)] public float easeInTime;
        [FieldOffset(0x10)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB4)]
    public struct AmyParamTarotBoost
    {
        [FieldOffset(0x00)] public float prepareTime;
        [FieldOffset(0x04)] public float initialRunTime;
        [FieldOffset(0x08)] public AmyParamTarotBoostSpeed speed;
        [FieldOffset(0x58)] public float gravitySize;
        [FieldOffset(0x5C)] public float gravityBeginTime;
        [FieldOffset(0x60)] public float gravityMaxTime;
        [FieldOffset(0x64)] public float gravitySizeMinInAir;
        [FieldOffset(0x68)] public float gravitySizeMaxInAir;
        [FieldOffset(0x6C)] public float maxGravityAccele;
        [FieldOffset(0x70)] public float maxGravityDecele;
        [FieldOffset(0x74)] public float jumpOutAngle;
        [FieldOffset(0x78)] public float jumpOutSpeed;
        [FieldOffset(0x7C)] public bool humpJumpOut;
        [FieldOffset(0x7D)] public AirAccelMode airAccelMode;
        [FieldOffset(0x80)] public float airAccelVertSpeedThreshold;
        [FieldOffset(0x84)] public float quickTurnTime;
        [FieldOffset(0x88)] public float quickTurnThresholdSpeed;
        [FieldOffset(0x8C)] public float quickTurnThresholdAngle;
        [FieldOffset(0x90)] public float quickTurnTurnAfterSpeed;
        [FieldOffset(0x94)] public bool quickTurnStopEdge;
        [FieldOffset(0x98)] public float stompingLimitHeight;
        [FieldOffset(0x9C)] public float stompingLimitJumpOutTime;
        [FieldOffset(0xA0)] public AmyParamTarotTurnCamera cameraTurn;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct AmyParamTarotDriftCamera
    {
        [FieldOffset(0x00)] public float fovy;
        [FieldOffset(0x04)] public float zRot;
        [FieldOffset(0x08)] public float distance;
        [FieldOffset(0x0C)] public float angleLerpFactorPerSec;
        [FieldOffset(0x10)] public float azimuthOffset;
        [FieldOffset(0x14)] public float elevationOffset;
        [FieldOffset(0x18)] public float gravityOffset;
        [FieldOffset(0x1C)] public float maxAzimuthOffset;
        [FieldOffset(0x20)] public float maxHorzOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x64)]
    public struct AmyParamTarotDrift
    {
        [FieldOffset(0x00)] public float startAngle;
        [FieldOffset(0x04)] public float endSpeed;
        [FieldOffset(0x08)] public float minSpeed;
        [FieldOffset(0x0C)] public float minSpeedMax;
        [FieldOffset(0x10)] public float maxSpeed;
        [FieldOffset(0x14)] public float maxSpeedMax;
        [FieldOffset(0x18)] public float accel;
        [FieldOffset(0x1C)] public float brake;
        [FieldOffset(0x20)] public float maxSteerAngle;
        [FieldOffset(0x24)] public float steerAccel;
        [FieldOffset(0x28)] public float maxSteerSpeed;
        [FieldOffset(0x2C)] public float neutralSteerAccel;
        [FieldOffset(0x30)] public float maxNeutralSteerSpeed;
        [FieldOffset(0x34)] public float maxRotateSpeed;
        [FieldOffset(0x38)] public bool steerFixedInput;
        [FieldOffset(0x3C)] public float driftDashTime;
        [FieldOffset(0x40)] public AmyParamTarotDriftCamera camera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct AmyParamBlowKissCamera
    {
        [FieldOffset(0x00)] public float playerUpOffset;
        [FieldOffset(0x04)] public float playerRightOffset;
        [FieldOffset(0x08)] public float distance;
        [FieldOffset(0x0C)] public float targetDistance;
        [FieldOffset(0x10)] public float distanceEaseTime;
        [FieldOffset(0x14)] public float azimuth;
        [FieldOffset(0x18)] public float elevation;
        [FieldOffset(0x1C)] public float easeInTime;
        [FieldOffset(0x20)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct AmyParamHeartBreakCamera
    {
        [FieldOffset(0x00)] public float distanceToPlayer;
        [FieldOffset(0x04)] public float azimuthOffset;
        [FieldOffset(0x08)] public float elevationOffset;
        [FieldOffset(0x0C)] public float easeInTime;
        [FieldOffset(0x10)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x88)]
    public struct AmyParamCharmAttack
    {
        [FieldOffset(0x00)] public float lockonLevelUpSpanTime__arr0;
        [FieldOffset(0x04)] public float lockonLevelUpSpanTime__arr1;
        [FieldOffset(0x08)] public float lockonLevelUpSpanTime__arr2;
        [FieldOffset(0x0C)] public float lockonLevelUpSpanTime__arr3;
        [FieldOffset(0x10)] public float lockonLevelUpSpanTime__arr4;
        [FieldOffset(0x14)] public float lockonSearchDistance;
        [FieldOffset(0x18)] public float lockonSearchDistanceFar;
        [FieldOffset(0x1C)] public float speed;
        [FieldOffset(0x20)] public float followSpeed;
        [FieldOffset(0x24)] public float followTime;
        [FieldOffset(0x28)] public float chargeTime;
        [FieldOffset(0x2C)] public float moveTime;
        [FieldOffset(0x30)] public float preDamageTime;
        [FieldOffset(0x34)] public float damageSpanTime;
        [FieldOffset(0x38)] public float postDamageTime;
        [FieldOffset(0x40)] public UnmanagedString hitStopObject;
        [FieldOffset(0x50)] public AmyParamBlowKissCamera camera;
        [FieldOffset(0x74)] public AmyParamHeartBreakCamera cameraHeartBreak;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamSpinBoostSpeed
    {
        [FieldOffset(0x00)] public float initialSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public PlayerParamSpeedAcceleData accele;
        [FieldOffset(0x1C)] public PlayerParamSpeedAcceleData decele;
        [FieldOffset(0x30)] public float baseRotateForce;
        [FieldOffset(0x34)] public float minTurnSpeed;
        [FieldOffset(0x38)] public float turnDeceleAngleMin;
        [FieldOffset(0x3C)] public float turnDeceleAngleMax;
    }

    public enum PlayerParamSpinBoost_AirAccelMode : sbyte
    {
        PlayerParamSpinBoost_AirAccelMode_Alawys = 0,
        PlayerParamSpinBoost_AirAccelMode_None = 1,
        PlayerParamSpinBoost_AirAccelMode_Speed = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xF8)]
    public struct PlayerParamSpinBoost
    {
        [FieldOffset(0x00)] public float forceRunTime;
        [FieldOffset(0x04)] public float initialRunTime;
        [FieldOffset(0x08)] public PlayerParamSpinBoostSpeed speedBall;
        [FieldOffset(0x48)] public PlayerParamSpinBoostSpeed speedBoost;
        [FieldOffset(0x88)] public PlayerParamSpeedAcceleData2 deceleNeutralMin;
        [FieldOffset(0x98)] public PlayerParamSpeedAcceleData2 deceleNeutralMax;
        [FieldOffset(0xA8)] public float gravitySize;
        [FieldOffset(0xAC)] public float gravityBeginTime;
        [FieldOffset(0xB0)] public float gravityMaxTime;
        [FieldOffset(0xB4)] public float gravitySizeMinInAir;
        [FieldOffset(0xB8)] public float gravitySizeMaxInAir;
        [FieldOffset(0xBC)] public float maxGravityAccele;
        [FieldOffset(0xC0)] public float maxGravityDecele;
        [FieldOffset(0xC4)] public float inAirTime;
        [FieldOffset(0xC8)] public float spinBoostEndSpeed;
        [FieldOffset(0xCC)] public float jumpOutAngle;
        [FieldOffset(0xD0)] public float jumpOutSpeed;
        [FieldOffset(0xD4)] public bool humpJumpOut;
        [FieldOffset(0xD5)] public PlayerParamSpinBoost_AirAccelMode airAccelMode;
        [FieldOffset(0xD8)] public float airAccelVertSpeedThreshold;
        [FieldOffset(0xDC)] public float chargeRotateForce;
        [FieldOffset(0xE0)] public float chargeRotateForceMinAngle;
        [FieldOffset(0xE4)] public float chargeRotateForceMaxAngle;
        [FieldOffset(0xE8)] public UnmanagedString cameraShakeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xD30)]
    public struct ModePackageAmy
    {
        [FieldOffset(0)]    public ModePackage modePackage;
        [FieldOffset(0x8F0)] public AmyParamPropellerJump propellerJump;
        [FieldOffset(0x91C)] public AmyParamStomping stomping;
        [FieldOffset(0x920)] public AmyParamHighJump highJump;
        [FieldOffset(0x930)] public AmyParamTarotAttack tarotAttack;
        [FieldOffset(0x9D0)] public AmyParamCyHammer cyHammer;
        [FieldOffset(0x9F0)] public AmyParamAirCyHammer airCyHammer;
        [FieldOffset(0xA20)] public AmyParamCyHammerAppearGimmick cyHammerAppearGimmick;
        [FieldOffset(0xA98)] public AmyParamTarotBoost tarotBoost;
        [FieldOffset(0xB4C)] public AmyParamTarotDrift tarotDrift;
        [FieldOffset(0xBB0)] public AmyParamCharmAttack charmAttack;
        [FieldOffset(0xC38)] public PlayerParamSpinBoost spinBoost;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1A8)]
    public struct WaterModePackage
    {
        [FieldOffset(0x00)] public PlayerParamSpeed speed;
        [FieldOffset(0xE0)] public PlayerParamJump jump;
        [FieldOffset(0xFC)] public PlayerParamJumpSpeed jumpSpeed;
        [FieldOffset(0x12C)] public PlayerParamDoubleJump doubleJump;
        [FieldOffset(0x138)] public PlayerParamBoost boost;
        [FieldOffset(0x174)] public PlayerParamAirBoost airboost;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x7ED0)]
    public struct AmyParameters
    {
        [FieldOffset(0x00)] public CommonPackageAmy common;
        [FieldOffset(0x62C0)] public ModePackageAmy forwardView;
        [FieldOffset(0x6FF0)] public WaterModePackage water;
        [FieldOffset(0x71A0)] public ModePackageAmy cyberspaceSV;
    }

}