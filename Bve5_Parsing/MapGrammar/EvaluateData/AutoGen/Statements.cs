using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bve5_Parsing.MapGrammar.Attributes;

namespace Bve5_Parsing.MapGrammar.EvaluateData {

    /// <summary>
    /// Curve.SetGauge(Value);
    /// </summary>
    public class CurveSetGaugeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetGauge;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：軌間 [m]
        /// </summary>
        [Argument]
        public double? Value { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveSetGaugeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveSetGaugeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Gauge.Set(Value);
    /// </summary>
    public class GaugeSetStatement : CurveSetGaugeStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gauge;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Set;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public GaugeSetStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public GaugeSetStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.Gauge(Value);
    /// </summary>
    public class CurveGaugeStatement : CurveSetGaugeStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Gauge;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveGaugeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveGaugeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.SetCenter(X);
    /// </summary>
    public class CurveSetCenterStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetCenter;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：回転中心の x 座標 [m] (正: 曲線の内側, 負: 曲線の外側)
        /// </summary>
        [Argument]
        public double? X { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveSetCenterStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveSetCenterStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.SetFunction(Id);
    /// </summary>
    public class CurveSetFunctionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetFunction;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：関数番号 (0: サイン半波長逓減, 1: 直線逓減)
        /// </summary>
        [Argument]
        public double? Id { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveSetFunctionStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveSetFunctionStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.BeginTransition();
    /// </summary>
    public class CurveBeginTransitionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.BeginTransition;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveBeginTransitionStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveBeginTransitionStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.Begin(Radius, Cant?);
    /// </summary>
    public class CurveBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線)
        /// </summary>
        [Argument]
        public double? Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveBeginStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveBeginStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.BeginCircular(Radius, Cant?);
    /// </summary>
    public class CurveBeginCircularStatement : CurveBeginStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.BeginCircular;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveBeginCircularStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveBeginCircularStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.End();
    /// </summary>
    public class CurveEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveEndStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveEndStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.Interpolate(Radius?, Cant?);
    /// </summary>
    public class CurveInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線, 0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveInterpolateStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveInterpolateStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Curve.Change(Radius);
    /// </summary>
    public class CurveChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Curve;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線, 0: 直線)
        /// </summary>
        [Argument]
        public double? Radius { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CurveChangeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CurveChangeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Gradient.BeginTransition();
    /// </summary>
    public class GradientBeginTransitionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.BeginTransition;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public GradientBeginTransitionStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public GradientBeginTransitionStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Gradient.Begin(Gradient);
    /// </summary>
    public class GradientBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：勾配 [‰]
        /// </summary>
        [Argument]
        public double? Gradient { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public GradientBeginStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public GradientBeginStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Gradient.BeginConst(Gradient);
    /// </summary>
    public class GradientBeginConstStatement : GradientBeginStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.BeginConst;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public GradientBeginConstStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public GradientBeginConstStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Gradient.End();
    /// </summary>
    public class GradientEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public GradientEndStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public GradientEndStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Gradient.Interpolate(Gradient?);
    /// </summary>
    public class GradientInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Gradient;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：勾配 [‰]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Gradient { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public GradientInterpolateStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public GradientInterpolateStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].X.Interpolate(X?, Radius?);
    /// </summary>
    public class TrackXInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.X;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの x 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? X { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との平面曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Radius { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackXInterpolateStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackXInterpolateStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Y.Interpolate(Y?, Radius?);
    /// </summary>
    public class TrackYInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.Y;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの y 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Y { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との縦曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Radius { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackYInterpolateStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackYInterpolateStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Position(X, Y, RadiusH?, RadiusV?);
    /// </summary>
    public class TrackPositionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Position;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double? X { get; set; }

        /// <summary>
        /// 引数：自軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double? Y { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との平面曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? RadiusH { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との縦曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? RadiusV { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackPositionStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackPositionStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.SetGauge(Gauge);
    /// </summary>
    public class TrackCantSetGaugeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetGauge;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：軌間 [m]
        /// </summary>
        [Argument]
        public double? Gauge { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackCantSetGaugeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackCantSetGaugeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Gauge(Gauge);
    /// </summary>
    public class TrackGaugeStatement : TrackCantSetGaugeStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Gauge;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackGaugeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackGaugeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.SetCenter(X);
    /// </summary>
    public class TrackCantSetCenterStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetCenter;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：回転中心の x 座標 [m] (正: 曲線の内側, 負: 曲線の外側)
        /// </summary>
        [Argument]
        public double? X { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackCantSetCenterStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackCantSetCenterStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.SetFunction(Id);
    /// </summary>
    public class TrackCantSetFunctionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetFunction;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：関数番号 (0: サイン半波長逓減, 1: 直線逓減)
        /// </summary>
        [Argument]
        public double? Id { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackCantSetFunctionStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackCantSetFunctionStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.BeginTransition();
    /// </summary>
    public class TrackCantBeginTransitionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.BeginTransition;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackCantBeginTransitionStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackCantBeginTransitionStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.Begin(Cant);
    /// </summary>
    public class TrackCantBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：カント [m] (正: 右に傾ける, 負: 左に傾ける)
        /// </summary>
        [Argument]
        public double? Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackCantBeginStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackCantBeginStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.End();
    /// </summary>
    public class TrackCantEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackCantEndStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackCantEndStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.Interpolate(Cant?);
    /// </summary>
    public class TrackCantInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// マップ副要素名
        /// </summary>
        public override MapSubElementName? SubElementName => MapSubElementName.Cant;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => true;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrackKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：カント [m] (正: 右に傾ける, 負: 左に傾ける)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackCantInterpolateStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackCantInterpolateStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant(Cant?);
    /// </summary>
    public class TrackCantStatement : TrackCantInterpolateStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Track;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Cant;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrackCantStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrackCantStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Structure.Load(FilePath);
    /// </summary>
    public class StructureLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Structure;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルからストラクチャーリストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public StructureLoadStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public StructureLoadStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Structure[StructureKey].Put(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
    /// </summary>
    public class StructurePutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Structure;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：StructureKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double? X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double? Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]
        /// </summary>
        [Argument]
        public double? Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double? RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double? RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double? RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public double? Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public double? Span { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public StructurePutStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public StructurePutStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Structure[StructureKey].Put0(TrackKey, Tilt, Span);
    /// </summary>
    public class StructurePut0Statement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Structure;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Put0;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：StructureKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public double? Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public double? Span { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public StructurePut0Statement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public StructurePut0Statement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Structure[StructureKey].PutBetween(TrackKey1, TrackKey2, Flag?);
    /// </summary>
    public class StructurePutBetweenStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Structure;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.PutBetween;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：StructureKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：一方の軌道の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey1 { get; set; }

        /// <summary>
        /// 引数：他方の軌道の軌道名
        /// </summary>
        [Argument]
        public string TrackKey2 { get; set; }

        /// <summary>
        /// 引数：変形方向 (0: x および y 方向に変形, 1: x 方向のみに変形)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Flag { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public StructurePutBetweenStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public StructurePutBetweenStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Repeater[RepeaterKey].Begin(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span, Interval, StructureKey);
    /// </summary>
    public class RepeaterBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Repeater;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：RepeaterKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double? X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double? Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]
        /// </summary>
        [Argument]
        public double? Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double? RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double? RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public double? RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public double? Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public double? Span { get; set; }

        /// <summary>
        /// 引数：配置間隔 [m]
        /// </summary>
        [Argument]
        public double? Interval { get; set; }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）のリスト
        /// </summary>
        protected List<string> _structurekeys = new List<string>();

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）の読み取り専用コレクション
        /// </summary>
        public ReadOnlyCollection<string> StructureKeys => _structurekeys.AsReadOnly();
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public RepeaterBeginStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public RepeaterBeginStatement(double distance) : base(distance) { }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）を追加します。
        /// </summary>
        public void AddStructureKey(string structurekey)
        {
            _structurekeys.Add(structurekey);
        }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）に値をセットします。
        /// テスト用
        /// </summary>
        public Statement SetStructureKeys(params string[] structurekeys)
        {
            _structurekeys.AddRange(structurekeys);
            return this;
        }

        /// <summary>
        /// StatementからSyntaxDataを生成して返します。
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）対応
        /// </summary>
        public override SyntaxData ToSyntaxData()
        {
            var syntax = base.ToSyntaxData();
            for (var i = 0; i < _structurekeys.Count; i++)
            {
                syntax.SetArg($"structurekey{i + 1}", _structurekeys[i]);
            }

            return syntax;
        }
    }

    /// <summary>
    /// Repeater[RepeaterKey].Begin0(TrackKey, Tilt, Span, Interval, StructureKey);
    /// </summary>
    public class RepeaterBegin0Statement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Repeater;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Begin0;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：RepeaterKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public double? Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public double? Span { get; set; }

        /// <summary>
        /// 引数：配置間隔 [m]
        /// </summary>
        [Argument]
        public double? Interval { get; set; }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）のリスト
        /// </summary>
        protected List<string> _structurekeys = new List<string>();

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）の読み取り専用コレクション
        /// </summary>
        public ReadOnlyCollection<string> StructureKeys => _structurekeys.AsReadOnly();
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public RepeaterBegin0Statement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public RepeaterBegin0Statement(double distance) : base(distance) { }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）を追加します。
        /// </summary>
        public void AddStructureKey(string structurekey)
        {
            _structurekeys.Add(structurekey);
        }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）に値をセットします。
        /// テスト用
        /// </summary>
        public Statement SetStructureKeys(params string[] structurekeys)
        {
            _structurekeys.AddRange(structurekeys);
            return this;
        }

        /// <summary>
        /// StatementからSyntaxDataを生成して返します。
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）対応
        /// </summary>
        public override SyntaxData ToSyntaxData()
        {
            var syntax = base.ToSyntaxData();
            for (var i = 0; i < _structurekeys.Count; i++)
            {
                syntax.SetArg($"structurekey{i + 1}", _structurekeys[i]);
            }

            return syntax;
        }
    }

    /// <summary>
    /// Repeater[RepeaterKey].End();
    /// </summary>
    public class RepeaterEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Repeater;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：RepeaterKey
        /// </summary>
        public override string Key { get; set; }


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public RepeaterEndStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public RepeaterEndStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Background.Change(StructureKey);
    /// </summary>
    public class BackgroundChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Background;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：ストラクチャー名
        /// </summary>
        [Argument]
        public string StructureKey { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public BackgroundChangeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public BackgroundChangeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Station.Load(FilePath);
    /// </summary>
    public class StationLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Station;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルから停車場リストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public StationLoadStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public StationLoadStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Station[StationKey].Put(Door, Margin1, Margin2);
    /// </summary>
    public class StationPutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Station;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：StationKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：開くドアの方向 (-1: 左, 1: 右)
        /// </summary>
        [Argument]
        public double? Door { get; set; }

        /// <summary>
        /// 引数：停止位置誤差の後方許容範囲 (負の値で設定)
        /// </summary>
        [Argument]
        public double? Margin1 { get; set; }

        /// <summary>
        /// 引数：停止位置誤差の後方許容範囲
        /// </summary>
        [Argument]
        public double? Margin2 { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public StationPutStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public StationPutStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Section.Begin(Signal);
    /// </summary>
    public class SectionBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Section;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 可変長引数：先行列車が n 閉そく先に存在する場合の信号インデックス（0: この閉塞）のリスト
        /// </summary>
        protected List<double?> _aspects = new List<double?>();

        /// <summary>
        /// 可変長引数：先行列車が n 閉そく先に存在する場合の信号インデックス（0: この閉塞）の読み取り専用コレクション
        /// </summary>
        public ReadOnlyCollection<double?> SignalAspects => _aspects.AsReadOnly();
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SectionBeginStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SectionBeginStatement(double distance) : base(distance) { }

        /// <summary>
        /// 可変長引数：先行列車が n 閉そく先に存在する場合の信号インデックス（0: この閉塞）を追加します。
        /// </summary>
        public void AddSignal(double? signal)
        {
            _aspects.Add(signal);
        }

        /// <summary>
        /// 可変長引数：先行列車が n 閉そく先に存在する場合の信号インデックス（0: この閉塞）に値をセットします。
        /// テスト用
        /// </summary>
        public Statement SetAspects(params double?[] signals)
        {
            _aspects.AddRange(signals);
            return this;
        }

        /// <summary>
        /// StatementからSyntaxDataを生成して返します。
        /// 可変長引数：先行列車が n 閉そく先に存在する場合の信号インデックス（0: この閉塞）対応
        /// </summary>
        public override SyntaxData ToSyntaxData()
        {
            var syntax = base.ToSyntaxData();
            for (var i = 0; i < _aspects.Count; i++)
            {
                syntax.SetArg($"signal{i + 1}", _aspects[i]);
            }

            return syntax;
        }
    }

    /// <summary>
    /// Section.BeginNew(Signal);
    /// </summary>
    public class SectionBeginNewStatement : SectionBeginStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Section;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.BeginNew;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SectionBeginNewStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SectionBeginNewStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Section.SetSpeedLimit(V);
    /// </summary>
    public class SectionSetSpeedLimitStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Section;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetSpeedLimit;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 可変長引数：走行速度 [km/h] （null: 許容速度なし）のリスト
        /// </summary>
        protected List<double?> _speedLimits = new List<double?>();

        /// <summary>
        /// 可変長引数：走行速度 [km/h] （null: 許容速度なし）の読み取り専用コレクション
        /// </summary>
        public ReadOnlyCollection<double?> SpeedLimits => _speedLimits.AsReadOnly();
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SectionSetSpeedLimitStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SectionSetSpeedLimitStatement(double distance) : base(distance) { }

        /// <summary>
        /// 可変長引数：走行速度 [km/h] （null: 許容速度なし）を追加します。
        /// </summary>
        public void AddV(double? v)
        {
            _speedLimits.Add(v);
        }

        /// <summary>
        /// 可変長引数：走行速度 [km/h] （null: 許容速度なし）に値をセットします。
        /// テスト用
        /// </summary>
        public Statement SetSpeedLimits(params double?[] vs)
        {
            _speedLimits.AddRange(vs);
            return this;
        }

        /// <summary>
        /// StatementからSyntaxDataを生成して返します。
        /// 可変長引数：走行速度 [km/h] （null: 許容速度なし）対応
        /// </summary>
        public override SyntaxData ToSyntaxData()
        {
            var syntax = base.ToSyntaxData();
            for (var i = 0; i < _speedLimits.Count; i++)
            {
                syntax.SetArg($"v{i + 1}", _speedLimits[i]);
            }

            return syntax;
        }
    }

    /// <summary>
    /// Signal.SpeedLimit(V);
    /// </summary>
    public class SignalSpeedLimitStatement : SectionSetSpeedLimitStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Signal;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SpeedLimit;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SignalSpeedLimitStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SignalSpeedLimitStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// SpeedLimit.SetSignal(V);
    /// </summary>
    public class SpeedLimitSetSignalStatement : SectionSetSpeedLimitStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.SpeedLimit;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetSignal;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SpeedLimitSetSignalStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SpeedLimitSetSignalStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Signal.Load(FilePath);
    /// </summary>
    public class SignalLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Signal;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルから信号現示リストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SignalLoadStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SignalLoadStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Signal[SignalAspectKey].Put(Section, TrackKey, X, Y, Z?, RX?, RY?, RZ?, Tilt?, Span?);
    /// </summary>
    public class SignalPutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Signal;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：SignalAspectKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：関連づける閉そくの相対インデックス
        /// </summary>
        [Argument]
        public double? Section { get; set; }

        /// <summary>
        /// 引数：配置先の軌道名
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double? X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double? Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Span { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SignalPutStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SignalPutStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Beacon.Put(Type, Section, Senddata);
    /// </summary>
    public class BeaconPutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Beacon;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：保安装置に送る地上子種別 (整数)
        /// </summary>
        [Argument]
        public double? Type { get; set; }

        /// <summary>
        /// 引数：関連づける閉そくの相対インデックス
        /// </summary>
        [Argument]
        public double? Section { get; set; }

        /// <summary>
        /// 引数：保安装置に送る値 (整数)
        /// </summary>
        [Argument]
        public double? Senddata { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public BeaconPutStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public BeaconPutStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// SpeedLimit.Begin(V);
    /// </summary>
    public class SpeedLimitBeginStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.SpeedLimit;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Begin;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：走行速度 [km/h]
        /// </summary>
        [Argument]
        public double? V { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SpeedLimitBeginStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SpeedLimitBeginStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// SpeedLimit.End();
    /// </summary>
    public class SpeedLimitEndStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.SpeedLimit;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.End;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：走行速度 [km/h]
        /// </summary>
        [Argument]
        public double? V { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SpeedLimitEndStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SpeedLimitEndStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Pretrain.Pass(Time?, Second?);
    /// </summary>
    public class PretrainPassStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Pretrain;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Pass;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：時刻を表す文字列 ('hh:mm:ss')（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public string Time { get; set; }

        /// <summary>
        /// 引数：00:00:00 からの経過時間 [sec]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Second { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public PretrainPassStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public PretrainPassStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Light.Ambient(Red, Green, Blue);
    /// </summary>
    public class LightAmbientStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Light;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Ambient;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? Blue { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public LightAmbientStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public LightAmbientStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Light.Diffuse(Red, Green, Blue);
    /// </summary>
    public class LightDiffuseStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Light;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Diffuse;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? Blue { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public LightDiffuseStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public LightDiffuseStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Light.Direction(Pitch, Yaw);
    /// </summary>
    public class LightDirectionStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Light;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Direction;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：角度
        /// </summary>
        [Argument]
        public double? Pitch { get; set; }

        /// <summary>
        /// 引数：回転角
        /// </summary>
        [Argument]
        public double? Yaw { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public LightDirectionStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public LightDirectionStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Fog.Interpolate(Density?, Red?, Green?, Blue?);
    /// </summary>
    public class FogInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Fog;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：濃度（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Density { get; set; }

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Blue { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public FogInterpolateStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public FogInterpolateStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Fog.Set(Density?, Red?, Green?, Blue?);
    /// </summary>
    public class FogSetStatement : FogInterpolateStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Fog;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Set;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public FogSetStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public FogSetStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// DrawDistance.Change(Value);
    /// </summary>
    public class DrawDistanceChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.DrawDistance;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：距離 [m] (0: [設定] ウィンドウで設定される描画距離を適用)
        /// </summary>
        [Argument]
        public double? Value { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public DrawDistanceChangeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public DrawDistanceChangeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// CabIlluminance.Interpolate(Value?);
    /// </summary>
    public class CabIlluminanceInterpolateStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.CabIlluminance;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Interpolate;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：昼間画像と夜間画像の混合比 (0: 夜間画像 ~ 1: 昼間画像)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Value { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CabIlluminanceInterpolateStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CabIlluminanceInterpolateStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// CabIlluminance.Set(Value);
    /// </summary>
    public class CabIlluminanceSetStatement : CabIlluminanceInterpolateStatement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.CabIlluminance;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Set;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public CabIlluminanceSetStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public CabIlluminanceSetStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Irregularity.Change(X, Y, R, LX, LY, LR);
    /// </summary>
    public class IrregularityChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Irregularity;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：左右変位 (左と右のレールの通り変位の平均に相当) の標準偏差 [m]
        /// </summary>
        [Argument]
        public double? X { get; set; }

        /// <summary>
        /// 引数：上下変位 (左と右のレールの高低変位の平均に相当) の標準偏差 [m]
        /// </summary>
        [Argument]
        public double? Y { get; set; }

        /// <summary>
        /// 引数：ロール変位 (水準変位を軌間で除した値に相当) の標準偏差 [rad]
        /// </summary>
        [Argument]
        public double? R { get; set; }

        /// <summary>
        /// 引数：左右変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public double? LX { get; set; }

        /// <summary>
        /// 引数：上下変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public double? LY { get; set; }

        /// <summary>
        /// 引数：ロール変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public double? LR { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public IrregularityChangeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public IrregularityChangeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Adhesion.Change(A, B?, C?);
    /// </summary>
    public class AdhesionChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Adhesion;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：走行速度 0 km/h における粘着係数
        /// </summary>
        [Argument]
        public double? A { get; set; }

        /// <summary>
        /// 引数：粘着係数の走行速度に対する変化を表す係数（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? B { get; set; }

        /// <summary>
        /// 引数：粘着係数の走行速度に対する変化を表す係数（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? C { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public AdhesionChangeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public AdhesionChangeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Sound.Load(FilePath);
    /// </summary>
    public class SoundLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Sound;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルからサウンドリストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SoundLoadStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SoundLoadStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Sound[SoundKey].Play();
    /// </summary>
    public class SoundPlayStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Sound;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Play;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：SoundKey
        /// </summary>
        public override string Key { get; set; }


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public SoundPlayStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public SoundPlayStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Sound3d.Load(FilePath);
    /// </summary>
    public class Sound3dLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Sound3d;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：このファイルからサウンドリストファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public Sound3dLoadStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public Sound3dLoadStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Sound3d[SoundKey].Put(X, Y);
    /// </summary>
    public class Sound3dPutStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Sound3d;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Put;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：SoundKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public double? X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public double? Y { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public Sound3dPutStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public Sound3dPutStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// RollingNoise.Change(Index);
    /// </summary>
    public class RollingNoiseChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.RollingNoise;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：車両サウンドファイルの [Run] セクションで定義したインデックス
        /// </summary>
        [Argument]
        public double? Index { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public RollingNoiseChangeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public RollingNoiseChangeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// FlangeNoise.Change(Index);
    /// </summary>
    public class FlangeNoiseChangeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.FlangeNoise;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Change;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：車両サウンドファイルの [Flange] セクションで定義したインデックス
        /// </summary>
        [Argument]
        public double? Index { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public FlangeNoiseChangeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public FlangeNoiseChangeStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// JointNoise.Play(Index);
    /// </summary>
    public class JointNoisePlayStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.JointNoise;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Play;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：車両サウンドファイルの [Joint] セクションで定義したインデックス
        /// </summary>
        [Argument]
        public double? Index { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public JointNoisePlayStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public JointNoisePlayStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Train.Add(TrainKey, FilePath, TrackKey?, Direction?);
    /// </summary>
    public class TrainAddStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Add;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：他列車名 (任意の文字列)
        /// </summary>
        [Argument]
        public string TrainKey { get; set; }

        /// <summary>
        /// 引数：このファイルから他列車ファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }

        /// <summary>
        /// 引数：走行する軌道（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：進行方向 (-1: 対向, 1: 並走)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Direction { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrainAddStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrainAddStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Train[TrainKey].Load(FilePath, TrackKey, Direction);
    /// </summary>
    public class TrainLoadStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Load;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrainKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：このファイルから他列車ファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }

        /// <summary>
        /// 引数：走行する軌道
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：進行方向 (-1: 対向, 1: 並走)
        /// </summary>
        [Argument]
        public double? Direction { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrainLoadStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrainLoadStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Train[TrainKey].Enable(Time?, Second?);
    /// </summary>
    public class TrainEnableStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Enable;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrainKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：時刻を表す文字列 ('hh:mm:ss')（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public string Time { get; set; }

        /// <summary>
        /// 引数：00:00:00 からの経過時間 [sec]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Second { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrainEnableStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrainEnableStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Train[TrainKey].Stop(Decelerate, StopTime, Accelerate, Speed);
    /// </summary>
    public class TrainStopStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Stop;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrainKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：減速度 [km/h/s]
        /// </summary>
        [Argument]
        public double? Decelerate { get; set; }

        /// <summary>
        /// 引数：停車時間 [s]
        /// </summary>
        [Argument]
        public double? StopTime { get; set; }

        /// <summary>
        /// 引数：加速度 [km/h/s]
        /// </summary>
        [Argument]
        public double? Accelerate { get; set; }

        /// <summary>
        /// 引数：加速後の走行速度 [km/h]
        /// </summary>
        [Argument]
        public double? Speed { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrainStopStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrainStopStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Train[TrainKey].SetTrack(TrackKey, Direction);
    /// </summary>
    public class TrainSetTrackStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Train;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.SetTrack;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => true;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        /// <summary>
        /// Key：TrainKey
        /// </summary>
        public override string Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：走行する軌道
        /// </summary>
        [Argument]
        public string TrackKey { get; set; }

        /// <summary>
        /// 引数：進行方向 (-1: 対向, 1: 並走)
        /// </summary>
        [Argument]
        public double? Direction { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public TrainSetTrackStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public TrainSetTrackStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Legacy.Fog(Fogstart, Fogend, red, green, blue);
    /// </summary>
    public class LegacyFogStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Legacy;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Fog;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：視界が100%の距離 [m]
        /// </summary>
        [Argument]
        public double? Fogstart { get; set; }

        /// <summary>
        /// 引数：視界が0%になる距離 [m]
        /// </summary>
        [Argument]
        public double? Fogend { get; set; }

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public double? blue { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public LegacyFogStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public LegacyFogStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Legacy.Curve(Radius, Cant);
    /// </summary>
    public class LegacyCurveStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Legacy;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Curve;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：曲線半径 [m] (正: 右曲線, 負: 左曲線)
        /// </summary>
        [Argument]
        public double? Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]
        /// </summary>
        [Argument]
        public double? Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public LegacyCurveStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public LegacyCurveStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Legacy.Pitch(Rate?);
    /// </summary>
    public class LegacyPitchStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Legacy;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Pitch;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：勾配 [‰]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Rate { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public LegacyPitchStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public LegacyPitchStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Legacy.Turn(Slope?);
    /// </summary>
    public class LegacyTurnStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Legacy;

        /// <summary>
        /// 関数名
        /// </summary>
        public override MapFunctionName? FunctionName => MapFunctionName.Turn;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：傾き(+: 右, -: 左)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public double? Slope { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public LegacyTurnStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public LegacyTurnStatement(double distance) : base(distance) { }
    }

    /// <summary>
    /// Include(FilePath);
    /// </summary>
    public class IncludeStatement : Statement
    {
        #region SyntaxInfo

        /// <summary>
        /// マップ要素名
        /// </summary>
        public override MapElementName ElementName => MapElementName.Include;

        /// <summary>
        /// キーを指定する構文か？
        /// </summary>
        public override bool HasKey => false;

        /// <summary>
        /// 副要素を指定する構文か？
        /// </summary>
        public override bool HasSubElement => false;
        #endregion SyntaxInfo

        #region Args

        /// <summary>
        /// 引数：挿入するMapファイルへの相対パス
        /// </summary>
        [Argument]
        public string FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public IncludeStatement() { }

        /// <summary>
        /// 距離程を指定して新しいインスタンスを生成します。
        /// </summary>
        public IncludeStatement(double distance) : base(distance) { }
    }
}
