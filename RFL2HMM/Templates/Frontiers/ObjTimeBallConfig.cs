using System.Numerics;
using System.Runtime.InteropServices;

public class ObjTimeBallConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct CollisionConfig
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float friction;
        [FieldOffset(0x08)] public float restitution;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct CorrectionsConfig
    {
        [FieldOffset(0x00)] public float CorrectionsMaxDistance;
        [FieldOffset(0x04)] public float CorrectionsMinDistance;
        [FieldOffset(0x08)] public float CorrectionsAngle;
        [FieldOffset(0x0C)] public float CorrectionsRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct ObjTimeBallConfig
    {
        [FieldOffset(0x00)] public float mass;
        [FieldOffset(0x04)] public float linearDamping;
        [FieldOffset(0x08)] public float angularDamping;
        [FieldOffset(0x0C)] public float maxLinearVelocity;
        [FieldOffset(0x10)] public float maxLinearAcceleration;
        [FieldOffset(0x14)] public float linearVelocityTimes;
        [FieldOffset(0x18)] public float gravity;
        [FieldOffset(0x1C)] public CollisionConfig collisionConfig;
        [FieldOffset(0x28)] public CorrectionsConfig correctionsConfig;
    }

}