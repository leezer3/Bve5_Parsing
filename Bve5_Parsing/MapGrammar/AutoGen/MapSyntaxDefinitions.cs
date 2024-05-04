/*
 * このファイルはdoc/createMapGrammarTemplate.jsによって自動生成されています。
 * 編集は行わないでください。
 */

namespace Bve5_Parsing.MapGrammar {

    /// <summary>
    /// マップ要素名
    /// </summary>
    public enum MapElementName
    {

        /// <summary>
        /// Curve
        /// </summary>
        [StringValue("Curve")]
        Curve,

        /// <summary>
        /// Gauge
        /// </summary>
        [StringValue("Gauge")]
        Gauge,

        /// <summary>
        /// Gradient
        /// </summary>
        [StringValue("Gradient")]
        Gradient,

        /// <summary>
        /// Track
        /// </summary>
        [StringValue("Track")]
        Track,

        /// <summary>
        /// Structure
        /// </summary>
        [StringValue("Structure")]
        Structure,

        /// <summary>
        /// Repeater
        /// </summary>
        [StringValue("Repeater")]
        Repeater,

        /// <summary>
        /// Background
        /// </summary>
        [StringValue("Background")]
        Background,

        /// <summary>
        /// Station
        /// </summary>
        [StringValue("Station")]
        Station,

        /// <summary>
        /// Section
        /// </summary>
        [StringValue("Section")]
        Section,

        /// <summary>
        /// Signal
        /// </summary>
        [StringValue("Signal")]
        Signal,

        /// <summary>
        /// SpeedLimit
        /// </summary>
        [StringValue("SpeedLimit")]
        SpeedLimit,

        /// <summary>
        /// Beacon
        /// </summary>
        [StringValue("Beacon")]
        Beacon,

        /// <summary>
        /// Pretrain
        /// </summary>
        [StringValue("Pretrain")]
        Pretrain,

        /// <summary>
        /// Light
        /// </summary>
        [StringValue("Light")]
        Light,

        /// <summary>
        /// Fog
        /// </summary>
        [StringValue("Fog")]
        Fog,

        /// <summary>
        /// DrawDistance
        /// </summary>
        [StringValue("DrawDistance")]
        DrawDistance,

        /// <summary>
        /// CabIlluminance
        /// </summary>
        [StringValue("CabIlluminance")]
        CabIlluminance,

        /// <summary>
        /// Irregularity
        /// </summary>
        [StringValue("Irregularity")]
        Irregularity,

        /// <summary>
        /// Adhesion
        /// </summary>
        [StringValue("Adhesion")]
        Adhesion,

        /// <summary>
        /// Sound
        /// </summary>
        [StringValue("Sound")]
        Sound,

        /// <summary>
        /// Sound3d
        /// </summary>
        [StringValue("Sound3d")]
        Sound3d,

        /// <summary>
        /// RollingNoise
        /// </summary>
        [StringValue("RollingNoise")]
        RollingNoise,

        /// <summary>
        /// FlangeNoise
        /// </summary>
        [StringValue("FlangeNoise")]
        FlangeNoise,

        /// <summary>
        /// JointNoise
        /// </summary>
        [StringValue("JointNoise")]
        JointNoise,

        /// <summary>
        /// Train
        /// </summary>
        [StringValue("Train")]
        Train,

        /// <summary>
        /// Legacy
        /// </summary>
        [StringValue("Legacy")]
        Legacy,

        /// <summary>
        /// Include
        /// </summary>
        [StringValue("Include")]
        Include,
    }

    /// <summary>
    /// マップ副要素名（一部構文のみに存在します）
    /// </summary>
    public enum MapSubElementName {

        /// <summary>
        /// X
        /// </summary>
        [StringValue("X")]
        X,

        /// <summary>
        /// Y
        /// </summary>
        [StringValue("Y")]
        Y,

        /// <summary>
        /// Cant
        /// </summary>
        [StringValue("Cant")]
        Cant,
    }

    /// <summary>
    /// マップ関数名
    /// </summary>
    public enum MapFunctionName {

        /// <summary>
        /// SetGauge
        /// </summary>
        [StringValue("SetGauge")]
        SetGauge,

        /// <summary>
        /// Set
        /// </summary>
        [StringValue("Set")]
        Set,

        /// <summary>
        /// Gauge
        /// </summary>
        [StringValue("Gauge")]
        Gauge,

        /// <summary>
        /// SetCenter
        /// </summary>
        [StringValue("SetCenter")]
        SetCenter,

        /// <summary>
        /// SetFunction
        /// </summary>
        [StringValue("SetFunction")]
        SetFunction,

        /// <summary>
        /// BeginTransition
        /// </summary>
        [StringValue("BeginTransition")]
        BeginTransition,

        /// <summary>
        /// Begin
        /// </summary>
        [StringValue("Begin")]
        Begin,

        /// <summary>
        /// BeginCircular
        /// </summary>
        [StringValue("BeginCircular")]
        BeginCircular,

        /// <summary>
        /// End
        /// </summary>
        [StringValue("End")]
        End,

        /// <summary>
        /// Interpolate
        /// </summary>
        [StringValue("Interpolate")]
        Interpolate,

        /// <summary>
        /// Change
        /// </summary>
        [StringValue("Change")]
        Change,

        /// <summary>
        /// BeginConst
        /// </summary>
        [StringValue("BeginConst")]
        BeginConst,

        /// <summary>
        /// Position
        /// </summary>
        [StringValue("Position")]
        Position,

        /// <summary>
        /// Cant
        /// </summary>
        [StringValue("Cant")]
        Cant,

        /// <summary>
        /// Load
        /// </summary>
        [StringValue("Load")]
        Load,

        /// <summary>
        /// Put
        /// </summary>
        [StringValue("Put")]
        Put,

        /// <summary>
        /// Put0
        /// </summary>
        [StringValue("Put0")]
        Put0,

        /// <summary>
        /// PutBetween
        /// </summary>
        [StringValue("PutBetween")]
        PutBetween,

        /// <summary>
        /// Begin0
        /// </summary>
        [StringValue("Begin0")]
        Begin0,

        /// <summary>
        /// BeginNew
        /// </summary>
        [StringValue("BeginNew")]
        BeginNew,

        /// <summary>
        /// SetSpeedLimit
        /// </summary>
        [StringValue("SetSpeedLimit")]
        SetSpeedLimit,

        /// <summary>
        /// SpeedLimit
        /// </summary>
        [StringValue("SpeedLimit")]
        SpeedLimit,

        /// <summary>
        /// SetSignal
        /// </summary>
        [StringValue("SetSignal")]
        SetSignal,

        /// <summary>
        /// Pass
        /// </summary>
        [StringValue("Pass")]
        Pass,

        /// <summary>
        /// Ambient
        /// </summary>
        [StringValue("Ambient")]
        Ambient,

        /// <summary>
        /// Diffuse
        /// </summary>
        [StringValue("Diffuse")]
        Diffuse,

        /// <summary>
        /// Direction
        /// </summary>
        [StringValue("Direction")]
        Direction,

        /// <summary>
        /// Play
        /// </summary>
        [StringValue("Play")]
        Play,

        /// <summary>
        /// Add
        /// </summary>
        [StringValue("Add")]
        Add,

        /// <summary>
        /// Enable
        /// </summary>
        [StringValue("Enable")]
        Enable,

        /// <summary>
        /// Stop
        /// </summary>
        [StringValue("Stop")]
        Stop,

        /// <summary>
        /// SetTrack
        /// </summary>
        [StringValue("SetTrack")]
        SetTrack,

        /// <summary>
        /// Fog
        /// </summary>
        [StringValue("Fog")]
        Fog,

        /// <summary>
        /// Curve
        /// </summary>
        [StringValue("Curve")]
        Curve,

        /// <summary>
        /// Pitch
        /// </summary>
        [StringValue("Pitch")]
        Pitch,

        /// <summary>
        /// Turn
        /// </summary>
        [StringValue("Turn")]
        Turn,
    }

    /// <summary>
    /// Available arguments
    /// </summary>
    public enum ArgumentName
    {
        // raw value
        Value,
        V,
        B,
        C,
        // Object position
        X,
        Y,
        Z,
        Pitch,
        Yaw,
        RX,
        RY,
        RZ,
        // Crack, repeater etc.
        TrackKey1,
        TrackKey2,
        Tilt,
        Span,
        Interval,
        Index,
        // track
        Cant,
        Radius,
        // RGBA
        Red,
        Green,
        Blue,
        A,
        // Fog
        Density,
        Start,
        End,
        // TFO
        TrainKey,
        TrainFilePath,
        Direction,
        Time,
        Decelerate,
        StopTime,
        Accelerate,
        Speed
    }

}
