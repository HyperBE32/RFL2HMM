using System.Numerics;
using System.Runtime.InteropServices;

public class UICreditParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct UICreditParameter
    {
        [FieldOffset(0x00)] public float LicenseInterval;
        [FieldOffset(0x04)] public float NameInterval;
        [FieldOffset(0x08)] public float PostInterval;
        [FieldOffset(0x0C)] public float CompanyInterval;
        [FieldOffset(0x10)] public float LogoInterval;
        [FieldOffset(0x14)] public float WaitTime;
    }

}