using System.Numerics;
using System.Runtime.InteropServices;

public class UIMapParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct ChallengeID1DimParameter
    {
        [FieldOffset(0x00)] public int challengeID__arr0;
        [FieldOffset(0x04)] public int challengeID__arr1;
        [FieldOffset(0x08)] public int challengeID__arr2;
        [FieldOffset(0x0C)] public int challengeID__arr3;
        [FieldOffset(0x10)] public int challengeID__arr4;
        [FieldOffset(0x14)] public int challengeID__arr5;
        [FieldOffset(0x18)] public int challengeID__arr6;
        [FieldOffset(0x1C)] public int challengeID__arr7;
        [FieldOffset(0x20)] public int challengeID__arr8;
        [FieldOffset(0x24)] public int challengeID__arr9;
        [FieldOffset(0x28)] public int challengeID__arr10;
        [FieldOffset(0x2C)] public int challengeID__arr11;
        [FieldOffset(0x30)] public int challengeID__arr12;
        [FieldOffset(0x34)] public int challengeID__arr13;
        [FieldOffset(0x38)] public int challengeID__arr14;
        [FieldOffset(0x3C)] public int challengeID__arr15;
        [FieldOffset(0x40)] public int challengeID__arr16;
        [FieldOffset(0x44)] public int challengeID__arr17;
        [FieldOffset(0x48)] public int challengeID__arr18;
        [FieldOffset(0x4C)] public int challengeID__arr19;
        [FieldOffset(0x50)] public int challengeID__arr20;
        [FieldOffset(0x54)] public int challengeID__arr21;
        [FieldOffset(0x58)] public int challengeID__arr22;
        [FieldOffset(0x5C)] public int challengeID__arr23;
        [FieldOffset(0x60)] public int challengeID__arr24;
        [FieldOffset(0x64)] public int challengeID__arr25;
        [FieldOffset(0x68)] public int challengeID__arr26;
        [FieldOffset(0x6C)] public int challengeID__arr27;
        [FieldOffset(0x70)] public int challengeID__arr28;
        [FieldOffset(0x74)] public int challengeID__arr29;
        [FieldOffset(0x78)] public int challengeID__arr30;
        [FieldOffset(0x7C)] public int challengeID__arr31;
        [FieldOffset(0x80)] public int challengeID__arr32;
        [FieldOffset(0x84)] public int challengeID__arr33;
        [FieldOffset(0x88)] public int challengeID__arr34;
        [FieldOffset(0x8C)] public int challengeID__arr35;
        [FieldOffset(0x90)] public int challengeID__arr36;
        [FieldOffset(0x94)] public int challengeID__arr37;
        [FieldOffset(0x98)] public int challengeID__arr38;
        [FieldOffset(0x9C)] public int challengeID__arr39;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1900)]
    public struct IslandMapParameter
    {
        [FieldOffset(0x00)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr0;
        [FieldOffset(0xA0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr1;
        [FieldOffset(0x140)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr2;
        [FieldOffset(0x1E0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr3;
        [FieldOffset(0x280)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr4;
        [FieldOffset(0x320)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr5;
        [FieldOffset(0x3C0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr6;
        [FieldOffset(0x460)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr7;
        [FieldOffset(0x500)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr8;
        [FieldOffset(0x5A0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr9;
        [FieldOffset(0x640)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr10;
        [FieldOffset(0x6E0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr11;
        [FieldOffset(0x780)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr12;
        [FieldOffset(0x820)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr13;
        [FieldOffset(0x8C0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr14;
        [FieldOffset(0x960)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr15;
        [FieldOffset(0xA00)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr16;
        [FieldOffset(0xAA0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr17;
        [FieldOffset(0xB40)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr18;
        [FieldOffset(0xBE0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr19;
        [FieldOffset(0xC80)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr20;
        [FieldOffset(0xD20)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr21;
        [FieldOffset(0xDC0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr22;
        [FieldOffset(0xE60)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr23;
        [FieldOffset(0xF00)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr24;
        [FieldOffset(0xFA0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr25;
        [FieldOffset(0x1040)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr26;
        [FieldOffset(0x10E0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr27;
        [FieldOffset(0x1180)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr28;
        [FieldOffset(0x1220)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr29;
        [FieldOffset(0x12C0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr30;
        [FieldOffset(0x1360)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr31;
        [FieldOffset(0x1400)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr32;
        [FieldOffset(0x14A0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr33;
        [FieldOffset(0x1540)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr34;
        [FieldOffset(0x15E0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr35;
        [FieldOffset(0x1680)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr36;
        [FieldOffset(0x1720)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr37;
        [FieldOffset(0x17C0)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr38;
        [FieldOffset(0x1860)] public ChallengeID1DimParameter challengeIDHorizonGridGroup__arr39;
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct IDColor
    {
        [FieldOffset(0x00)] public int id;
        [FieldOffset(0x04)] public Color8 color;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x9E40)]
    public struct UIMapParameter
    {
        [FieldOffset(0x00)] public IslandMapParameter islandMapParam__arr0;
        [FieldOffset(0x1900)] public IslandMapParameter islandMapParam__arr1;
        [FieldOffset(0x3200)] public IslandMapParameter islandMapParam__arr2;
        [FieldOffset(0x4B00)] public IslandMapParameter islandMapParam__arr3;
        [FieldOffset(0x6400)] public IslandMapParameter islandMapParam__arr4;
        [FieldOffset(0x7D00)] public IslandMapParameter islandMapParam__arr5;
        [FieldOffset(0x9600)] public IDColor idColors__arr0;
        [FieldOffset(0x9608)] public IDColor idColors__arr1;
        [FieldOffset(0x9610)] public IDColor idColors__arr2;
        [FieldOffset(0x9618)] public IDColor idColors__arr3;
        [FieldOffset(0x9620)] public IDColor idColors__arr4;
        [FieldOffset(0x9628)] public IDColor idColors__arr5;
        [FieldOffset(0x9630)] public IDColor idColors__arr6;
        [FieldOffset(0x9638)] public IDColor idColors__arr7;
        [FieldOffset(0x9640)] public IDColor idColors__arr8;
        [FieldOffset(0x9648)] public IDColor idColors__arr9;
        [FieldOffset(0x9650)] public IDColor idColors__arr10;
        [FieldOffset(0x9658)] public IDColor idColors__arr11;
        [FieldOffset(0x9660)] public IDColor idColors__arr12;
        [FieldOffset(0x9668)] public IDColor idColors__arr13;
        [FieldOffset(0x9670)] public IDColor idColors__arr14;
        [FieldOffset(0x9678)] public IDColor idColors__arr15;
        [FieldOffset(0x9680)] public IDColor idColors__arr16;
        [FieldOffset(0x9688)] public IDColor idColors__arr17;
        [FieldOffset(0x9690)] public IDColor idColors__arr18;
        [FieldOffset(0x9698)] public IDColor idColors__arr19;
        [FieldOffset(0x96A0)] public IDColor idColors__arr20;
        [FieldOffset(0x96A8)] public IDColor idColors__arr21;
        [FieldOffset(0x96B0)] public IDColor idColors__arr22;
        [FieldOffset(0x96B8)] public IDColor idColors__arr23;
        [FieldOffset(0x96C0)] public IDColor idColors__arr24;
        [FieldOffset(0x96C8)] public IDColor idColors__arr25;
        [FieldOffset(0x96D0)] public IDColor idColors__arr26;
        [FieldOffset(0x96D8)] public IDColor idColors__arr27;
        [FieldOffset(0x96E0)] public IDColor idColors__arr28;
        [FieldOffset(0x96E8)] public IDColor idColors__arr29;
        [FieldOffset(0x96F0)] public IDColor idColors__arr30;
        [FieldOffset(0x96F8)] public IDColor idColors__arr31;
        [FieldOffset(0x9700)] public IDColor idColors__arr32;
        [FieldOffset(0x9708)] public IDColor idColors__arr33;
        [FieldOffset(0x9710)] public IDColor idColors__arr34;
        [FieldOffset(0x9718)] public IDColor idColors__arr35;
        [FieldOffset(0x9720)] public IDColor idColors__arr36;
        [FieldOffset(0x9728)] public IDColor idColors__arr37;
        [FieldOffset(0x9730)] public IDColor idColors__arr38;
        [FieldOffset(0x9738)] public IDColor idColors__arr39;
        [FieldOffset(0x9740)] public IDColor idColors__arr40;
        [FieldOffset(0x9748)] public IDColor idColors__arr41;
        [FieldOffset(0x9750)] public IDColor idColors__arr42;
        [FieldOffset(0x9758)] public IDColor idColors__arr43;
        [FieldOffset(0x9760)] public IDColor idColors__arr44;
        [FieldOffset(0x9768)] public IDColor idColors__arr45;
        [FieldOffset(0x9770)] public IDColor idColors__arr46;
        [FieldOffset(0x9778)] public IDColor idColors__arr47;
        [FieldOffset(0x9780)] public IDColor idColors__arr48;
        [FieldOffset(0x9788)] public IDColor idColors__arr49;
        [FieldOffset(0x9790)] public IDColor idColors__arr50;
        [FieldOffset(0x9798)] public IDColor idColors__arr51;
        [FieldOffset(0x97A0)] public IDColor idColors__arr52;
        [FieldOffset(0x97A8)] public IDColor idColors__arr53;
        [FieldOffset(0x97B0)] public IDColor idColors__arr54;
        [FieldOffset(0x97B8)] public IDColor idColors__arr55;
        [FieldOffset(0x97C0)] public IDColor idColors__arr56;
        [FieldOffset(0x97C8)] public IDColor idColors__arr57;
        [FieldOffset(0x97D0)] public IDColor idColors__arr58;
        [FieldOffset(0x97D8)] public IDColor idColors__arr59;
        [FieldOffset(0x97E0)] public IDColor idColors__arr60;
        [FieldOffset(0x97E8)] public IDColor idColors__arr61;
        [FieldOffset(0x97F0)] public IDColor idColors__arr62;
        [FieldOffset(0x97F8)] public IDColor idColors__arr63;
        [FieldOffset(0x9800)] public IDColor idColors__arr64;
        [FieldOffset(0x9808)] public IDColor idColors__arr65;
        [FieldOffset(0x9810)] public IDColor idColors__arr66;
        [FieldOffset(0x9818)] public IDColor idColors__arr67;
        [FieldOffset(0x9820)] public IDColor idColors__arr68;
        [FieldOffset(0x9828)] public IDColor idColors__arr69;
        [FieldOffset(0x9830)] public IDColor idColors__arr70;
        [FieldOffset(0x9838)] public IDColor idColors__arr71;
        [FieldOffset(0x9840)] public IDColor idColors__arr72;
        [FieldOffset(0x9848)] public IDColor idColors__arr73;
        [FieldOffset(0x9850)] public IDColor idColors__arr74;
        [FieldOffset(0x9858)] public IDColor idColors__arr75;
        [FieldOffset(0x9860)] public IDColor idColors__arr76;
        [FieldOffset(0x9868)] public IDColor idColors__arr77;
        [FieldOffset(0x9870)] public IDColor idColors__arr78;
        [FieldOffset(0x9878)] public IDColor idColors__arr79;
        [FieldOffset(0x9880)] public IDColor idColors__arr80;
        [FieldOffset(0x9888)] public IDColor idColors__arr81;
        [FieldOffset(0x9890)] public IDColor idColors__arr82;
        [FieldOffset(0x9898)] public IDColor idColors__arr83;
        [FieldOffset(0x98A0)] public IDColor idColors__arr84;
        [FieldOffset(0x98A8)] public IDColor idColors__arr85;
        [FieldOffset(0x98B0)] public IDColor idColors__arr86;
        [FieldOffset(0x98B8)] public IDColor idColors__arr87;
        [FieldOffset(0x98C0)] public IDColor idColors__arr88;
        [FieldOffset(0x98C8)] public IDColor idColors__arr89;
        [FieldOffset(0x98D0)] public IDColor idColors__arr90;
        [FieldOffset(0x98D8)] public IDColor idColors__arr91;
        [FieldOffset(0x98E0)] public IDColor idColors__arr92;
        [FieldOffset(0x98E8)] public IDColor idColors__arr93;
        [FieldOffset(0x98F0)] public IDColor idColors__arr94;
        [FieldOffset(0x98F8)] public IDColor idColors__arr95;
        [FieldOffset(0x9900)] public IDColor idColors__arr96;
        [FieldOffset(0x9908)] public IDColor idColors__arr97;
        [FieldOffset(0x9910)] public IDColor idColors__arr98;
        [FieldOffset(0x9918)] public IDColor idColors__arr99;
        [FieldOffset(0x9920)] public IDColor idColors__arr100;
        [FieldOffset(0x9928)] public IDColor idColors__arr101;
        [FieldOffset(0x9930)] public IDColor idColors__arr102;
        [FieldOffset(0x9938)] public IDColor idColors__arr103;
        [FieldOffset(0x9940)] public IDColor idColors__arr104;
        [FieldOffset(0x9948)] public IDColor idColors__arr105;
        [FieldOffset(0x9950)] public IDColor idColors__arr106;
        [FieldOffset(0x9958)] public IDColor idColors__arr107;
        [FieldOffset(0x9960)] public IDColor idColors__arr108;
        [FieldOffset(0x9968)] public IDColor idColors__arr109;
        [FieldOffset(0x9970)] public IDColor idColors__arr110;
        [FieldOffset(0x9978)] public IDColor idColors__arr111;
        [FieldOffset(0x9980)] public IDColor idColors__arr112;
        [FieldOffset(0x9988)] public IDColor idColors__arr113;
        [FieldOffset(0x9990)] public IDColor idColors__arr114;
        [FieldOffset(0x9998)] public IDColor idColors__arr115;
        [FieldOffset(0x99A0)] public IDColor idColors__arr116;
        [FieldOffset(0x99A8)] public IDColor idColors__arr117;
        [FieldOffset(0x99B0)] public IDColor idColors__arr118;
        [FieldOffset(0x99B8)] public IDColor idColors__arr119;
        [FieldOffset(0x99C0)] public IDColor idColors__arr120;
        [FieldOffset(0x99C8)] public IDColor idColors__arr121;
        [FieldOffset(0x99D0)] public IDColor idColors__arr122;
        [FieldOffset(0x99D8)] public IDColor idColors__arr123;
        [FieldOffset(0x99E0)] public IDColor idColors__arr124;
        [FieldOffset(0x99E8)] public IDColor idColors__arr125;
        [FieldOffset(0x99F0)] public IDColor idColors__arr126;
        [FieldOffset(0x99F8)] public IDColor idColors__arr127;
        [FieldOffset(0x9A00)] public IDColor idColors__arr128;
        [FieldOffset(0x9A08)] public IDColor idColors__arr129;
        [FieldOffset(0x9A10)] public IDColor idColors__arr130;
        [FieldOffset(0x9A18)] public IDColor idColors__arr131;
        [FieldOffset(0x9A20)] public IDColor idColors__arr132;
        [FieldOffset(0x9A28)] public IDColor idColors__arr133;
        [FieldOffset(0x9A30)] public IDColor idColors__arr134;
        [FieldOffset(0x9A38)] public IDColor idColors__arr135;
        [FieldOffset(0x9A40)] public IDColor idColors__arr136;
        [FieldOffset(0x9A48)] public IDColor idColors__arr137;
        [FieldOffset(0x9A50)] public IDColor idColors__arr138;
        [FieldOffset(0x9A58)] public IDColor idColors__arr139;
        [FieldOffset(0x9A60)] public IDColor idColors__arr140;
        [FieldOffset(0x9A68)] public IDColor idColors__arr141;
        [FieldOffset(0x9A70)] public IDColor idColors__arr142;
        [FieldOffset(0x9A78)] public IDColor idColors__arr143;
        [FieldOffset(0x9A80)] public IDColor idColors__arr144;
        [FieldOffset(0x9A88)] public IDColor idColors__arr145;
        [FieldOffset(0x9A90)] public IDColor idColors__arr146;
        [FieldOffset(0x9A98)] public IDColor idColors__arr147;
        [FieldOffset(0x9AA0)] public IDColor idColors__arr148;
        [FieldOffset(0x9AA8)] public IDColor idColors__arr149;
        [FieldOffset(0x9AB0)] public IDColor idColors__arr150;
        [FieldOffset(0x9AB8)] public IDColor idColors__arr151;
        [FieldOffset(0x9AC0)] public IDColor idColors__arr152;
        [FieldOffset(0x9AC8)] public IDColor idColors__arr153;
        [FieldOffset(0x9AD0)] public IDColor idColors__arr154;
        [FieldOffset(0x9AD8)] public IDColor idColors__arr155;
        [FieldOffset(0x9AE0)] public IDColor idColors__arr156;
        [FieldOffset(0x9AE8)] public IDColor idColors__arr157;
        [FieldOffset(0x9AF0)] public IDColor idColors__arr158;
        [FieldOffset(0x9AF8)] public IDColor idColors__arr159;
        [FieldOffset(0x9B00)] public IDColor idColors__arr160;
        [FieldOffset(0x9B08)] public IDColor idColors__arr161;
        [FieldOffset(0x9B10)] public IDColor idColors__arr162;
        [FieldOffset(0x9B18)] public IDColor idColors__arr163;
        [FieldOffset(0x9B20)] public IDColor idColors__arr164;
        [FieldOffset(0x9B28)] public IDColor idColors__arr165;
        [FieldOffset(0x9B30)] public IDColor idColors__arr166;
        [FieldOffset(0x9B38)] public IDColor idColors__arr167;
        [FieldOffset(0x9B40)] public IDColor idColors__arr168;
        [FieldOffset(0x9B48)] public IDColor idColors__arr169;
        [FieldOffset(0x9B50)] public IDColor idColors__arr170;
        [FieldOffset(0x9B58)] public IDColor idColors__arr171;
        [FieldOffset(0x9B60)] public IDColor idColors__arr172;
        [FieldOffset(0x9B68)] public IDColor idColors__arr173;
        [FieldOffset(0x9B70)] public IDColor idColors__arr174;
        [FieldOffset(0x9B78)] public IDColor idColors__arr175;
        [FieldOffset(0x9B80)] public IDColor idColors__arr176;
        [FieldOffset(0x9B88)] public IDColor idColors__arr177;
        [FieldOffset(0x9B90)] public IDColor idColors__arr178;
        [FieldOffset(0x9B98)] public IDColor idColors__arr179;
        [FieldOffset(0x9BA0)] public IDColor idColors__arr180;
        [FieldOffset(0x9BA8)] public IDColor idColors__arr181;
        [FieldOffset(0x9BB0)] public IDColor idColors__arr182;
        [FieldOffset(0x9BB8)] public IDColor idColors__arr183;
        [FieldOffset(0x9BC0)] public IDColor idColors__arr184;
        [FieldOffset(0x9BC8)] public IDColor idColors__arr185;
        [FieldOffset(0x9BD0)] public IDColor idColors__arr186;
        [FieldOffset(0x9BD8)] public IDColor idColors__arr187;
        [FieldOffset(0x9BE0)] public IDColor idColors__arr188;
        [FieldOffset(0x9BE8)] public IDColor idColors__arr189;
        [FieldOffset(0x9BF0)] public IDColor idColors__arr190;
        [FieldOffset(0x9BF8)] public IDColor idColors__arr191;
        [FieldOffset(0x9C00)] public IDColor idColors__arr192;
        [FieldOffset(0x9C08)] public IDColor idColors__arr193;
        [FieldOffset(0x9C10)] public IDColor idColors__arr194;
        [FieldOffset(0x9C18)] public IDColor idColors__arr195;
        [FieldOffset(0x9C20)] public IDColor idColors__arr196;
        [FieldOffset(0x9C28)] public IDColor idColors__arr197;
        [FieldOffset(0x9C30)] public IDColor idColors__arr198;
        [FieldOffset(0x9C38)] public IDColor idColors__arr199;
        [FieldOffset(0x9C40)] public IDColor idColors__arr200;
        [FieldOffset(0x9C48)] public IDColor idColors__arr201;
        [FieldOffset(0x9C50)] public IDColor idColors__arr202;
        [FieldOffset(0x9C58)] public IDColor idColors__arr203;
        [FieldOffset(0x9C60)] public IDColor idColors__arr204;
        [FieldOffset(0x9C68)] public IDColor idColors__arr205;
        [FieldOffset(0x9C70)] public IDColor idColors__arr206;
        [FieldOffset(0x9C78)] public IDColor idColors__arr207;
        [FieldOffset(0x9C80)] public IDColor idColors__arr208;
        [FieldOffset(0x9C88)] public IDColor idColors__arr209;
        [FieldOffset(0x9C90)] public IDColor idColors__arr210;
        [FieldOffset(0x9C98)] public IDColor idColors__arr211;
        [FieldOffset(0x9CA0)] public IDColor idColors__arr212;
        [FieldOffset(0x9CA8)] public IDColor idColors__arr213;
        [FieldOffset(0x9CB0)] public IDColor idColors__arr214;
        [FieldOffset(0x9CB8)] public IDColor idColors__arr215;
        [FieldOffset(0x9CC0)] public IDColor idColors__arr216;
        [FieldOffset(0x9CC8)] public IDColor idColors__arr217;
        [FieldOffset(0x9CD0)] public IDColor idColors__arr218;
        [FieldOffset(0x9CD8)] public IDColor idColors__arr219;
        [FieldOffset(0x9CE0)] public IDColor idColors__arr220;
        [FieldOffset(0x9CE8)] public IDColor idColors__arr221;
        [FieldOffset(0x9CF0)] public IDColor idColors__arr222;
        [FieldOffset(0x9CF8)] public IDColor idColors__arr223;
        [FieldOffset(0x9D00)] public IDColor idColors__arr224;
        [FieldOffset(0x9D08)] public IDColor idColors__arr225;
        [FieldOffset(0x9D10)] public IDColor idColors__arr226;
        [FieldOffset(0x9D18)] public IDColor idColors__arr227;
        [FieldOffset(0x9D20)] public IDColor idColors__arr228;
        [FieldOffset(0x9D28)] public IDColor idColors__arr229;
        [FieldOffset(0x9D30)] public IDColor idColors__arr230;
        [FieldOffset(0x9D38)] public IDColor idColors__arr231;
        [FieldOffset(0x9D40)] public IDColor idColors__arr232;
        [FieldOffset(0x9D48)] public IDColor idColors__arr233;
        [FieldOffset(0x9D50)] public IDColor idColors__arr234;
        [FieldOffset(0x9D58)] public IDColor idColors__arr235;
        [FieldOffset(0x9D60)] public IDColor idColors__arr236;
        [FieldOffset(0x9D68)] public IDColor idColors__arr237;
        [FieldOffset(0x9D70)] public IDColor idColors__arr238;
        [FieldOffset(0x9D78)] public IDColor idColors__arr239;
        [FieldOffset(0x9D80)] public IDColor idColors__arr240;
        [FieldOffset(0x9D88)] public IDColor idColors__arr241;
        [FieldOffset(0x9D90)] public IDColor idColors__arr242;
        [FieldOffset(0x9D98)] public IDColor idColors__arr243;
        [FieldOffset(0x9DA0)] public IDColor idColors__arr244;
        [FieldOffset(0x9DA8)] public IDColor idColors__arr245;
        [FieldOffset(0x9DB0)] public IDColor idColors__arr246;
        [FieldOffset(0x9DB8)] public IDColor idColors__arr247;
        [FieldOffset(0x9DC0)] public IDColor idColors__arr248;
        [FieldOffset(0x9DC8)] public IDColor idColors__arr249;
        [FieldOffset(0x9DD0)] public IDColor idColors__arr250;
        [FieldOffset(0x9DD8)] public IDColor idColors__arr251;
        [FieldOffset(0x9DE0)] public IDColor idColors__arr252;
        [FieldOffset(0x9DE8)] public IDColor idColors__arr253;
        [FieldOffset(0x9DF0)] public IDColor idColors__arr254;
        [FieldOffset(0x9DF8)] public IDColor idColors__arr255;
        [FieldOffset(0x9E00)] public IDColor idColors__arr256;
        [FieldOffset(0x9E08)] public IDColor idColors__arr257;
        [FieldOffset(0x9E10)] public IDColor idColors__arr258;
        [FieldOffset(0x9E18)] public IDColor idColors__arr259;
        [FieldOffset(0x9E20)] public IDColor idColors__arr260;
        [FieldOffset(0x9E28)] public IDColor idColors__arr261;
        [FieldOffset(0x9E30)] public IDColor idColors__arr262;
        [FieldOffset(0x9E38)] public IDColor idColors__arr263;
    }

}