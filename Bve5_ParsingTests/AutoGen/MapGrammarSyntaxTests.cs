/*
 * このファイルはdoc/createMapGrammarTemplate.jsによって自動生成されています。
 * 編集は行わないでください。
 */
using Xunit;
using Bve5_Parsing.MapGrammar.EvaluateData;
using static Bve5_ParsingTests.MapGrammarTestUtility;
using System.Collections.Generic;

namespace Bve5_ParsingTests
{
    public class MapGrammarSyntaxTests
    {

        #region 各構文のテスト

        /// <summary>
        /// Curve.SetGauge(Value);
        /// </summary>
        [Fact]
        public void CurveSetgaugeTest()
        {

            // Curve.SetGauge(Value);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.SetGauge(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveSetGaugeStatement(0)
                        {
                            Value = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Gauge.Set(Value);
        /// </summary>
        [Fact]
        public void GaugeSetTest()
        {

            // Gauge.Set(Value);
            Check(
                ExecParse("BveTs Map 2.02\n0;Gauge.Set(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new GaugeSetStatement(0)
                        {
                            Value = 1.0
                        }
                    }));

            // Gauge.Set(Value);
            Check(
                ExecParse("BveTs Map 2.00\n0;Gauge.Set(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new GaugeSetStatement(0)
                        {
                            Value = 1.0
                        }
                    }));

            // Gauge.Set(Value);
            Check(
                ExecParse("BveTs Map 1.00\n0;Gauge.Set(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new GaugeSetStatement(0)
                        {
                            Value = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Curve.Gauge(Value);
        /// </summary>
        [Fact]
        public void CurveGaugeTest()
        {

            // Curve.Gauge(Value);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.Gauge(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveGaugeStatement(0)
                        {
                            Value = 1.0
                        }
                    }));

            // Curve.Gauge(Value);
            Check(
                ExecParse("BveTs Map 2.00\n0;Curve.Gauge(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new CurveGaugeStatement(0)
                        {
                            Value = 1.0
                        }
                    }));

            // Curve.Gauge(Value);
            Check(
                ExecParse("BveTs Map 1.00\n0;Curve.Gauge(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new CurveGaugeStatement(0)
                        {
                            Value = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Curve.SetCenter(X);
        /// </summary>
        [Fact]
        public void CurveSetcenterTest()
        {

            // Curve.SetCenter(X);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.SetCenter(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveSetCenterStatement(0)
                        {
                            X = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Curve.SetFunction(Id);
        /// </summary>
        [Fact]
        public void CurveSetfunctionTest()
        {

            // Curve.SetFunction(Id);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.SetFunction(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveSetFunctionStatement(0)
                        {
                            Id = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Curve.BeginTransition();
        /// </summary>
        [Fact]
        public void CurveBegintransitionTest()
        {

            // Curve.BeginTransition();
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.BeginTransition();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveBeginTransitionStatement(0)
                    }));

            // Curve.BeginTransition();
            Check(
                ExecParse("BveTs Map 2.00\n0;Curve.BeginTransition();"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new CurveBeginTransitionStatement(0)
                    }));

            // Curve.BeginTransition();
            Check(
                ExecParse("BveTs Map 1.00\n0;Curve.BeginTransition();"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new CurveBeginTransitionStatement(0)
                    }));
        }

        /// <summary>
        /// Curve.Begin(Radius, Cant?);
        /// </summary>
        [Fact]
        public void CurveBeginTest()
        {

            // Curve.Begin(Radius);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.Begin(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveBeginStatement(0)
                        {
                            Radius = 1.0
                        }
                    }));

            // Curve.Begin(Radius, Cant);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.Begin(1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveBeginStatement(0)
                        {
                            Radius = 1.0,
                            Cant = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Curve.BeginCircular(Radius, Cant?);
        /// </summary>
        [Fact]
        public void CurveBegincircularTest()
        {

            // Curve.BeginCircular(Radius, Cant);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.BeginCircular(1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveBeginCircularStatement(0)
                        {
                            Radius = 1.0,
                            Cant = 1.0
                        }
                    }));

            // Curve.BeginCircular(Radius, Cant);
            Check(
                ExecParse("BveTs Map 2.00\n0;Curve.BeginCircular(1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new CurveBeginCircularStatement(0)
                        {
                            Radius = 1.0,
                            Cant = 1.0
                        }
                    }));

            // Curve.BeginCircular(Radius, Cant);
            Check(
                ExecParse("BveTs Map 1.00\n0;Curve.BeginCircular(1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new CurveBeginCircularStatement(0)
                        {
                            Radius = 1.0,
                            Cant = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Curve.End();
        /// </summary>
        [Fact]
        public void CurveEndTest()
        {

            // Curve.End();
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.End();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveEndStatement(0)
                    }));

            // Curve.End();
            Check(
                ExecParse("BveTs Map 2.00\n0;Curve.End();"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new CurveEndStatement(0)
                    }));

            // Curve.End();
            Check(
                ExecParse("BveTs Map 1.00\n0;Curve.End();"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new CurveEndStatement(0)
                    }));
        }

        /// <summary>
        /// Curve.Interpolate(Radius?, Cant?);
        /// </summary>
        [Fact]
        public void CurveInterpolateTest()
        {

            // Curve.Interpolate();
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.Interpolate();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveInterpolateStatement(0)
                    }));

            // Curve.Interpolate(Radius);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.Interpolate(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveInterpolateStatement(0)
                        {
                            Radius = 1.0
                        }
                    }));

            // Curve.Interpolate(Radius, Cant);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.Interpolate(1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveInterpolateStatement(0)
                        {
                            Radius = 1.0,
                            Cant = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Curve.Change(Radius);
        /// </summary>
        [Fact]
        public void CurveChangeTest()
        {

            // Curve.Change(Radius);
            Check(
                ExecParse("BveTs Map 2.02\n0;Curve.Change(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CurveChangeStatement(0)
                        {
                            Radius = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Gradient.BeginTransition();
        /// </summary>
        [Fact]
        public void GradientBegintransitionTest()
        {

            // Gradient.BeginTransition();
            Check(
                ExecParse("BveTs Map 2.02\n0;Gradient.BeginTransition();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new GradientBeginTransitionStatement(0)
                    }));

            // Gradient.BeginTransition();
            Check(
                ExecParse("BveTs Map 2.00\n0;Gradient.BeginTransition();"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new GradientBeginTransitionStatement(0)
                    }));

            // Gradient.BeginTransition();
            Check(
                ExecParse("BveTs Map 1.00\n0;Gradient.BeginTransition();"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new GradientBeginTransitionStatement(0)
                    }));
        }

        /// <summary>
        /// Gradient.Begin(Gradient);
        /// </summary>
        [Fact]
        public void GradientBeginTest()
        {

            // Gradient.Begin(Gradient);
            Check(
                ExecParse("BveTs Map 2.02\n0;Gradient.Begin(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new GradientBeginStatement(0)
                        {
                            Gradient = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Gradient.BeginConst(Gradient);
        /// </summary>
        [Fact]
        public void GradientBeginconstTest()
        {

            // Gradient.BeginConst(Gradient);
            Check(
                ExecParse("BveTs Map 2.02\n0;Gradient.BeginConst(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new GradientBeginConstStatement(0)
                        {
                            Gradient = 1.0
                        }
                    }));

            // Gradient.BeginConst(Gradient);
            Check(
                ExecParse("BveTs Map 2.00\n0;Gradient.BeginConst(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new GradientBeginConstStatement(0)
                        {
                            Gradient = 1.0
                        }
                    }));

            // Gradient.BeginConst(Gradient);
            Check(
                ExecParse("BveTs Map 1.00\n0;Gradient.BeginConst(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new GradientBeginConstStatement(0)
                        {
                            Gradient = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Gradient.End();
        /// </summary>
        [Fact]
        public void GradientEndTest()
        {

            // Gradient.End();
            Check(
                ExecParse("BveTs Map 2.02\n0;Gradient.End();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new GradientEndStatement(0)
                    }));

            // Gradient.End();
            Check(
                ExecParse("BveTs Map 2.00\n0;Gradient.End();"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new GradientEndStatement(0)
                    }));

            // Gradient.End();
            Check(
                ExecParse("BveTs Map 1.00\n0;Gradient.End();"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new GradientEndStatement(0)
                    }));
        }

        /// <summary>
        /// Gradient.Interpolate(Gradient?);
        /// </summary>
        [Fact]
        public void GradientInterpolateTest()
        {

            // Gradient.Interpolate();
            Check(
                ExecParse("BveTs Map 2.02\n0;Gradient.Interpolate();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new GradientInterpolateStatement(0)
                    }));

            // Gradient.Interpolate(Gradient);
            Check(
                ExecParse("BveTs Map 2.02\n0;Gradient.Interpolate(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new GradientInterpolateStatement(0)
                        {
                            Gradient = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].X.Interpolate(X?, Radius?);
        /// </summary>
        [Fact]
        public void TrackXInterpolateTest()
        {

            // Track[TrackKey].X.Interpolate();
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].X.Interpolate();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackXInterpolateStatement(0)
                        {
                            Key = "TrackKey",
                        }
                    }));

            // Track[TrackKey].X.Interpolate(X);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].X.Interpolate(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackXInterpolateStatement(0)
                        {
                            Key = "TrackKey",
                            X = 1.0
                        }
                    }));

            // Track[TrackKey].X.Interpolate(X, Radius);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].X.Interpolate(1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackXInterpolateStatement(0)
                        {
                            Key = "TrackKey",
                            X = 1.0,
                            Radius = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Y.Interpolate(Y?, Radius?);
        /// </summary>
        [Fact]
        public void TrackYInterpolateTest()
        {

            // Track[TrackKey].Y.Interpolate();
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Y.Interpolate();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackYInterpolateStatement(0)
                        {
                            Key = "TrackKey",
                        }
                    }));

            // Track[TrackKey].Y.Interpolate(Y);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Y.Interpolate(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackYInterpolateStatement(0)
                        {
                            Key = "TrackKey",
                            Y = 1.0
                        }
                    }));

            // Track[TrackKey].Y.Interpolate(Y, Radius);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Y.Interpolate(1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackYInterpolateStatement(0)
                        {
                            Key = "TrackKey",
                            Y = 1.0,
                            Radius = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Position(X, Y, RadiusH?, RadiusV?);
        /// </summary>
        [Fact]
        public void TrackPositionTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Track[TrackKey].Position(X, Y, RadiusH?, RadiusV?)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Track[TrackKey].Cant.SetGauge(Gauge);
        /// </summary>
        [Fact]
        public void TrackCantSetgaugeTest()
        {

            // Track[TrackKey].Cant.SetGauge(Gauge);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant.SetGauge(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantSetGaugeStatement(0)
                        {
                            Key = "TrackKey",
                            Gauge = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Gauge(Gauge);
        /// </summary>
        [Fact]
        public void TrackGaugeTest()
        {

            // Track[TrackKey].Gauge(Gauge);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Gauge(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackGaugeStatement(0)
                        {
                            Key = "TrackKey",
                            Gauge = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Cant.SetCenter(X);
        /// </summary>
        [Fact]
        public void TrackCantSetcenterTest()
        {

            // Track[TrackKey].Cant.SetCenter(X);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant.SetCenter(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantSetCenterStatement(0)
                        {
                            Key = "TrackKey",
                            X = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Cant.SetFunction(Id);
        /// </summary>
        [Fact]
        public void TrackCantSetfunctionTest()
        {

            // Track[TrackKey].Cant.SetFunction(Id);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant.SetFunction(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantSetFunctionStatement(0)
                        {
                            Key = "TrackKey",
                            Id = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Cant.BeginTransition();
        /// </summary>
        [Fact]
        public void TrackCantBegintransitionTest()
        {

            // Track[TrackKey].Cant.BeginTransition();
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant.BeginTransition();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantBeginTransitionStatement(0)
                        {
                            Key = "TrackKey",
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Cant.Begin(Cant);
        /// </summary>
        [Fact]
        public void TrackCantBeginTest()
        {

            // Track[TrackKey].Cant.Begin(Cant);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant.Begin(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantBeginStatement(0)
                        {
                            Key = "TrackKey",
                            Cant = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Cant.End();
        /// </summary>
        [Fact]
        public void TrackCantEndTest()
        {

            // Track[TrackKey].Cant.End();
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant.End();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantEndStatement(0)
                        {
                            Key = "TrackKey",
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Cant.Interpolate(Cant?);
        /// </summary>
        [Fact]
        public void TrackCantInterpolateTest()
        {

            // Track[TrackKey].Cant.Interpolate();
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant.Interpolate();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantInterpolateStatement(0)
                        {
                            Key = "TrackKey",
                        }
                    }));

            // Track[TrackKey].Cant.Interpolate(Cant);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant.Interpolate(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantInterpolateStatement(0)
                        {
                            Key = "TrackKey",
                            Cant = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Track[TrackKey].Cant(Cant?);
        /// </summary>
        [Fact]
        public void TrackCantTest()
        {

            // Track[TrackKey].Cant(Cant);
            Check(
                ExecParse("BveTs Map 2.02\n0;Track['TrackKey'].Cant(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantStatement(0)
                        {
                            Key = "TrackKey",
                            Cant = 1.0
                        }
                    }));

            // Track[TrackKey].Cant(Cant);
            Check(
                ExecParse("BveTs Map 2.00\n0;Track['TrackKey'].Cant(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantStatement(0)
                        {
                            Key = "TrackKey",
                            Cant = 1.0
                        }
                    }));

            // Track[TrackKey].Cant(Cant);
            Check(
                ExecParse("BveTs Map 1.00\n0;Track[TrackKey].Cant(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrackCantStatement(0)
                        {
                            Key = "TrackKey",
                            Cant = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Structure.Load(FilePath);
        /// </summary>
        [Fact]
        public void StructureLoadTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Structure.Load(FilePath)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Structure[StructureKey].Put(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
        /// </summary>
        [Fact]
        public void StructurePutTest()
        {

            // Structure[StructureKey].Put(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
            Check(
                ExecParse("BveTs Map 2.02\n0;Structure['StructureKey'].Put('string_test_value', 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new StructurePutStatement(0)
                        {
                            Key = "StructureKey",
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));

            // Structure[StructureKey].Put(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
            Check(
                ExecParse("BveTs Map 2.00\n0;Structure['StructureKey'].Put('string_test_value', 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new StructurePutStatement(0)
                        {
                            Key = "StructureKey",
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));

            // Structure[StructureKey].Put(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
            Check(
                ExecParse("BveTs Map 1.00\n0;Structure[StructureKey].Put(string_test_value, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new StructurePutStatement(0)
                        {
                            Key = "StructureKey",
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Structure[StructureKey].Put0(TrackKey, Tilt, Span);
        /// </summary>
        [Fact]
        public void StructurePut0Test()
        {

            // Structure[StructureKey].Put0(TrackKey, Tilt, Span);
            Check(
                ExecParse("BveTs Map 2.02\n0;Structure['StructureKey'].Put0('string_test_value', 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new StructurePut0Statement(0)
                        {
                            Key = "StructureKey",
                            TrackKey = "string_test_value",
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));

            // Structure[StructureKey].Put0(TrackKey, Tilt, Span);
            Check(
                ExecParse("BveTs Map 2.00\n0;Structure['StructureKey'].Put0('string_test_value', 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new StructurePut0Statement(0)
                        {
                            Key = "StructureKey",
                            TrackKey = "string_test_value",
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));

            // Structure[StructureKey].Put0(TrackKey, Tilt, Span);
            Check(
                ExecParse("BveTs Map 1.00\n0;Structure[StructureKey].Put0(string_test_value, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new StructurePut0Statement(0)
                        {
                            Key = "StructureKey",
                            TrackKey = "string_test_value",
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Structure[StructureKey].PutBetween(TrackKey1, TrackKey2, Flag?);
        /// </summary>
        [Fact]
        public void StructurePutbetweenTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Structure[StructureKey].PutBetween(TrackKey1, TrackKey2, Flag?)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Repeater[RepeaterKey].Begin(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span, Interval, StructureKey);
        /// </summary>
        [Fact]
        public void RepeaterBeginTest()
        {

            // Repeater[RepeaterKey].Begin(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span, Interval, StructureKey);
            Check(
                ExecParse("BveTs Map 2.02\n0;Repeater['RepeaterKey'].Begin('string_test_value', 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 'string_test_value', 'string_test_value', 'string_test_value', 'string_test_value', 'string_test_value');"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterBeginStatement(0)
                        {
                            Key = "RepeaterKey",
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0,
                            Interval = 1.0,
                        }
                        .SetStructureKeys("string_test_value", "string_test_value", "string_test_value", "string_test_value", "string_test_value")
                    }));

            // Repeater[RepeaterKey].Begin(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span, Interval, StructureKey);
            Check(
                ExecParse("BveTs Map 2.00\n0;Repeater['RepeaterKey'].Begin('string_test_value', 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 'string_test_value', 'string_test_value', 'string_test_value', 'string_test_value', 'string_test_value');"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterBeginStatement(0)
                        {
                            Key = "RepeaterKey",
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0,
                            Interval = 1.0,
                        }
                        .SetStructureKeys("string_test_value", "string_test_value", "string_test_value", "string_test_value", "string_test_value")
                    }));

            // Repeater[RepeaterKey].Begin(TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span, Interval, StructureKey);
            Check(
                ExecParse("BveTs Map 1.00\n0;Repeater[RepeaterKey].Begin(string_test_value, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, string_test_value, string_test_value, string_test_value, string_test_value, string_test_value);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterBeginStatement(0)
                        {
                            Key = "RepeaterKey",
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0,
                            Interval = 1.0,
                        }
                        .SetStructureKeys("string_test_value", "string_test_value", "string_test_value", "string_test_value", "string_test_value")
                    }));
        }

        /// <summary>
        /// Repeater[RepeaterKey].Begin0(TrackKey, Tilt, Span, Interval, StructureKey);
        /// </summary>
        [Fact]
        public void RepeaterBegin0Test()
        {

            // Repeater[RepeaterKey].Begin0(TrackKey, Tilt, Span, Interval, StructureKey);
            Check(
                ExecParse("BveTs Map 2.02\n0;Repeater['RepeaterKey'].Begin0('string_test_value', 1.0, 1.0, 1.0, 'string_test_value', 'string_test_value', 'string_test_value', 'string_test_value', 'string_test_value');"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterBegin0Statement(0)
                        {
                            Key = "RepeaterKey",
                            TrackKey = "string_test_value",
                            Tilt = 1.0,
                            Span = 1.0,
                            Interval = 1.0,
                        }
                        .SetStructureKeys("string_test_value", "string_test_value", "string_test_value", "string_test_value", "string_test_value")
                    }));

            // Repeater[RepeaterKey].Begin0(TrackKey, Tilt, Span, Interval, StructureKey);
            Check(
                ExecParse("BveTs Map 2.00\n0;Repeater['RepeaterKey'].Begin0('string_test_value', 1.0, 1.0, 1.0, 'string_test_value', 'string_test_value', 'string_test_value', 'string_test_value', 'string_test_value');"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterBegin0Statement(0)
                        {
                            Key = "RepeaterKey",
                            TrackKey = "string_test_value",
                            Tilt = 1.0,
                            Span = 1.0,
                            Interval = 1.0,
                        }
                        .SetStructureKeys("string_test_value", "string_test_value", "string_test_value", "string_test_value", "string_test_value")
                    }));

            // Repeater[RepeaterKey].Begin0(TrackKey, Tilt, Span, Interval, StructureKey);
            Check(
                ExecParse("BveTs Map 1.00\n0;Repeater[RepeaterKey].Begin0(string_test_value, 1.0, 1.0, 1.0, string_test_value, string_test_value, string_test_value, string_test_value, string_test_value);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterBegin0Statement(0)
                        {
                            Key = "RepeaterKey",
                            TrackKey = "string_test_value",
                            Tilt = 1.0,
                            Span = 1.0,
                            Interval = 1.0,
                        }
                        .SetStructureKeys("string_test_value", "string_test_value", "string_test_value", "string_test_value", "string_test_value")
                    }));
        }

        /// <summary>
        /// Repeater[RepeaterKey].End();
        /// </summary>
        [Fact]
        public void RepeaterEndTest()
        {

            // Repeater[RepeaterKey].End();
            Check(
                ExecParse("BveTs Map 2.02\n0;Repeater['RepeaterKey'].End();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterEndStatement(0)
                        {
                            Key = "RepeaterKey",
                        }
                    }));

            // Repeater[RepeaterKey].End();
            Check(
                ExecParse("BveTs Map 2.00\n0;Repeater['RepeaterKey'].End();"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterEndStatement(0)
                        {
                            Key = "RepeaterKey",
                        }
                    }));

            // Repeater[RepeaterKey].End();
            Check(
                ExecParse("BveTs Map 1.00\n0;Repeater[RepeaterKey].End();"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new RepeaterEndStatement(0)
                        {
                            Key = "RepeaterKey",
                        }
                    }));
        }

        /// <summary>
        /// Background.Change(StructureKey);
        /// </summary>
        [Fact]
        public void BackgroundChangeTest()
        {

            // Background.Change(StructureKey);
            Check(
                ExecParse("BveTs Map 2.02\n0;Background.Change('string_test_value');"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new BackgroundChangeStatement(0)
                        {
                            StructureKey = "string_test_value"
                        }
                    }));

            // Background.Change(StructureKey);
            Check(
                ExecParse("BveTs Map 2.00\n0;Background.Change('string_test_value');"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new BackgroundChangeStatement(0)
                        {
                            StructureKey = "string_test_value"
                        }
                    }));

            // Background.Change(StructureKey);
            Check(
                ExecParse("BveTs Map 1.00\n0;Background.Change(string_test_value);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new BackgroundChangeStatement(0)
                        {
                            StructureKey = "string_test_value"
                        }
                    }));
        }

        /// <summary>
        /// Station.Load(FilePath);
        /// </summary>
        [Fact]
        public void StationLoadTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Station.Load(FilePath)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Station[StationKey].Put(Door, Margin1, Margin2);
        /// </summary>
        [Fact]
        public void StationPutTest()
        {

            // Station[StationKey].Put(Door, Margin1, Margin2);
            Check(
                ExecParse("BveTs Map 2.02\n0;Station['StationKey'].Put(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new StationPutStatement(0)
                        {
                            Key = "StationKey",
                            Door = 1.0,
                            Margin1 = 1.0,
                            Margin2 = 1.0
                        }
                    }));

            // Station[StationKey].Put(Door, Margin1, Margin2);
            Check(
                ExecParse("BveTs Map 2.00\n0;Station['StationKey'].Put(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new StationPutStatement(0)
                        {
                            Key = "StationKey",
                            Door = 1.0,
                            Margin1 = 1.0,
                            Margin2 = 1.0
                        }
                    }));

            // Station[StationKey].Put(Door, Margin1, Margin2);
            Check(
                ExecParse("BveTs Map 1.00\n0;Station[StationKey].Put(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new StationPutStatement(0)
                        {
                            Key = "StationKey",
                            Door = 1.0,
                            Margin1 = 1.0,
                            Margin2 = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Section.Begin(Signal);
        /// </summary>
        [Fact]
        public void SectionBeginTest()
        {

            // Section.Begin(Signal);
            Check(
                ExecParse("BveTs Map 2.02\n0;Section.Begin(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SectionBeginStatement(0).SetAspects(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));
        }

        /// <summary>
        /// Section.BeginNew(Signal);
        /// </summary>
        [Fact]
        public void SectionBeginnewTest()
        {

            // Section.BeginNew(Signal);
            Check(
                ExecParse("BveTs Map 2.02\n0;Section.BeginNew(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SectionBeginNewStatement(0).SetAspects(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));

            // Section.BeginNew(Signal);
            Check(
                ExecParse("BveTs Map 2.00\n0;Section.BeginNew(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new SectionBeginNewStatement(0).SetAspects(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));

            // Section.BeginNew(Signal);
            Check(
                ExecParse("BveTs Map 1.00\n0;Section.BeginNew(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new SectionBeginNewStatement(0).SetAspects(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));
        }

        /// <summary>
        /// Section.SetSpeedLimit(V);
        /// </summary>
        [Fact]
        public void SectionSetspeedlimitTest()
        {

            // Section.SetSpeedLimit(V);
            Check(
                ExecParse("BveTs Map 2.02\n0;Section.SetSpeedLimit(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SectionSetSpeedLimitStatement(0).SetSpeedLimits(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));
        }

        /// <summary>
        /// Signal.SpeedLimit(V);
        /// </summary>
        [Fact]
        public void SignalSpeedlimitTest()
        {

            // Signal.SpeedLimit(V);
            Check(
                ExecParse("BveTs Map 2.02\n0;Signal.SpeedLimit(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SignalSpeedLimitStatement(0).SetSpeedLimits(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));

            // Signal.SpeedLimit(V);
            Check(
                ExecParse("BveTs Map 2.00\n0;Signal.SpeedLimit(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new SignalSpeedLimitStatement(0).SetSpeedLimits(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));

            // Signal.SpeedLimit(V);
            Check(
                ExecParse("BveTs Map 1.00\n0;Signal.SpeedLimit(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new SignalSpeedLimitStatement(0).SetSpeedLimits(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));
        }

        /// <summary>
        /// SpeedLimit.SetSignal(V);
        /// </summary>
        [Fact]
        public void SpeedlimitSetsignalTest()
        {

            // SpeedLimit.SetSignal(V);
            Check(
                ExecParse("BveTs Map 2.02\n0;SpeedLimit.SetSignal(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitSetSignalStatement(0).SetSpeedLimits(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));

            // SpeedLimit.SetSignal(V);
            Check(
                ExecParse("BveTs Map 2.00\n0;SpeedLimit.SetSignal(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitSetSignalStatement(0).SetSpeedLimits(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));

            // SpeedLimit.SetSignal(V);
            Check(
                ExecParse("BveTs Map 1.00\n0;SpeedLimit.SetSignal(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitSetSignalStatement(0).SetSpeedLimits(1.0, 1.0, 1.0, 1.0, 1.0)
                    }));
        }

        /// <summary>
        /// Signal.Load(FilePath);
        /// </summary>
        [Fact]
        public void SignalLoadTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Signal.Load(FilePath)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Signal[SignalAspectKey].Put(Section, TrackKey, X, Y, Z?, RX?, RY?, RZ?, Tilt?, Span?);
        /// </summary>
        [Fact]
        public void SignalPutTest()
        {

            // Signal[SignalAspectKey].Put(Section, TrackKey, X, Y);
            Check(
                ExecParse("BveTs Map 2.02\n0;Signal['SignalAspectKey'].Put(1.0, 'string_test_value', 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SignalPutStatement(0)
                        {
                            Key = "SignalAspectKey",
                            Section = 1.0,
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0
                        }
                    }));

            // Signal[SignalAspectKey].Put(Section, TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
            Check(
                ExecParse("BveTs Map 2.02\n0;Signal['SignalAspectKey'].Put(1.0, 'string_test_value', 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SignalPutStatement(0)
                        {
                            Key = "SignalAspectKey",
                            Section = 1.0,
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));

            // Signal[SignalAspectKey].Put(Section, TrackKey, X, Y);
            Check(
                ExecParse("BveTs Map 2.00\n0;Signal['SignalAspectKey'].Put(1.0, 'string_test_value', 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new SignalPutStatement(0)
                        {
                            Key = "SignalAspectKey",
                            Section = 1.0,
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0
                        }
                    }));

            // Signal[SignalAspectKey].Put(Section, TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
            Check(
                ExecParse("BveTs Map 2.00\n0;Signal['SignalAspectKey'].Put(1.0, 'string_test_value', 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new SignalPutStatement(0)
                        {
                            Key = "SignalAspectKey",
                            Section = 1.0,
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));

            // Signal[SignalAspectKey].Put(Section, TrackKey, X, Y);
            Check(
                ExecParse("BveTs Map 1.00\n0;Signal[SignalAspectKey].Put(1.0, string_test_value, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new SignalPutStatement(0)
                        {
                            Key = "SignalAspectKey",
                            Section = 1.0,
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0
                        }
                    }));

            // Signal[SignalAspectKey].Put(Section, TrackKey, X, Y, Z, RX, RY, RZ, Tilt, Span);
            Check(
                ExecParse("BveTs Map 1.00\n0;Signal[SignalAspectKey].Put(1.0, string_test_value, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new SignalPutStatement(0)
                        {
                            Key = "SignalAspectKey",
                            Section = 1.0,
                            TrackKey = "string_test_value",
                            X = 1.0,
                            Y = 1.0,
                            Z = 1.0,
                            RX = 1.0,
                            RY = 1.0,
                            RZ = 1.0,
                            Tilt = 1.0,
                            Span = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Beacon.Put(Type, Section, Senddata);
        /// </summary>
        [Fact]
        public void BeaconPutTest()
        {

            // Beacon.Put(Type, Section, Senddata);
            Check(
                ExecParse("BveTs Map 2.02\n0;Beacon.Put(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new BeaconPutStatement(0)
                        {
                            Type = 1.0,
                            Section = 1.0,
                            Senddata = 1.0
                        }
                    }));

            // Beacon.Put(Type, Section, Senddata);
            Check(
                ExecParse("BveTs Map 2.00\n0;Beacon.Put(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new BeaconPutStatement(0)
                        {
                            Type = 1.0,
                            Section = 1.0,
                            Senddata = 1.0
                        }
                    }));

            // Beacon.Put(Type, Section, Senddata);
            Check(
                ExecParse("BveTs Map 1.00\n0;Beacon.Put(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new BeaconPutStatement(0)
                        {
                            Type = 1.0,
                            Section = 1.0,
                            Senddata = 1.0
                        }
                    }));
        }

        /// <summary>
        /// SpeedLimit.Begin(V);
        /// </summary>
        [Fact]
        public void SpeedLimitBeginTest()
        {

            // SpeedLimit.Begin(V);
            Check(
                ExecParse("BveTs Map 2.02\n0;SpeedLimit.Begin(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitBeginStatement(0)
                        {
                            V = 1.0
                        }
                    }));

            // SpeedLimit.Begin(V);
            Check(
                ExecParse("BveTs Map 2.00\n0;SpeedLimit.Begin(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitBeginStatement(0)
                        {
                            V = 1.0
                        }
                    }));

            // SpeedLimit.Begin(V);
            Check(
                ExecParse("BveTs Map 1.00\n0;SpeedLimit.Begin(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitBeginStatement(0)
                        {
                            V = 1.0
                        }
                    }));
        }

        /// <summary>
        /// SpeedLimit.End();
        /// </summary>
        [Fact]
        public void SpeedlimitEndTest()
        {

            // SpeedLimit.End();
            Check(
                ExecParse("BveTs Map 2.02\n0;SpeedLimit.End();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitEndStatement(0)
                    }));

            // SpeedLimit.End();
            Check(
                ExecParse("BveTs Map 2.00\n0;SpeedLimit.End();"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitEndStatement(0)
                    }));

            // SpeedLimit.End();
            Check(
                ExecParse("BveTs Map 1.00\n0;SpeedLimit.End();"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new SpeedLimitEndStatement(0)
                    }));
        }

        /// <summary>
        /// Pretrain.Pass(Time?, Second?);
        /// </summary>
        [Fact]
        public void PretrainPassTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Pretrain.Pass(Time?, Second?)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Light.Ambient(Red, Green, Blue);
        /// </summary>
        [Fact]
        public void LightAmbientTest()
        {

            // Light.Ambient(Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 2.02\n0;Light.Ambient(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new LightAmbientStatement(0)
                        {
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));

            // Light.Ambient(Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 2.00\n0;Light.Ambient(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new LightAmbientStatement(0)
                        {
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));

            // Light.Ambient(Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 1.00\n0;Light.Ambient(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new LightAmbientStatement(0)
                        {
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Light.Diffuse(Red, Green, Blue);
        /// </summary>
        [Fact]
        public void LightDiffuseTest()
        {

            // Light.Diffuse(Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 2.02\n0;Light.Diffuse(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new LightDiffuseStatement(0)
                        {
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));

            // Light.Diffuse(Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 2.00\n0;Light.Diffuse(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new LightDiffuseStatement(0)
                        {
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));

            // Light.Diffuse(Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 1.00\n0;Light.Diffuse(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new LightDiffuseStatement(0)
                        {
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Light.Direction(Pitch, Yaw);
        /// </summary>
        [Fact]
        public void LightDirectionTest()
        {

            // Light.Direction(Pitch, Yaw);
            Check(
                ExecParse("BveTs Map 2.02\n0;Light.Direction(1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new LightDirectionStatement(0)
                        {
                            Pitch = 1.0,
                            Yaw = 1.0
                        }
                    }));

            // Light.Direction(Pitch, Yaw);
            Check(
                ExecParse("BveTs Map 2.00\n0;Light.Direction(1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new LightDirectionStatement(0)
                        {
                            Pitch = 1.0,
                            Yaw = 1.0
                        }
                    }));

            // Light.Direction(Pitch, Yaw);
            Check(
                ExecParse("BveTs Map 1.00\n0;Light.Direction(1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new LightDirectionStatement(0)
                        {
                            Pitch = 1.0,
                            Yaw = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Fog.Interpolate(Density?, Red?, Green?, Blue?);
        /// </summary>
        [Fact]
        public void FogInterpolateTest()
        {

            // Fog.Interpolate();
            Check(
                ExecParse("BveTs Map 2.02\n0;Fog.Interpolate();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new FogInterpolateStatement(0)
                    }));

            // Fog.Interpolate(Density);
            Check(
                ExecParse("BveTs Map 2.02\n0;Fog.Interpolate(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new FogInterpolateStatement(0)
                        {
                            Density = 1.0
                        }
                    }));

            // Fog.Interpolate(Density, Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 2.02\n0;Fog.Interpolate(1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new FogInterpolateStatement(0)
                        {
                            Density = 1.0,
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Fog.Set(Density?, Red?, Green?, Blue?);
        /// </summary>
        [Fact]
        public void FogSetTest()
        {

            // Fog.Set(Density, Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 2.02\n0;Fog.Set(1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new FogSetStatement(0)
                        {
                            Density = 1.0,
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));

            // Fog.Set(Density, Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 2.00\n0;Fog.Set(1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new FogSetStatement(0)
                        {
                            Density = 1.0,
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));

            // Fog.Set(Density, Red, Green, Blue);
            Check(
                ExecParse("BveTs Map 1.00\n0;Fog.Set(1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new FogSetStatement(0)
                        {
                            Density = 1.0,
                            Red = 1.0,
                            Green = 1.0,
                            Blue = 1.0
                        }
                    }));
        }

        /// <summary>
        /// DrawDistance.Change(Value);
        /// </summary>
        [Fact]
        public void DrawdistanceChangeTest()
        {

            // DrawDistance.Change(Value);
            Check(
                ExecParse("BveTs Map 2.02\n0;DrawDistance.Change(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new DrawDistanceChangeStatement(0)
                        {
                            Value = 1.0
                        }
                    }));
        }

        /// <summary>
        /// CabIlluminance.Interpolate(Value?);
        /// </summary>
        [Fact]
        public void CabilluminanceInterpolateTest()
        {

            // CabIlluminance.Interpolate();
            Check(
                ExecParse("BveTs Map 2.02\n0;CabIlluminance.Interpolate();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CabIlluminanceInterpolateStatement(0)
                    }));

            // CabIlluminance.Interpolate(Value);
            Check(
                ExecParse("BveTs Map 2.02\n0;CabIlluminance.Interpolate(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CabIlluminanceInterpolateStatement(0)
                        {
                            Value = 1.0
                        }
                    }));
        }

        /// <summary>
        /// CabIlluminance.Set(Value);
        /// </summary>
        [Fact]
        public void CabilluminanceSetTest()
        {

            // CabIlluminance.Set(Value);
            Check(
                ExecParse("BveTs Map 2.02\n0;CabIlluminance.Set(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new CabIlluminanceSetStatement(0)
                        {
                            Value = 1.0
                        }
                    }));

            // CabIlluminance.Set(Value);
            Check(
                ExecParse("BveTs Map 2.00\n0;CabIlluminance.Set(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new CabIlluminanceSetStatement(0)
                        {
                            Value = 1.0
                        }
                    }));

            // CabIlluminance.Set(Value);
            Check(
                ExecParse("BveTs Map 1.00\n0;CabIlluminance.Set(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new CabIlluminanceSetStatement(0)
                        {
                            Value = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Irregularity.Change(X, Y, R, LX, LY, LR);
        /// </summary>
        [Fact]
        public void IrregularityChangeTest()
        {

            // Irregularity.Change(X, Y, R, LX, LY, LR);
            Check(
                ExecParse("BveTs Map 2.02\n0;Irregularity.Change(1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new IrregularityChangeStatement(0)
                        {
                            X = 1.0,
                            Y = 1.0,
                            R = 1.0,
                            LX = 1.0,
                            LY = 1.0,
                            LR = 1.0
                        }
                    }));

            // Irregularity.Change(X, Y, R, LX, LY, LR);
            Check(
                ExecParse("BveTs Map 2.00\n0;Irregularity.Change(1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new IrregularityChangeStatement(0)
                        {
                            X = 1.0,
                            Y = 1.0,
                            R = 1.0,
                            LX = 1.0,
                            LY = 1.0,
                            LR = 1.0
                        }
                    }));

            // Irregularity.Change(X, Y, R, LX, LY, LR);
            Check(
                ExecParse("BveTs Map 1.00\n0;Irregularity.Change(1.0, 1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new IrregularityChangeStatement(0)
                        {
                            X = 1.0,
                            Y = 1.0,
                            R = 1.0,
                            LX = 1.0,
                            LY = 1.0,
                            LR = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Adhesion.Change(A, B?, C?);
        /// </summary>
        [Fact]
        public void AdhesionChangeTest()
        {

            // Adhesion.Change(A);
            Check(
                ExecParse("BveTs Map 2.02\n0;Adhesion.Change(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new AdhesionChangeStatement(0)
                        {
                            A = 1.0
                        }
                    }));

            // Adhesion.Change(A, B, C);
            Check(
                ExecParse("BveTs Map 2.02\n0;Adhesion.Change(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new AdhesionChangeStatement(0)
                        {
                            A = 1.0,
                            B = 1.0,
                            C = 1.0
                        }
                    }));

            // Adhesion.Change(A);
            Check(
                ExecParse("BveTs Map 2.00\n0;Adhesion.Change(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new AdhesionChangeStatement(0)
                        {
                            A = 1.0
                        }
                    }));

            // Adhesion.Change(A, B, C);
            Check(
                ExecParse("BveTs Map 2.00\n0;Adhesion.Change(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new AdhesionChangeStatement(0)
                        {
                            A = 1.0,
                            B = 1.0,
                            C = 1.0
                        }
                    }));

            // Adhesion.Change(A);
            Check(
                ExecParse("BveTs Map 1.00\n0;Adhesion.Change(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new AdhesionChangeStatement(0)
                        {
                            A = 1.0
                        }
                    }));

            // Adhesion.Change(A, B, C);
            Check(
                ExecParse("BveTs Map 1.00\n0;Adhesion.Change(1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new AdhesionChangeStatement(0)
                        {
                            A = 1.0,
                            B = 1.0,
                            C = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Sound.Load(FilePath);
        /// </summary>
        [Fact]
        public void SoundLoadTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Sound.Load(FilePath)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Sound[SoundKey].Play();
        /// </summary>
        [Fact]
        public void SoundPlayTest()
        {

            // Sound[SoundKey].Play();
            Check(
                ExecParse("BveTs Map 2.02\n0;Sound['SoundKey'].Play();"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new SoundPlayStatement(0)
                        {
                            Key = "SoundKey",
                        }
                    }));

            // Sound[SoundKey].Play();
            Check(
                ExecParse("BveTs Map 2.00\n0;Sound['SoundKey'].Play();"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new SoundPlayStatement(0)
                        {
                            Key = "SoundKey",
                        }
                    }));

            // Sound[SoundKey].Play();
            Check(
                ExecParse("BveTs Map 1.00\n0;Sound[SoundKey].Play();"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new SoundPlayStatement(0)
                        {
                            Key = "SoundKey",
                        }
                    }));
        }

        /// <summary>
        /// Sound3d.Load(FilePath);
        /// </summary>
        [Fact]
        public void Sound3dLoadTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Sound3d.Load(FilePath)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Sound3d[SoundKey].Put(X, Y);
        /// </summary>
        [Fact]
        public void Sound3dPutTest()
        {

            // Sound3d[SoundKey].Put(X, Y);
            Check(
                ExecParse("BveTs Map 2.02\n0;Sound3d['SoundKey'].Put(1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new Sound3dPutStatement(0)
                        {
                            Key = "SoundKey",
                            X = 1.0,
                            Y = 1.0
                        }
                    }));

            // Sound3d[SoundKey].Put(X, Y);
            Check(
                ExecParse("BveTs Map 2.00\n0;Sound3d['SoundKey'].Put(1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new Sound3dPutStatement(0)
                        {
                            Key = "SoundKey",
                            X = 1.0,
                            Y = 1.0
                        }
                    }));

            // Sound3d[SoundKey].Put(X, Y);
            Check(
                ExecParse("BveTs Map 1.00\n0;Sound3d[SoundKey].Put(1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new Sound3dPutStatement(0)
                        {
                            Key = "SoundKey",
                            X = 1.0,
                            Y = 1.0
                        }
                    }));
        }

        /// <summary>
        /// RollingNoise.Change(Index);
        /// </summary>
        [Fact]
        public void RollingnoiseChangeTest()
        {

            // RollingNoise.Change(Index);
            Check(
                ExecParse("BveTs Map 2.02\n0;RollingNoise.Change(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new RollingNoiseChangeStatement(0)
                        {
                            Index = 1.0
                        }
                    }));

            // RollingNoise.Change(Index);
            Check(
                ExecParse("BveTs Map 2.00\n0;RollingNoise.Change(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new RollingNoiseChangeStatement(0)
                        {
                            Index = 1.0
                        }
                    }));

            // RollingNoise.Change(Index);
            Check(
                ExecParse("BveTs Map 1.00\n0;RollingNoise.Change(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new RollingNoiseChangeStatement(0)
                        {
                            Index = 1.0
                        }
                    }));
        }

        /// <summary>
        /// FlangeNoise.Change(Index);
        /// </summary>
        [Fact]
        public void FlangenoiseChangeTest()
        {

            // FlangeNoise.Change(Index);
            Check(
                ExecParse("BveTs Map 2.02\n0;FlangeNoise.Change(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new FlangeNoiseChangeStatement(0)
                        {
                            Index = 1.0
                        }
                    }));

            // FlangeNoise.Change(Index);
            Check(
                ExecParse("BveTs Map 2.00\n0;FlangeNoise.Change(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new FlangeNoiseChangeStatement(0)
                        {
                            Index = 1.0
                        }
                    }));

            // FlangeNoise.Change(Index);
            Check(
                ExecParse("BveTs Map 1.00\n0;FlangeNoise.Change(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new FlangeNoiseChangeStatement(0)
                        {
                            Index = 1.0
                        }
                    }));
        }

        /// <summary>
        /// JointNoise.Play(Index);
        /// </summary>
        [Fact]
        public void JointnoisePlayTest()
        {

            // JointNoise.Play(Index);
            Check(
                ExecParse("BveTs Map 2.02\n0;JointNoise.Play(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new JointNoisePlayStatement(0)
                        {
                            Index = 1.0
                        }
                    }));

            // JointNoise.Play(Index);
            Check(
                ExecParse("BveTs Map 2.00\n0;JointNoise.Play(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new JointNoisePlayStatement(0)
                        {
                            Index = 1.0
                        }
                    }));

            // JointNoise.Play(Index);
            Check(
                ExecParse("BveTs Map 1.00\n0;JointNoise.Play(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new JointNoisePlayStatement(0)
                        {
                            Index = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Train.Add(TrainKey, FilePath, TrackKey?, Direction?);
        /// </summary>
        [Fact]
        public void TrainAddTest()
        {

            // Train.Add(TrainKey, FilePath);
            Check(
                ExecParse("BveTs Map 2.02\n0;Train.Add('string_test_value', 'string_test_value');"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrainAddStatement(0)
                        {
                            TrainKey = "string_test_value",
                            FilePath = "string_test_value"
                        }
                    }));

            // Train.Add(TrainKey, FilePath, TrackKey, Direction);
            Check(
                ExecParse("BveTs Map 2.02\n0;Train.Add('string_test_value', 'string_test_value', 'string_test_value', 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrainAddStatement(0)
                        {
                            TrainKey = "string_test_value",
                            FilePath = "string_test_value",
                            TrackKey = "string_test_value",
                            Direction = 1.0
                        }
                    }));

            // Train.Add(TrainKey, FilePath);
            Check(
                ExecParse("BveTs Map 2.00\n0;Train.Add('string_test_value', 'string_test_value');"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrainAddStatement(0)
                        {
                            TrainKey = "string_test_value",
                            FilePath = "string_test_value"
                        }
                    }));

            // Train.Add(TrainKey, FilePath, TrackKey, Direction);
            Check(
                ExecParse("BveTs Map 2.00\n0;Train.Add('string_test_value', 'string_test_value', 'string_test_value', 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrainAddStatement(0)
                        {
                            TrainKey = "string_test_value",
                            FilePath = "string_test_value",
                            TrackKey = "string_test_value",
                            Direction = 1.0
                        }
                    }));

            // Train.Add(TrainKey, FilePath);
            Check(
                ExecParse("BveTs Map 1.00\n0;Train.Add(string_test_value, string_test_value);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrainAddStatement(0)
                        {
                            TrainKey = "string_test_value",
                            FilePath = "string_test_value"
                        }
                    }));

            // Train.Add(TrainKey, FilePath, TrackKey, Direction);
            Check(
                ExecParse("BveTs Map 1.00\n0;Train.Add(string_test_value, string_test_value, string_test_value, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrainAddStatement(0)
                        {
                            TrainKey = "string_test_value",
                            FilePath = "string_test_value",
                            TrackKey = "string_test_value",
                            Direction = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Train[TrainKey].Load(FilePath, TrackKey, Direction);
        /// </summary>
        [Fact]
        public void TrainLoadTest()
        {

            // Train[TrainKey].Load(FilePath, TrackKey, Direction);
            Check(
                ExecParse("BveTs Map 2.02\n0;Train['TrainKey'].Load('string_test_value', 'string_test_value', 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrainLoadStatement(0)
                        {
                            Key = "TrainKey",
                            FilePath = "string_test_value",
                            TrackKey = "string_test_value",
                            Direction = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Train[TrainKey].Enable(Time?, Second?);
        /// </summary>
        [Fact]
        public void TrainEnableTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Train[TrainKey].Enable(Time?, Second?)構文のテストは手動で作成してください。
             */
        }

        /// <summary>
        /// Train[TrainKey].Stop(Decelerate, StopTime, Accelerate, Speed);
        /// </summary>
        [Fact]
        public void TrainStopTest()
        {

            // Train[TrainKey].Stop(Decelerate, StopTime, Accelerate, Speed);
            Check(
                ExecParse("BveTs Map 2.02\n0;Train['TrainKey'].Stop(1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrainStopStatement(0)
                        {
                            Key = "TrainKey",
                            Decelerate = 1.0,
                            StopTime = 1.0,
                            Accelerate = 1.0,
                            Speed = 1.0
                        }
                    }));

            // Train[TrainKey].Stop(Decelerate, StopTime, Accelerate, Speed);
            Check(
                ExecParse("BveTs Map 2.00\n0;Train['TrainKey'].Stop(1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrainStopStatement(0)
                        {
                            Key = "TrainKey",
                            Decelerate = 1.0,
                            StopTime = 1.0,
                            Accelerate = 1.0,
                            Speed = 1.0
                        }
                    }));

            // Train[TrainKey].Stop(Decelerate, StopTime, Accelerate, Speed);
            Check(
                ExecParse("BveTs Map 1.00\n0;Train[TrainKey].Stop(1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrainStopStatement(0)
                        {
                            Key = "TrainKey",
                            Decelerate = 1.0,
                            StopTime = 1.0,
                            Accelerate = 1.0,
                            Speed = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Train[TrainKey].SetTrack(TrackKey, Direction);
        /// </summary>
        [Fact]
        public void TrainSettrackTest()
        {

            // Train[TrainKey].SetTrack(TrackKey, Direction);
            Check(
                ExecParse("BveTs Map 2.02\n0;Train['TrainKey'].SetTrack('string_test_value', 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new TrainSetTrackStatement(0)
                        {
                            Key = "TrainKey",
                            TrackKey = "string_test_value",
                            Direction = 1.0
                        }
                    }));

            // Train[TrainKey].SetTrack(TrackKey, Direction);
            Check(
                ExecParse("BveTs Map 2.00\n0;Train['TrainKey'].SetTrack('string_test_value', 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrainSetTrackStatement(0)
                        {
                            Key = "TrainKey",
                            TrackKey = "string_test_value",
                            Direction = 1.0
                        }
                    }));

            // Train[TrainKey].SetTrack(TrackKey, Direction);
            Check(
                ExecParse("BveTs Map 1.00\n0;Train[TrainKey].SetTrack(string_test_value, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new TrainSetTrackStatement(0)
                        {
                            Key = "TrainKey",
                            TrackKey = "string_test_value",
                            Direction = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Legacy.Fog(Fogstart, Fogend, red, green, blue);
        /// </summary>
        [Fact]
        public void LegacyFogTest()
        {

            // Legacy.Fog(Fogstart, Fogend, red, green, blue);
            Check(
                ExecParse("BveTs Map 2.02\n0;Legacy.Fog(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyFogStatement(0)
                        {
                            Fogstart = 1.0,
                            Fogend = 1.0,
                            red = 1.0,
                            green = 1.0,
                            blue = 1.0
                        }
                    }));

            // Legacy.Fog(Fogstart, Fogend, red, green, blue);
            Check(
                ExecParse("BveTs Map 2.00\n0;Legacy.Fog(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyFogStatement(0)
                        {
                            Fogstart = 1.0,
                            Fogend = 1.0,
                            red = 1.0,
                            green = 1.0,
                            blue = 1.0
                        }
                    }));

            // Legacy.Fog(Fogstart, Fogend, red, green, blue);
            Check(
                ExecParse("BveTs Map 1.00\n0;Legacy.Fog(1.0, 1.0, 1.0, 1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyFogStatement(0)
                        {
                            Fogstart = 1.0,
                            Fogend = 1.0,
                            red = 1.0,
                            green = 1.0,
                            blue = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Legacy.Curve(Radius, Cant);
        /// </summary>
        [Fact]
        public void LegacyCurveTest()
        {

            // Legacy.Curve(Radius, Cant);
            Check(
                ExecParse("BveTs Map 2.02\n0;Legacy.Curve(1.0, 1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyCurveStatement(0)
                        {
                            Radius = 1.0,
                            Cant = 1.0
                        }
                    }));

            // Legacy.Curve(Radius, Cant);
            Check(
                ExecParse("BveTs Map 2.00\n0;Legacy.Curve(1.0, 1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyCurveStatement(0)
                        {
                            Radius = 1.0,
                            Cant = 1.0
                        }
                    }));

            // Legacy.Curve(Radius, Cant);
            Check(
                ExecParse("BveTs Map 1.00\n0;Legacy.Curve(1.0, 1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyCurveStatement(0)
                        {
                            Radius = 1.0,
                            Cant = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Legacy.Pitch(Rate?);
        /// </summary>
        [Fact]
        public void LegacyPitchTest()
        {

            // Legacy.Pitch(Rate);
            Check(
                ExecParse("BveTs Map 2.02\n0;Legacy.Pitch(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyPitchStatement(0)
                        {
                            Rate = 1.0
                        }
                    }));

            // Legacy.Pitch(Rate);
            Check(
                ExecParse("BveTs Map 2.00\n0;Legacy.Pitch(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyPitchStatement(0)
                        {
                            Rate = 1.0
                        }
                    }));

            // Legacy.Pitch(Rate);
            Check(
                ExecParse("BveTs Map 1.00\n0;Legacy.Pitch(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyPitchStatement(0)
                        {
                            Rate = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Legacy.Turn(Slope?);
        /// </summary>
        [Fact]
        public void LegacyTurnTest()
        {

            // Legacy.Turn(Slope);
            Check(
                ExecParse("BveTs Map 2.02\n0;Legacy.Turn(1.0);"),
                new MapData(
                    version: "2.02",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyTurnStatement(0)
                        {
                            Slope = 1.0
                        }
                    }));

            // Legacy.Turn(Slope);
            Check(
                ExecParse("BveTs Map 2.00\n0;Legacy.Turn(1.0);"),
                new MapData(
                    version: "2.00",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyTurnStatement(0)
                        {
                            Slope = 1.0
                        }
                    }));

            // Legacy.Turn(Slope);
            Check(
                ExecParse("BveTs Map 1.00\n0;Legacy.Turn(1.0);"),
                new MapData(
                    version: "1.00",
                    syntaxes: new List<Statement>()
                    {
                        new LegacyTurnStatement(0)
                        {
                            Slope = 1.0
                        }
                    }));
        }

        /// <summary>
        /// Include(FilePath);
        /// </summary>
        [Fact]
        public void IncludeTest()
        {
            /*
             * THIS TEST IS SKIPPED.
             * この構文のテストは諸事情によりテストの自動生成から外されました。
             * Include(FilePath)構文のテストは手動で作成してください。
             */
        }
        #endregion
    }
}
