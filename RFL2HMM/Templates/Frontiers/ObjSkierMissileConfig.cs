using System.Numerics;
using System.Runtime.InteropServices;

public class ObjSkierMissileConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct ObjSkierMissileConfig
    {
        [FieldOffset(0x00)] public float colliderHeight;
        [FieldOffset(0x04)] public float colliderRadius;
        [FieldOffset(0x10)] public Vector3 colliderOffset;
        [FieldOffset(0x20)] public float explodeRadius;
        [FieldOffset(0x24)] public float distanceStartCurve;
        [FieldOffset(0x28)] public float distanceEndCurve;
        [FieldOffset(0x2C)] public float inducedExplosionTimePerDistance;
    }

}