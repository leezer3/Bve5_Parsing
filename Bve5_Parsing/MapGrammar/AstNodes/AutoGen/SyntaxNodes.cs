﻿/*
 * このファイルはdoc/createMapGrammarTemplate.jsによって自動生成されています。
 * 編集は行わないでください。
 */
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Antlr4.Runtime;
using Bve5_Parsing.MapGrammar.Attributes;

namespace Bve5_Parsing.MapGrammar.AstNodes {

    /// <summary>
    /// Curve.SetGauge(Value);
    /// </summary>
    public partial class CurveSetGaugeNode : SyntaxNode
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
        public MapGrammarAstNodes Value { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveSetGaugeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Gauge.Set(Value);
    /// </summary>
    [Deprecated]
    public partial class GaugeSetNode : CurveSetGaugeNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public GaugeSetNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.Gauge(Value);
    /// </summary>
    [Deprecated]
    public partial class CurveGaugeNode : CurveSetGaugeNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveGaugeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.SetCenter(X);
    /// </summary>
    public partial class CurveSetCenterNode : SyntaxNode
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
        public MapGrammarAstNodes X { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveSetCenterNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.SetFunction(Id);
    /// </summary>
    public partial class CurveSetFunctionNode : SyntaxNode
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
        public MapGrammarAstNodes Id { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveSetFunctionNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.BeginTransition();
    /// </summary>
    public partial class CurveBeginTransitionNode : SyntaxNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveBeginTransitionNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.Begin(Radius, Cant?);
    /// </summary>
    public partial class CurveBeginNode : SyntaxNode
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
        public MapGrammarAstNodes Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveBeginNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.BeginCircular(Radius, Cant?);
    /// </summary>
    [Deprecated]
    public partial class CurveBeginCircularNode : CurveBeginNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveBeginCircularNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.End();
    /// </summary>
    public partial class CurveEndNode : SyntaxNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveEndNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.Interpolate(Radius?, Cant?);
    /// </summary>
    public partial class CurveInterpolateNode : SyntaxNode
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
        public MapGrammarAstNodes Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveInterpolateNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Curve.Change(Radius);
    /// </summary>
    public partial class CurveChangeNode : SyntaxNode
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
        public MapGrammarAstNodes Radius { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CurveChangeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Gradient.BeginTransition();
    /// </summary>
    public partial class GradientBeginTransitionNode : SyntaxNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public GradientBeginTransitionNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Gradient.Begin(Gradient);
    /// </summary>
    public partial class GradientBeginNode : SyntaxNode
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
        public MapGrammarAstNodes Gradient { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public GradientBeginNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Gradient.BeginConst(Gradient);
    /// </summary>
    [Deprecated]
    public partial class GradientBeginConstNode : GradientBeginNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public GradientBeginConstNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Gradient.End();
    /// </summary>
    public partial class GradientEndNode : SyntaxNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public GradientEndNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Gradient.Interpolate(Gradient?);
    /// </summary>
    public partial class GradientInterpolateNode : SyntaxNode
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
        public MapGrammarAstNodes Gradient { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public GradientInterpolateNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].X.Interpolate(X?, Radius?);
    /// </summary>
    public partial class TrackXInterpolateNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの x 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes X { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との平面曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Radius { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackXInterpolateNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Y.Interpolate(Y?, Radius?);
    /// </summary>
    public partial class TrackYInterpolateNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの y 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Y { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との縦曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Radius { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackYInterpolateNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Position(X, Y, RadiusH?, RadiusV?);
    /// </summary>
    public partial class TrackPositionNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：自軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes X { get; set; }

        /// <summary>
        /// 引数：自軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Y { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との平面曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes RadiusH { get; set; }

        /// <summary>
        /// 引数：現在の距離程以降の自軌道との縦曲線相対半径 [m] (0: 直線)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes RadiusV { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackPositionNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.SetGauge(Gauge);
    /// </summary>
    public partial class TrackCantSetGaugeNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：軌間 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Gauge { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackCantSetGaugeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Gauge(Gauge);
    /// </summary>
    [Deprecated]
    public partial class TrackGaugeNode : TrackCantSetGaugeNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackGaugeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.SetCenter(X);
    /// </summary>
    public partial class TrackCantSetCenterNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：回転中心の x 座標 [m] (正: 曲線の内側, 負: 曲線の外側)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes X { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackCantSetCenterNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.SetFunction(Id);
    /// </summary>
    public partial class TrackCantSetFunctionNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：関数番号 (0: サイン半波長逓減, 1: 直線逓減)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Id { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackCantSetFunctionNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.BeginTransition();
    /// </summary>
    public partial class TrackCantBeginTransitionNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackCantBeginTransitionNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.Begin(Cant);
    /// </summary>
    public partial class TrackCantBeginNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：カント [m] (正: 右に傾ける, 負: 左に傾ける)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackCantBeginNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.End();
    /// </summary>
    public partial class TrackCantEndNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackCantEndNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant.Interpolate(Cant?);
    /// </summary>
    public partial class TrackCantInterpolateNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：カント [m] (正: 右に傾ける, 負: 左に傾ける)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackCantInterpolateNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Track[TrackKey].Cant(Cant?);
    /// </summary>
    [Deprecated]
    public partial class TrackCantNode : TrackCantInterpolateNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrackCantNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Structure.Load(FilePath);
    /// </summary>
    public partial class StructureLoadNode : SyntaxNode
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
        public MapGrammarAstNodes FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public StructureLoadNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Structure[StructureKey].Put(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
    /// </summary>
    public partial class StructurePutNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Span { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public StructurePutNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Structure[StructureKey].Put0(TrackKey, Tilt, Span);
    /// </summary>
    public partial class StructurePut0Node : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Span { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public StructurePut0Node(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Structure[StructureKey].PutBetween(TrackKey1, TrackKey2, Flag?);
    /// </summary>
    public partial class StructurePutBetweenNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：一方の軌道の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey1 { get; set; }

        /// <summary>
        /// 引数：他方の軌道の軌道名
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey2 { get; set; }

        /// <summary>
        /// 引数：変形方向 (0: x および y 方向に変形, 1: x 方向のみに変形)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Flag { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public StructurePutBetweenNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Repeater[RepeaterKey].Begin(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span, Interval, StructureKey);
    /// </summary>
    public partial class RepeaterBeginNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Span { get; set; }

        /// <summary>
        /// 引数：配置間隔 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Interval { get; set; }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）のリスト
        /// </summary>
        protected List<MapGrammarAstNodes> _structurekeys = new List<MapGrammarAstNodes>();

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）の読み取り専用コレクション
        /// </summary>
        public ReadOnlyCollection<MapGrammarAstNodes> StructureKeys => _structurekeys.AsReadOnly();
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public RepeaterBeginNode(IToken start, IToken stop) : base(start, stop) { }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）を追加します。
        /// </summary>
        public void AddStructureKey(MapGrammarAstNodes structurekey)
        {
            _structurekeys.Add(structurekey);
        }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）を複数追加します。
        /// </summary>
        public void AddStructureKeys(IEnumerable<MapGrammarAstNodes> structurekeys)
        {
            _structurekeys.AddRange(structurekeys);
        }
    }

    /// <summary>
    /// Repeater[RepeaterKey].Begin0(TrackKey, Tilt, Span, Interval, StructureKey);
    /// </summary>
    public partial class RepeaterBegin0Node : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：配置先の軌道名 (0: 自軌道)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Span { get; set; }

        /// <summary>
        /// 引数：配置間隔 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Interval { get; set; }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）のリスト
        /// </summary>
        protected List<MapGrammarAstNodes> _structurekeys = new List<MapGrammarAstNodes>();

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）の読み取り専用コレクション
        /// </summary>
        public ReadOnlyCollection<MapGrammarAstNodes> StructureKeys => _structurekeys.AsReadOnly();
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public RepeaterBegin0Node(IToken start, IToken stop) : base(start, stop) { }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）を追加します。
        /// </summary>
        public void AddStructureKey(MapGrammarAstNodes structurekey)
        {
            _structurekeys.Add(structurekey);
        }

        /// <summary>
        /// 可変長引数：ストラクチャー名 (ストラクチャーリストファイルで定義した文字列）を複数追加します。
        /// </summary>
        public void AddStructureKeys(IEnumerable<MapGrammarAstNodes> structurekeys)
        {
            _structurekeys.AddRange(structurekeys);
        }
    }

    /// <summary>
    /// Repeater[RepeaterKey].End();
    /// </summary>
    public partial class RepeaterEndNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public RepeaterEndNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Background.Change(StructureKey);
    /// </summary>
    public partial class BackgroundChangeNode : SyntaxNode
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
        public MapGrammarAstNodes StructureKey { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public BackgroundChangeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Station.Load(FilePath);
    /// </summary>
    public partial class StationLoadNode : SyntaxNode
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
        public MapGrammarAstNodes FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public StationLoadNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Station[StationKey].Put(Door, Margin1, Margin2);
    /// </summary>
    public partial class StationPutNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：開くドアの方向 (-1: 左, 1: 右)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Door { get; set; }

        /// <summary>
        /// 引数：停止位置誤差の後方許容範囲 (負の値で設定)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Margin1 { get; set; }

        /// <summary>
        /// 引数：停止位置誤差の後方許容範囲
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Margin2 { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public StationPutNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Section.Begin(Signal);
    /// </summary>
    public partial class SectionBeginNode : SyntaxNode
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
        protected List<MapGrammarAstNodes> _signals = new List<MapGrammarAstNodes>();

        /// <summary>
        /// 可変長引数：先行列車が n 閉そく先に存在する場合の信号インデックス（0: この閉塞）の読み取り専用コレクション
        /// </summary>
        public ReadOnlyCollection<MapGrammarAstNodes> Signals => _signals.AsReadOnly();
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SectionBeginNode(IToken start, IToken stop) : base(start, stop) { }

        /// <summary>
        /// 可変長引数：先行列車が n 閉そく先に存在する場合の信号インデックス（0: この閉塞）を追加します。
        /// </summary>
        public void AddSignal(MapGrammarAstNodes signal)
        {
            _signals.Add(signal);
        }

        /// <summary>
        /// 可変長引数：先行列車が n 閉そく先に存在する場合の信号インデックス（0: この閉塞）を複数追加します。
        /// </summary>
        public void AddSignals(IEnumerable<MapGrammarAstNodes> signals)
        {
            _signals.AddRange(signals);
        }
    }

    /// <summary>
    /// Section.BeginNew(Signal);
    /// </summary>
    [Deprecated]
    public partial class SectionBeginNewNode : SectionBeginNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SectionBeginNewNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Section.SetSpeedLimit(V);
    /// </summary>
    public partial class SectionSetSpeedLimitNode : SyntaxNode
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
        protected List<MapGrammarAstNodes> _vs = new List<MapGrammarAstNodes>();

        /// <summary>
        /// 可変長引数：走行速度 [km/h] （null: 許容速度なし）の読み取り専用コレクション
        /// </summary>
        public ReadOnlyCollection<MapGrammarAstNodes> Vs => _vs.AsReadOnly();
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SectionSetSpeedLimitNode(IToken start, IToken stop) : base(start, stop) { }

        /// <summary>
        /// 可変長引数：走行速度 [km/h] （null: 許容速度なし）を追加します。
        /// </summary>
        public void AddV(MapGrammarAstNodes v)
        {
            _vs.Add(v);
        }

        /// <summary>
        /// 可変長引数：走行速度 [km/h] （null: 許容速度なし）を複数追加します。
        /// </summary>
        public void AddVs(IEnumerable<MapGrammarAstNodes> vs)
        {
            _vs.AddRange(vs);
        }
    }

    /// <summary>
    /// Signal.SpeedLimit(V);
    /// </summary>
    [Deprecated]
    public partial class SignalSpeedLimitNode : SectionSetSpeedLimitNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SignalSpeedLimitNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// SpeedLimit.SetSignal(V);
    /// </summary>
    [Deprecated]
    public partial class SpeedLimitSetSignalNode : SectionSetSpeedLimitNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SpeedLimitSetSignalNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Signal.Load(FilePath);
    /// </summary>
    public partial class SignalLoadNode : SyntaxNode
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
        public MapGrammarAstNodes FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SignalLoadNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Signal[SignalAspectKey].Put(Section, TrackKey, X, Y, Z?, RX?, RY?, RZ?, Tilt?, Span?);
    /// </summary>
    public partial class SignalPutNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：関連づける閉そくの相対インデックス
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Section { get; set; }

        /// <summary>
        /// 引数：配置先の軌道名
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey { get; set; }

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Y { get; set; }

        /// <summary>
        /// 引数：軌道からの z 座標 [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Z { get; set; }

        /// <summary>
        /// 引数：軌道に対する x 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes RX { get; set; }

        /// <summary>
        /// 引数：軌道に対する y 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes RY { get; set; }

        /// <summary>
        /// 引数：軌道に対する z 軸回りの角 [deg]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes RZ { get; set; }

        /// <summary>
        /// 引数：傾斜オプション (0: 常に水平, 1: 勾配に連動, 2: カントに連動, 3: 勾配とカントに連動)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Tilt { get; set; }

        /// <summary>
        /// 引数：曲線における弦の長さ [m]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Span { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SignalPutNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Beacon.Put(Type, Section, Senddata);
    /// </summary>
    public partial class BeaconPutNode : SyntaxNode
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
        public MapGrammarAstNodes Type { get; set; }

        /// <summary>
        /// 引数：関連づける閉そくの相対インデックス
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Section { get; set; }

        /// <summary>
        /// 引数：保安装置に送る値 (整数)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Senddata { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public BeaconPutNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// SpeedLimit.Begin(V);
    /// </summary>
    public partial class SpeedLimitBeginNode : SyntaxNode
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
        public MapGrammarAstNodes V { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SpeedLimitBeginNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// SpeedLimit.End();
    /// </summary>
    public partial class SpeedLimitEndNode : SyntaxNode
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
        public MapGrammarAstNodes V { get; set; }
        #endregion Args
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SpeedLimitEndNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Pretrain.Pass(Time?, Second?);
    /// </summary>
    public partial class PretrainPassNode : SyntaxNode
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
        public MapGrammarAstNodes Time { get; set; }

        /// <summary>
        /// 引数：00:00:00 からの経過時間 [sec]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Second { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public PretrainPassNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Light.Ambient(Red, Green, Blue);
    /// </summary>
    public partial class LightAmbientNode : SyntaxNode
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
        public MapGrammarAstNodes Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Blue { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public LightAmbientNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Light.Diffuse(Red, Green, Blue);
    /// </summary>
    public partial class LightDiffuseNode : SyntaxNode
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
        public MapGrammarAstNodes Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Blue { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public LightDiffuseNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Light.Direction(Pitch, Yaw);
    /// </summary>
    public partial class LightDirectionNode : SyntaxNode
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
        public MapGrammarAstNodes Pitch { get; set; }

        /// <summary>
        /// 引数：回転角
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Yaw { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public LightDirectionNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Fog.Interpolate(Density?, Red?, Green?, Blue?);
    /// </summary>
    public partial class FogInterpolateNode : SyntaxNode
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
        public MapGrammarAstNodes Density { get; set; }

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Blue { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public FogInterpolateNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Fog.Set(Density?, Red?, Green?, Blue?);
    /// </summary>
    [Deprecated]
    public partial class FogSetNode : FogInterpolateNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public FogSetNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// DrawDistance.Change(Value);
    /// </summary>
    public partial class DrawDistanceChangeNode : SyntaxNode
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
        public MapGrammarAstNodes Value { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public DrawDistanceChangeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// CabIlluminance.Interpolate(Value?);
    /// </summary>
    public partial class CabIlluminanceInterpolateNode : SyntaxNode
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
        public MapGrammarAstNodes Value { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CabIlluminanceInterpolateNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// CabIlluminance.Set(Value);
    /// </summary>
    [Deprecated]
    public partial class CabIlluminanceSetNode : CabIlluminanceInterpolateNode
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
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public CabIlluminanceSetNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Irregularity.Change(X, Y, R, LX, LY, LR);
    /// </summary>
    public partial class IrregularityChangeNode : SyntaxNode
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
        public MapGrammarAstNodes X { get; set; }

        /// <summary>
        /// 引数：上下変位 (左と右のレールの高低変位の平均に相当) の標準偏差 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Y { get; set; }

        /// <summary>
        /// 引数：ロール変位 (水準変位を軌間で除した値に相当) の標準偏差 [rad]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes R { get; set; }

        /// <summary>
        /// 引数：左右変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes LX { get; set; }

        /// <summary>
        /// 引数：上下変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes LY { get; set; }

        /// <summary>
        /// 引数：ロール変位の遮断波長 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes LR { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public IrregularityChangeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Adhesion.Change(A, B?, C?);
    /// </summary>
    public partial class AdhesionChangeNode : SyntaxNode
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
        public MapGrammarAstNodes A { get; set; }

        /// <summary>
        /// 引数：粘着係数の走行速度に対する変化を表す係数（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes B { get; set; }

        /// <summary>
        /// 引数：粘着係数の走行速度に対する変化を表す係数（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes C { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public AdhesionChangeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Sound.Load(FilePath);
    /// </summary>
    public partial class SoundLoadNode : SyntaxNode
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
        public MapGrammarAstNodes FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SoundLoadNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Sound[SoundKey].Play();
    /// </summary>
    public partial class SoundPlayNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }


        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public SoundPlayNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Sound3d.Load(FilePath);
    /// </summary>
    public partial class Sound3dLoadNode : SyntaxNode
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
        public MapGrammarAstNodes FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public Sound3dLoadNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Sound3d[SoundKey].Put(X, Y);
    /// </summary>
    public partial class Sound3dPutNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：軌道からの x 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes X { get; set; }

        /// <summary>
        /// 引数：軌道からの y 座標 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Y { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public Sound3dPutNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// RollingNoise.Change(Index);
    /// </summary>
    public partial class RollingNoiseChangeNode : SyntaxNode
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
        public MapGrammarAstNodes Index { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public RollingNoiseChangeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// FlangeNoise.Change(Index);
    /// </summary>
    public partial class FlangeNoiseChangeNode : SyntaxNode
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
        public MapGrammarAstNodes Index { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public FlangeNoiseChangeNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// JointNoise.Play(Index);
    /// </summary>
    public partial class JointNoisePlayNode : SyntaxNode
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
        public MapGrammarAstNodes Index { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public JointNoisePlayNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Train.Add(TrainKey, FilePath, TrackKey?, Direction?);
    /// </summary>
    public partial class TrainAddNode : SyntaxNode
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
        public MapGrammarAstNodes TrainKey { get; set; }

        /// <summary>
        /// 引数：このファイルから他列車ファイルへの相対パス
        /// </summary>
        [Argument]
        public MapGrammarAstNodes FilePath { get; set; }

        /// <summary>
        /// 引数：走行する軌道（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes TrackKey { get; set; }

        /// <summary>
        /// 引数：進行方向 (-1: 対向, 1: 並走)（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Direction { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrainAddNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Train[TrainKey].Load(FilePath, TrackKey, Direction);
    /// </summary>
    public partial class TrainLoadNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：このファイルから他列車ファイルへの相対パス
        /// </summary>
        [Argument]
        public MapGrammarAstNodes FilePath { get; set; }

        /// <summary>
        /// 引数：走行する軌道
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey { get; set; }

        /// <summary>
        /// 引数：進行方向 (-1: 対向, 1: 並走)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Direction { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrainLoadNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Train[TrainKey].Enable(Time?, Second?);
    /// </summary>
    public partial class TrainEnableNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：時刻を表す文字列 ('hh:mm:ss')（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Time { get; set; }

        /// <summary>
        /// 引数：00:00:00 からの経過時間 [sec]（省略可能）
        /// </summary>
        [Argument(Optional = true)]
        public MapGrammarAstNodes Second { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrainEnableNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Train[TrainKey].Stop(Decelerate, StopTime, Accelerate, Speed);
    /// </summary>
    public partial class TrainStopNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：減速度 [km/h/s]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Decelerate { get; set; }

        /// <summary>
        /// 引数：停車時間 [s]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes StopTime { get; set; }

        /// <summary>
        /// 引数：加速度 [km/h/s]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Accelerate { get; set; }

        /// <summary>
        /// 引数：加速後の走行速度 [km/h]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Speed { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrainStopNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Train[TrainKey].SetTrack(TrackKey, Direction);
    /// </summary>
    public partial class TrainSetTrackNode : SyntaxNode
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
        public override MapGrammarAstNodes Key { get; set; }

        #region Args

        /// <summary>
        /// 引数：走行する軌道
        /// </summary>
        [Argument]
        public MapGrammarAstNodes TrackKey { get; set; }

        /// <summary>
        /// 引数：進行方向 (-1: 対向, 1: 並走)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Direction { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public TrainSetTrackNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Legacy.Fog(Fogstart, Fogend, red, green, blue);
    /// </summary>
    [Deprecated]
    public partial class LegacyFogNode : SyntaxNode
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
        public MapGrammarAstNodes Fogstart { get; set; }

        /// <summary>
        /// 引数：視界が0%になる距離 [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Fogend { get; set; }

        /// <summary>
        /// 引数：赤成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes red { get; set; }

        /// <summary>
        /// 引数：緑成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes green { get; set; }

        /// <summary>
        /// 引数：青成分 (0 ~ 1)
        /// </summary>
        [Argument]
        public MapGrammarAstNodes blue { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public LegacyFogNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Legacy.Curve(Radius, Cant);
    /// </summary>
    [Deprecated]
    public partial class LegacyCurveNode : SyntaxNode
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
        public MapGrammarAstNodes Radius { get; set; }

        /// <summary>
        /// 引数：カント [m]
        /// </summary>
        [Argument]
        public MapGrammarAstNodes Cant { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public LegacyCurveNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Legacy.Pitch(Rate?);
    /// </summary>
    [Deprecated]
    public partial class LegacyPitchNode : SyntaxNode
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
        public MapGrammarAstNodes Rate { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public LegacyPitchNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Legacy.Turn(Slope?);
    /// </summary>
    [Deprecated]
    public partial class LegacyTurnNode : SyntaxNode
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
        public MapGrammarAstNodes slope { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public LegacyTurnNode(IToken start, IToken stop) : base(start, stop) { }
    }

    /// <summary>
    /// Include(FilePath);
    /// </summary>
    public partial class IncludeNode : SyntaxNode
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
        public MapGrammarAstNodes FilePath { get; set; }
        #endregion Args

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        public IncludeNode(IToken start, IToken stop) : base(start, stop) { }
    }
}
