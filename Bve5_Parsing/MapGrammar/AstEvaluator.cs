using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Bve5_Parsing.MapGrammar.AstNodes;
using Bve5_Parsing.MapGrammar.EvaluateData;

namespace Bve5_Parsing.MapGrammar
{

    /// <summary>
    /// ASTノードの評価手続きクラス
    /// </summary>
    public class EvaluateMapGrammarVisitor : AstVisitor<object>
    {
        /// <summary>
        /// 変数管理
        /// </summary>
        protected VariableStore Store;

        protected internal ParseErrorListener ErrorListener;

        /// <summary>
        /// 評価結果
        /// </summary>
        protected MapData evaluateData;

        /// <summary>
        /// 現在評価中の距離程
        /// </summary>
        public double NowDistance { get; protected set; } = 0;

        public EvaluateMapGrammarVisitor(VariableStore store, ParseErrorListener errorListener) : this(store, errorListener, 0.0)
        {
        }

        public EvaluateMapGrammarVisitor(VariableStore store, ParseErrorListener errorListener, double nowDistance)
        {
            Store = store;
            ErrorListener = errorListener;
            NowDistance = nowDistance;
        }

        /// <summary>
        /// ルートノードの評価
        /// </summary>
        /// <param name="node">ルートノード</param>
        /// <returns>解析結果のMapData</returns>
        public override object Visit(RootNode node)
        {
            evaluateData = new MapData(node.Version, node.Encoding);

            foreach (var state in node.StatementList)
            {
                object childData = Visit(state);
                if (childData != null)
                    evaluateData.AddStatement((Statement)childData);
            }

            return evaluateData;
        }

        /// <summary>
        /// 距離程の評価
        /// </summary>
        /// <param name="node">距離程ノード</param>
        /// <returns>null</returns>
        public override object Visit(DistanceNode node)
        {
            NowDistance = Convert.ToDouble(Visit(node.Value));

            return null;
        }

        #region 未使用（あとで消す）

        /// <summary>
        /// 構文タイプ1の評価
        /// </summary>
        /// <param name="node">Syntax1Node</param>
        /// <returns>解析結果のSyntaxDataクラス</returns>
        public override object Visit(Syntax1Node node)
        {
            SyntaxData returnData = new SyntaxData(NowDistance, node.MapElementName, node.FunctionName);
            foreach (string key in node.Arguments.Keys)
            {
                if (node.Arguments[key] != null)
                    returnData.SetArg(key, Visit(node.Arguments[key]));
                else
                    returnData.SetArg(key, null);
            }

            return returnData;
        }

        /// <summary>
        /// 構文タイプ2の評価
        /// </summary>
        /// <param name="node">Syntax2Node</param>
        /// <returns>解析結果のSyntaxDataクラス</returns>
        public override object Visit(Syntax2Node node)
        {
            SyntaxData returnData = new SyntaxData(NowDistance, node.MapElementName, node.FunctionName, Visit(node.Key).ToString());
            foreach (string key in node.Arguments.Keys)
            {
                if (node.Arguments[key] != null)
                    returnData.SetArg(key, Visit(node.Arguments[key]));
                else
                    returnData.SetArg(key, null);
            }

            return returnData;
        }

        /// <summary>
        /// 構文タイプ3の評価
        /// </summary>
        /// <param name="node">Syntax3Node</param>
        /// <returns>解析結果のSyntaxDataクラス</returns>
        public override object Visit(Syntax3Node node)
        {
            SyntaxData returnData = new SyntaxData();
            //構文情報を登録する
            returnData.Distance = NowDistance;
            returnData.MapElement = node.MapElementNames;
            returnData.Key = Visit(node.Key).ToString();
            returnData.Function = node.FunctionName;
            foreach (string key in node.Arguments.Keys)
            {
                if (node.Arguments[key] != null)
                    returnData.SetArg(key, Visit(node.Arguments[key]));
                else
                    returnData.SetArg(key, null);
            }

            return returnData;
        }

        /// <summary>
        /// リストファイルノードの評価
        /// リストファイルの参照パスを追加する
        /// </summary>
        /// <param name="node">リストファイルノード</param>
        /// <returns>null</returns>
        public override object Visit(LoadListNode node)
        {
            if (node.Path == null)
                ErrorListener.AddNewError(ParseMessageType.FilePathNotSpecified, null, node.Start);
            else
                evaluateData.SetListPathToString(node.MapElementName, node.Path);

            return null;
        }
        #endregion

        #region リストファイルロード構文
        public override object Visit(StructureLoadNode node)
        {
            evaluateData.StructureListPath = Visit(node.FilePath).ToString();
            return null;
        }

        public override object Visit(StationLoadNode node)
        {
            evaluateData.StationListPath = Visit(node.FilePath).ToString();
            return null;
        }

        public override object Visit(SignalLoadNode node)
        {
            evaluateData.SignalListPath = Visit(node.FilePath).ToString();
            return null;
        }

        public override object Visit(SoundLoadNode node)
        {
            evaluateData.SoundListPath = Visit(node.FilePath).ToString();
            return null;
        }

        public override object Visit(Sound3dLoadNode node)
        {
            evaluateData.Sound3DListPath = Visit(node.FilePath).ToString();
            return null;
        }
        #endregion

        #region 自動生成構文
        public override object Visit(CurveSetGaugeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveSetCenterNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveSetFunctionNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveBeginTransitionNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveBeginNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveEndNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveInterpolateNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveChangeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(GradientBeginTransitionNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(GradientBeginNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(GradientEndNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(GradientInterpolateNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackXInterpolateNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackYInterpolateNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackPositionNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackCantSetGaugeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackCantSetCenterNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackCantSetFunctionNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackCantBeginTransitionNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackCantBeginNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackCantEndNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackCantInterpolateNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(StructurePutNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(StructurePut0Node node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(StructurePutBetweenNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(RepeaterBeginNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(RepeaterBegin0Node node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(RepeaterEndNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(BackgroundChangeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(StationPutNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SectionBeginNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SectionSetSpeedLimitNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SectionBeginNewNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SignalSpeedLimitNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SignalPutNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(BeaconPutNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SpeedLimitBeginNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SpeedLimitEndNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SpeedLimitSetSignalNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(PretrainPassNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(LightAmbientNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(LightDiffuseNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(LightDirectionNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(FogInterpolateNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(DrawDistanceChangeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CabIlluminanceInterpolateNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(IrregularityChangeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(AdhesionChangeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(SoundPlayNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(Sound3dPutNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(RollingNoiseChangeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(FlangeNoiseChangeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(JointNoisePlayNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrainAddNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrainLoadNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrainEnableNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrainStopNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrainSetTrackNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(IncludeNode node)
        {
            return node.CreateStatement(this);
        }


        public override object Visit(GaugeSetNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveGaugeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CurveBeginCircularNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(GradientBeginConstNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackGaugeNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(TrackCantNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(FogSetNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(CabIlluminanceSetNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(LegacyFogNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(LegacyCurveNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(LegacyPitchNode node)
        {
            return node.CreateStatement(this);
        }

        public override object Visit(LegacyTurnNode node)
        {
            return node.CreateStatement(this);
        }
        #endregion

        /// <summary>
        /// 変数宣言ノードの評価
        /// </summary>
        /// <param name="node">変数宣言ノード</param>
        /// <returns>null</returns>
        public override object Visit(VarAssignNode node)
        {
            var val = Visit(node.Value);
            Store.SetVar(node.VarName, val);
            return null;
        }

        #region 数式ノードの評価

        /// <summary>
        /// 加算ノードの評価
        /// </summary>
        /// <param name="node">加算ノード</param>
        /// <returns>演算後の数値(Double)、もしくは文字列(String)</returns>
        public override object Visit(AdditionNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);
            if (left is string || right is string)
                return left.ToString() + right.ToString(); //文字列の結合

            return Convert.ToDouble(left) + Convert.ToDouble(right);

        }

        /// <summary>
        /// 減算ノードの評価
        /// </summary>
        /// <param name="node">減算ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(SubtractionNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);
            if (left == null || right == null)
                return null;
            if (left is string || right is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"{left} - {right}");
                return null;
            }

            return Convert.ToDouble(left) - Convert.ToDouble(right);
        }

        /// <summary>
        /// 乗算ノードの評価
        /// </summary>
        /// <param name="node">乗算ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(MultiplicationNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);
            if (left == null || right == null)
                return null;
            if (left is string || right is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"{left} * {right}");
                return null;
            }

            return Convert.ToDouble(left) * Convert.ToDouble(right);
        }

        /// <summary>
        /// 除算ノードの評価
        /// </summary>
        /// <param name="node">除算ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(DivisionNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);
            if (left == null || right == null)
                return null;
            if (left is string || right is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"{left} / {right}");
                return null;
            }

            if (Convert.ToDouble(right) == 0)
            {
                return 0;
            }
            return Convert.ToDouble(left) / Convert.ToDouble(right);
        }

        /// <summary>
        /// ユーナリ演算ノードの評価
        /// </summary>
        /// <param name="node">ユーナリ演算ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(UnaryNode node)
        {
            var inner = Visit(node.InnerNode);
            if (inner == null)
                return null;
            if (inner is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"- {inner}");
                return null;
            }
            return -Convert.ToDouble(Visit(node.InnerNode));
        }

        /// <summary>
        /// 剰余算ノードの評価
        /// </summary>
        /// <param name="node">剰余算ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(ModuloNode node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);
            if (left == null || right == null)
                return null;
            if (left is string || right is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"{left} % {right}");
                return null;
            }

            return Convert.ToDouble(left) % Convert.ToDouble(right);
        }

        /// <summary>
        /// 絶対値関数の評価
        /// </summary>
        /// <param name="node">絶対値関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(AbsNode node)
        {
            var value = Visit(node.Value);
            if (value == null)
                return null;
            if (value is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"abs({value})");
                return null;
            }
            return Math.Abs(Convert.ToDouble(value));
        }

        /// <summary>
        /// Atan2関数の評価
        /// </summary>
        /// <param name="node">Atan2ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(Atan2Node node)
        {
            var y = Visit(node.Y);
            var x = Visit(node.X);
            if (y == null || x == null)
                return null;
            if (y is string || x is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"atan2({y}, {x})");
                return null;
            }

            return Math.Atan2(Convert.ToDouble(y), Convert.ToDouble(x));
        }

        /// <summary>
        /// 切り上げ関数の評価
        /// </summary>
        /// <param name="node">切り上げ関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(CeilNode node)
        {
            var value = Visit(node.Value);
            if (value == null)
                return null;
            if (value is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"ceil({value})");
                return null;
            }
            return Math.Ceiling(Convert.ToDouble(value));
        }

        /// <summary>
        /// 余弦関数の評価
        /// </summary>
        /// <param name="node">余弦関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(CosNode node)
        {
            var value = Visit(node.Value);
            if (value == null)
                return null;
            if (value is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"cos({value})");
                return null;
            }
            return Math.Cos(Convert.ToDouble(value));
        }

        /// <summary>
        /// 累乗関数の評価
        /// </summary>
        /// <param name="node">累乗関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(ExpNode node)
        {
            var value = Visit(node.Value);
            if (value == null)
                return null;
            if (value is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"exp({value})");
                return null;
            }
            return Math.Exp(Convert.ToDouble(value));
        }

        /// <summary>
        /// 切り捨て関数の評価
        /// </summary>
        /// <param name="node">切り捨て関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(FloorNode node)
        {
            var value = Visit(node.Value);
            if (value == null)
                return null;
            if (value is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"floor({value})");
                return null;
            }
            return Math.Floor(Convert.ToDouble(value));
        }

        /// <summary>
        /// 自然対数関数の評価
        /// </summary>
        /// <param name="node">自然対数関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(LogNode node)
        {
            var value = Visit(node.Value);
            if (value == null)
                return null;
            if (value is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"log({value})");
                return null;
            }
            return Math.Log(Convert.ToDouble(value));
        }

        /// <summary>
        /// べき乗関数の評価
        /// </summary>
        /// <param name="node">べき乗関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(PowNode node)
        {
            var x = Visit(node.X);
            var y = Visit(node.Y);
            if (x == null || y == null)
                return null;
            if (x is string || y is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"pow({x}, {y})");
                return null;
            }
            return Math.Pow(Convert.ToDouble(x), Convert.ToDouble(y));
        }

        /// <summary>
        /// 乱数関数の評価
        /// </summary>
        /// <param name="node">乱数関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(RandNode node)
        {
            Random random = new Random();

            if (node.Value == null)
                return random.NextDouble();

            var value = Visit(node.Value);
            if (value == null)
                return random.NextDouble();
            if (value is string || Convert.ToInt32(value) < 0)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"rand({value})");
                return null;
            }

            return random.Next(Convert.ToInt32(value));
        }

        /// <summary>
        /// 正弦関数の評価
        /// </summary>
        /// <param name="node">正弦関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(SinNode node)
        {
            var value = Visit(node.Value);
            if (value == null)
                return null;
            if (value is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"sin({value})");
                return null;
            }
            return Math.Sin(Convert.ToDouble(value));
        }

        /// <summary>
        /// 平方根関数の評価
        /// </summary>
        /// <param name="node">平方根関数ノード</param>
        /// <returns>演算後の数値(Double)</returns>
        public override object Visit(SqrtNode node)
        {
            var value = Visit(node.Value);
            if (value == null)
                return null;
            if (value is string)
            {
                ErrorListener.AddNewError(ParseMessageType.InvalidExpression, null, node.Start, $"sqrt({value})");
                return null;
            }
            return Math.Sqrt(Convert.ToDouble(value));
        }

        /// <summary>
        /// 数値の評価
        /// </summary>
        /// <param name="node">数値ノード</param>
        /// <returns>数値(String)</returns>
        public override object Visit(NumberNode node)
        {
            return double.Parse(node.Value.Text, System.Globalization.NumberStyles.AllowDecimalPoint);
        }

        /// <summary>
        /// Distance変数の評価
        /// 現在の距離程を返します。
        /// </summary>
        /// <param name="node">距離程変数ノード</param>
        /// <returns>現在の距離程(Double)</returns>
        public override object Visit(DistanceVariableNode node)
        {
            return NowDistance;
        }

        /// <summary>
        /// 文字列の評価
        /// </summary>
        /// <param name="node">文字列ノード</param>
        /// <returns>文字列(String)</returns>
        public override object Visit(StringNode node)
        {
            return node.Value;
        }

        /// <summary>
        /// 変数の評価
        /// </summary>
        /// <param name="node">変数ノード</param>
        /// <returns>変数に対応する値(Double)</returns>
        public override object Visit(VarNode node)
        {
            return Store.GetVar(node.Key);
        }

        #endregion 数式ノードの評価
    }

    /// <summary>
    /// ASTノードの評価手続きクラス(Include構文対応)
    /// </summary>
    public class EvaluateMapGrammarVisitorWithInclude : EvaluateMapGrammarVisitor
    {

        private readonly string dirAbsolutePath;

        /// <summary>
        /// Include先ファイルの絶対パスを取得します。
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string GetIncludeAbsolutePath(string path)
        {
            if (string.IsNullOrEmpty(path))
                return path;
            if (path.ToLowerInvariant().IndexOf(@"atsex::") != -1)
            {
                throw new NotSupportedException("ATS-EX is not currently supported. ");
            }
            var fileRelativePath = path.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar);
            var absolutePath = Path.GetFullPath(Path.Combine(dirAbsolutePath, fileRelativePath));

            if (File.Exists(absolutePath))
                return absolutePath;

            // NTFSではパスの大文字小文字が無視されるが、ext3では区別されるため、環境によっては構文内に指定されたパスを取得できない可能性がある。
            // そのため大文字小文字を無視してファイルパスを取得する
            var splitPath = fileRelativePath.Split(new[] { Path.DirectorySeparatorChar }, StringSplitOptions.RemoveEmptyEntries);

            // ディレクトリ取得
            var originallyDirPath = dirAbsolutePath;
            foreach (var singlePath in splitPath.Take(splitPath.Count() - 1))
            {
                var tmpDirRelativePaths = Directory.EnumerateDirectories(originallyDirPath)
                    .Concat(new List<string>() { ".", ".." })
                    .Where(p => Regex.IsMatch(p, $"^{singlePath}$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
                    .Select(p => Path.GetFullPath(Path.Combine(dirAbsolutePath, p)))
                    ;

                if (false == tmpDirRelativePaths.Any())
                    return null;

                originallyDirPath = tmpDirRelativePaths.First();
            }

            // ファイル取得
            var originallyAbsolutePath = Directory.EnumerateFiles(originallyDirPath)
                .Where(p => Regex.IsMatch(p, $"^{splitPath.Last()}$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
                .Select(p => Path.GetFullPath(Path.Combine(dirAbsolutePath, p)))
                ;

            if (false == originallyAbsolutePath.Any())
                return null;

            return originallyAbsolutePath.First();
        }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="store"></param>
        /// <param name="dirAbsolutePath"></param>
        /// <param name="errorListener"></param>
        public EvaluateMapGrammarVisitorWithInclude(VariableStore store, string dirAbsolutePath, ParseErrorListener errorListener) : this(store, dirAbsolutePath, errorListener, 0.0)
        {
        }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="store"></param>
        /// <param name="dirAbsolutePath"></param>
        /// <param name="errorListener"></param>
        /// <param name="nowDistance"></param>
        public EvaluateMapGrammarVisitorWithInclude(VariableStore store, string dirAbsolutePath, ParseErrorListener errorListener, double nowDistance) : base(store, errorListener, nowDistance)
        {
            this.dirAbsolutePath = dirAbsolutePath;
        }

        public override object Visit(IncludeNode node)
        {
            var returnData = (IncludeStatement)base.Visit(node);
            var path = returnData.FilePath;

            #region Include先を再帰的にパース(ここの処理、MapGrammarParserにParseToAstFormFileメソッドを用意した方がいいかも)
            if (path == null)
            {
                ErrorListener.AddNewError(ParseMessageType.FilePathNotSpecified, null, node.Start);
                return returnData;
            }

            var absolutePath = GetIncludeAbsolutePath(path);

            if (absolutePath == null)
            {
                ErrorListener.AddNewError(ParseMessageType.FileNotFound, null, node.Start, path);
                return returnData;
            }
#if NETSTANDARD2_0
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // Shift-Jisを扱うために必要
#endif
            bool knownEncoding = CharsetDectector.DetermineFileEncoding(absolutePath, out Encoding fileEncoding);
            if (!knownEncoding)
            {
                ErrorListener.AddNewError(ParseMessageType.UnknownEncoding, absolutePath, 0, 0);
            }
            string includeText = File.ReadAllText(absolutePath, fileEncoding);
            if (string.IsNullOrEmpty(includeText))
            {
                ErrorListener.AddNewError(ParseMessageType.FileFailedLoad, null, node.Start, path);
                return returnData;
            }

            // Include先構文を評価して追加
            var parser = new MapGrammarParser(ErrorListener);
            var includeAst = parser.ParseToAst(includeText, absolutePath, MapGrammarParser.MapGrammarParserOption.ParseIncludeSyntaxRecursively | MapGrammarParser.MapGrammarParserOption.NoClearErrors);
            var evaluator = new EvaluateMapGrammarVisitorWithInclude(Store, dirAbsolutePath, ErrorListener, NowDistance);
            var includeData = (MapData)evaluator.Visit(includeAst);

            evaluateData.AddStatements(includeData.Statements);
            evaluateData.OverwriteListPath(includeData);
            NowDistance = evaluator.NowDistance;
            

            #endregion

            return null;
        }
    }
}
