using System.Numerics;
using System.Runtime.InteropServices;

public class GameRflParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct CameraDOFRflParameter
    {
        [FieldOffset(0)]  public float foregroundBokehMaxDepth;
        [FieldOffset(4)]  public float foregroundBokehStartDepth;
        [FieldOffset(8)]  public float backgroundBokehStartDepth;
        [FieldOffset(12)] public float backgroundBokehMaxDepth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct IslandCameraRflParam
    {
        [FieldOffset(0)]  public float fovy;
        [FieldOffset(16)] public Vector3 targetOffset;
        [FieldOffset(32)] public Vector3 eyeOffset;
        [FieldOffset(48)] public CameraDOFRflParameter dof;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct IslandFloatingRflParam
    {
        [FieldOffset(0)] public Vector3 floatingOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct CursorMoveCameraRflParam
    {
        [FieldOffset(0)] public float moveDistance;
        [FieldOffset(4)] public float interpolateTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct MapAnimCameraRflParam
    {
        [FieldOffset(0)] public float playSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct TitleMoveCameraRflParam
    {
        [FieldOffset(0)] public float interpolateTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct ShakeCameraRflParameter
    {
        [FieldOffset(0)]  public bool use;
        [FieldOffset(4)]  public int index;
        [FieldOffset(8)]  public float amplitude;
        [FieldOffset(12)] public float periodMin;
        [FieldOffset(16)] public float periodMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct TimeChangeCameraRflParameter
    {
        [FieldOffset(0)] public int IBLIndex;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct RotateAngleLimitRflParam
    {
        [FieldOffset(0)]  public float yawMax;
        [FieldOffset(4)]  public float yawMin;
        [FieldOffset(8)]  public float pitchMax;
        [FieldOffset(12)] public float pitchMin;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct MapCameraRflParam
    {
        [FieldOffset(0)]  public float fovYMax;
        [FieldOffset(4)]  public float fovYMin;
        [FieldOffset(8)]  public float fovYAddSpeed;
        [FieldOffset(12)] public float rotateSpeedMax;
        [FieldOffset(16)] public float rotateSpeedMin;
        [FieldOffset(20)] public RotateAngleLimitRflParam rotateLimitNear;
        [FieldOffset(36)] public RotateAngleLimitRflParam rotateLimitFar;
    }

    [StructLayout(LayoutKind.Explicit, Size = 364)]
    public struct MapCameraRflParams
    {
        [FieldOffset(0)] public MapCameraRflParam _params__arr0;
        [FieldOffset(52)] public MapCameraRflParam _params__arr1;
        [FieldOffset(104)] public MapCameraRflParam _params__arr2;
        [FieldOffset(156)] public MapCameraRflParam _params__arr3;
        [FieldOffset(208)] public MapCameraRflParam _params__arr4;
        [FieldOffset(260)] public MapCameraRflParam _params__arr5;
        [FieldOffset(312)] public MapCameraRflParam _params__arr6;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1536)]
    public struct CameraRflParam
    {
        [FieldOffset(0)]    public IslandCameraRflParam islandCameraParam__arr0;
        [FieldOffset(64)] public IslandCameraRflParam islandCameraParam__arr1;
        [FieldOffset(128)] public IslandCameraRflParam islandCameraParam__arr2;
        [FieldOffset(192)] public IslandCameraRflParam islandCameraParam__arr3;
        [FieldOffset(256)] public IslandCameraRflParam islandCameraParam__arr4;
        [FieldOffset(320)] public IslandCameraRflParam islandCameraParam__arr5;
        [FieldOffset(384)] public IslandCameraRflParam islandCameraParam__arr6;
        [FieldOffset(448)]  public IslandCameraRflParam titleCameraParam__arr0;
        [FieldOffset(512)] public IslandCameraRflParam titleCameraParam__arr1;
        [FieldOffset(576)] public IslandCameraRflParam titleCameraParam__arr2;
        [FieldOffset(640)] public IslandCameraRflParam titleCameraParam__arr3;
        [FieldOffset(704)] public IslandCameraRflParam titleCameraParam__arr4;
        [FieldOffset(768)] public IslandCameraRflParam titleCameraParam__arr5;
        [FieldOffset(832)] public IslandCameraRflParam titleCameraParam__arr6;
        [FieldOffset(896)]  public IslandCameraRflParam islandSky3KCameraParam;
        [FieldOffset(960)]  public IslandCameraRflParam titleSky3KCameraParam;
        [FieldOffset(1024)] public IslandFloatingRflParam islandSky3KFlaotingParam;
        [FieldOffset(1040)] public CursorMoveCameraRflParam cursorMoveCamera;
        [FieldOffset(1048)] public MapAnimCameraRflParam mapAnimCameraRflParam;
        [FieldOffset(1052)] public TitleMoveCameraRflParam titleMoveCameraParam;
        [FieldOffset(1056)] public ShakeCameraRflParameter shakeCameraParamIsland;
        [FieldOffset(1076)] public ShakeCameraRflParameter shakeCameraParamTitle;
        [FieldOffset(1096)] public ShakeCameraRflParameter shakeCameraParamAllMap;
        [FieldOffset(1116)] public ShakeCameraRflParameter shakeCameraParamFree;
        [FieldOffset(1136)] public bool enableShakeCameraNX;
        [FieldOffset(1140)] public TimeChangeCameraRflParameter timeChangeDefaultParam;
        [FieldOffset(1144)] public TimeChangeCameraRflParameter timeChangeNightParam;
        [FieldOffset(1148)] public MapCameraRflParams mapFreeCameraParam;
        [FieldOffset(1512)] public float alphaFadeTime;
        [FieldOffset(1516)] public float zNear;
        [FieldOffset(1520)] public float zFar;
        [FieldOffset(1524)] public int sceneParamIndexDefault;
        [FieldOffset(1528)] public int sceneParamIndexAllMap;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MissionResultRflParam
    {
        [FieldOffset(0)]  public float failed_RetryWindowViewWaitTime;
        [FieldOffset(4)]  public float success_AddCoinTime;
        [FieldOffset(8)]  public float success_AddCoinStartWaitTime;
        [FieldOffset(12)] public float success_AddCoinEndWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct MissionRflParam
    {
        [FieldOffset(0)] public float hud_TimeLimit;
        [FieldOffset(4)] public MissionResultRflParam result;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct BossrushResultRflParam
    {
        [FieldOffset(0)] public float failed_RetryWindowViewWaitTime;
        [FieldOffset(4)] public float success_RestartWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct BossrushRflParam
    {
        [FieldOffset(0)]  public BossrushResultRflParam result;
        [FieldOffset(8)]  public int clearCoin;
        [FieldOffset(12)] public float startFade_LoopWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct AnniversaryRflParam
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct RewindModeRflParam
    {
        [FieldOffset(0)] public int consumeCoinCount;
        [FieldOffset(4)] public int ui_seekbarActionMove;
        [FieldOffset(8)] public float ui_seekbarWheelRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct SpecialStageRflParam
    {
        [FieldOffset(0)] public int consumeCoinCount;
    }

    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public struct MuseumArtGraphicPlayerRflParam
    {
        [FieldOffset(0)]  public float zoomTime;
        [FieldOffset(4)]  public float maxMoveSpeed;
        [FieldOffset(8)]  public float speedUpTime;
        [FieldOffset(12)] public float speedDownTime;
        [FieldOffset(16)] public Vector2 limitLeftUp;
        [FieldOffset(24)] public Vector2 limitRightDown;
        [FieldOffset(32)] public bool isInverted;
        [FieldOffset(36)] public float minMoveThreshold;
        [FieldOffset(40)] public float maxMoveThreshold;
        [FieldOffset(44)] public bool isSwitchContinuous;
        [FieldOffset(48)] public float switchWaitTime;
        [FieldOffset(52)] public float switchIntervalTime;
        [FieldOffset(56)] public bool isSwitchPageContinuous;
        [FieldOffset(60)] public float switchPageWaitTime;
        [FieldOffset(64)] public float switchPageIntervalTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public struct MuseumArtGalleryRflParam
    {
        [FieldOffset(0)] public MuseumArtGraphicPlayerRflParam artGraphicPlayer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MuseumMusicPlayerRflParam
    {
        [FieldOffset(0)] public bool isSwitchContinuous;
        [FieldOffset(4)] public float switchWaitTime;
        [FieldOffset(8)] public float switchIntervalTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct MuseumMusicHallRflParam
    {
        [FieldOffset(0)] public MuseumMusicPlayerRflParam musicPlayer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MuseumMoviePlayerRflParam
    {
        [FieldOffset(0)]  public bool isSwitchContinuous;
        [FieldOffset(4)]  public float switchWaitTime;
        [FieldOffset(8)]  public float switchIntervalTime;
        [FieldOffset(12)] public float movieVolume;
    }

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct MuseumMovieTheaterRflParam
    {
        [FieldOffset(0)] public MuseumMoviePlayerRflParam moviePlayer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public struct MuseumModeRflParam
    {
        [FieldOffset(0)]  public MuseumArtGalleryRflParam artGallery;
        [FieldOffset(68)] public MuseumMusicHallRflParam musicHall;
        [FieldOffset(80)] public MuseumMovieTheaterRflParam movieTheater;
    }

    public enum CreditType : sbyte
    {
        HITE = 0,
        SONICCD_GOODEND = 1,
        SONICCD_BADEND = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public struct CreditModeRflParam
    {
        [FieldOffset(0)] public CreditType type;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct InputRflParam
    {
        [FieldOffset(0)] public float stickAndDigitalKeyConversion;
    }

    public enum FadeType : int
    {
        WHITE = 0,
        BLACK = 1,
        NONE = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct SceneFadeRflParam
    {
        [FieldOffset(0)] public FadeType fadeType;
        [FieldOffset(4)] public float fadeOutTime;
        [FieldOffset(8)] public float fadeInTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public struct GameSceneRflParam
    {
        [FieldOffset(0)] public SceneFadeRflParam fadeParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 1888)]
    public struct GameRflParam
    {
        [FieldOffset(0)]    public CameraRflParam camera;
        [FieldOffset(1536)] public MissionRflParam mission;
        [FieldOffset(1556)] public BossrushRflParam bossrush;
        [FieldOffset(1572)] public AnniversaryRflParam anniversary;
        [FieldOffset(1576)] public RewindModeRflParam rewindMode;
        [FieldOffset(1588)] public SpecialStageRflParam specialStage;
        [FieldOffset(1592)] public MuseumModeRflParam museum;
        [FieldOffset(1688)] public CreditModeRflParam credit;
        [FieldOffset(1692)] public InputRflParam inputParam;
        [FieldOffset(1696)] public GameSceneRflParam sceneParam__arr0;
        [FieldOffset(1708)] public GameSceneRflParam sceneParam__arr1;
        [FieldOffset(1720)] public GameSceneRflParam sceneParam__arr2;
        [FieldOffset(1732)] public GameSceneRflParam sceneParam__arr3;
        [FieldOffset(1744)] public GameSceneRflParam sceneParam__arr4;
        [FieldOffset(1756)] public GameSceneRflParam sceneParam__arr5;
        [FieldOffset(1768)] public GameSceneRflParam sceneParam__arr6;
        [FieldOffset(1780)] public GameSceneRflParam sceneParam__arr7;
        [FieldOffset(1792)] public GameSceneRflParam sceneParam__arr8;
        [FieldOffset(1804)] public GameSceneRflParam sceneParam__arr9;
        [FieldOffset(1816)] public GameSceneRflParam sceneParam__arr10;
        [FieldOffset(1828)] public GameSceneRflParam sceneParam__arr11;
        [FieldOffset(1840)] public GameSceneRflParam sceneParam__arr12;
        [FieldOffset(1852)] public GameSceneRflParam sceneParam__arr13;
        [FieldOffset(1864)] public GameSceneRflParam sceneParam__arr14;
        [FieldOffset(1876)] public GameSceneRflParam sceneParam__arr15;
    }

}