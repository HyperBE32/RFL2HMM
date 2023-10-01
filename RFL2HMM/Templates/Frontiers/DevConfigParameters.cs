using System.Numerics;
using System.Runtime.InteropServices;

public class DevConfigParametersClass
{
    public enum Value : sbyte
    {
        Invalid = -1,
        Sonic = 0,
        Amy = 1,
        Knuckles = 2,
        Tails = 3,
        Num = 4,
        Default = 0
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct DevConfigParameters
    {
        [FieldOffset(0x00)] public bool autoSaveEnabled;
        [FieldOffset(0x01)] public bool gismoEnabled;
        [FieldOffset(0x02)] public bool reportEnabled;
        [FieldOffset(0x03)] public bool skillTreeEnabled;
        [FieldOffset(0x04)] public bool tutorialEnabled;
        [FieldOffset(0x05)] public bool arcadeModeEnabled;
        [FieldOffset(0x06)] public bool battleModeEnabled;
        [FieldOffset(0x07)] public bool cyberChallengeEnabled;
        [FieldOffset(0x08)] public bool practice;
        [FieldOffset(0x09)] public bool practiceTimeLimitEnabled;
        [FieldOffset(0x0A)] public bool creditsEnabled;
        [FieldOffset(0x0B)] public Value character;
    }

}