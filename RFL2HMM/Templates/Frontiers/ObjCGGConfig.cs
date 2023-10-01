using System.Numerics;
using System.Runtime.InteropServices;

public class ObjCGGConfigClass
{
    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct RailCameraParam
    {
        [FieldOffset(0x00)] public float yOffset;
        [FieldOffset(0x04)] public float cameraElevation;
        [FieldOffset(0x08)] public float cameraDistance;
        [FieldOffset(0x0C)] public float cameraFovy;
        [FieldOffset(0x10)] public float radius;
        [FieldOffset(0x14)] public float cameraLookAtPointOffsetY;
        [FieldOffset(0x18)] public float cameraDegreeForClockwiseMovement;
        [FieldOffset(0x1C)] public float cameraDegreeForCounterClockwiseMovement;
        [FieldOffset(0x20)] public float cameraMaxChangeableDegreeByStickInput;
        [FieldOffset(0x24)] public float cameraMaxDegreeChangedByStickInputPerSec;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct ObjCGGRootConfig
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x10)] public Vector3 offset;
        [FieldOffset(0x20)] public Color8 colorActive;
        [FieldOffset(0x24)] public Color8 colorDeactive;
        [FieldOffset(0x28)] public float timerHeightOffset;
        [FieldOffset(0x2C)] public RailCameraParam twoRailCamera;
        [FieldOffset(0x54)] public RailCameraParam threeRailCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct ObjCGGBulletNormalConfig
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public Color8 color;
        [FieldOffset(0x08)] public float speed;
        [FieldOffset(0x0C)] public float waitFollowTime;
        [FieldOffset(0x10)] public float followTime;
        [FieldOffset(0x14)] public float waitKillTime;
        [FieldOffset(0x18)] public float radiusBulletCircle;
        [FieldOffset(0x1C)] public float followLimitAngleHorizontal;
        [FieldOffset(0x20)] public float followLimitAngleVertical;
        [FieldOffset(0x24)] public float rotateDeceleration;
        [FieldOffset(0x28)] public float muzzuleEffectLoopTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct ObjCGGResetBindConfig
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public Color8 color;
        [FieldOffset(0x08)] public float timeToReachTimer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct ObjCGGLaserConfig
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float heightInterval;
        [FieldOffset(0x08)] public Color8 color;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct ObjCGGAttachmentConfig
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public Color8 color;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xD0)]
    public struct ObjCGGConfig
    {
        [FieldOffset(0x00)] public ObjCGGRootConfig root;
        [FieldOffset(0x80)] public ObjCGGBulletNormalConfig bulletNormal;
        [FieldOffset(0xAC)] public ObjCGGResetBindConfig resetBind;
        [FieldOffset(0xB8)] public ObjCGGLaserConfig laser;
        [FieldOffset(0xC4)] public ObjCGGAttachmentConfig attachment;
    }

}