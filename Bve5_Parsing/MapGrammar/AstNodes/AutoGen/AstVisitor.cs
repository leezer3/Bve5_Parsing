﻿/*
 * このファイルはdoc/createMapGrammarTemplate.jsによって自動生成されています。
 * 編集は行わないでください。
 */
using Bve5_Parsing.MapGrammar.AstNodes;

namespace Bve5_Parsing.MapGrammar
{

    /// <summary>
    /// ASTノードの評価クラス定義
    /// </summary>
    /// <typeparam name="T">ASTノードの種類</typeparam>
    public abstract class AstVisitor<T>
    {

        public abstract T Visit(RootNode node);
        public abstract T Visit(DistanceNode node);
        public abstract T Visit(CurveSetGaugeNode node);
        public abstract T Visit(GaugeSetNode node);
        public abstract T Visit(CurveGaugeNode node);
        public abstract T Visit(CurveSetCenterNode node);
        public abstract T Visit(CurveSetFunctionNode node);
        public abstract T Visit(CurveBeginTransitionNode node);
        public abstract T Visit(CurveBeginNode node);
        public abstract T Visit(CurveBeginCircularNode node);
        public abstract T Visit(CurveEndNode node);
        public abstract T Visit(CurveInterpolateNode node);
        public abstract T Visit(CurveChangeNode node);
        public abstract T Visit(GradientBeginTransitionNode node);
        public abstract T Visit(GradientBeginNode node);
        public abstract T Visit(GradientBeginConstNode node);
        public abstract T Visit(GradientEndNode node);
        public abstract T Visit(GradientInterpolateNode node);
        public abstract T Visit(TrackXInterpolateNode node);
        public abstract T Visit(TrackYInterpolateNode node);
        public abstract T Visit(TrackPositionNode node);
        public abstract T Visit(TrackCantSetGaugeNode node);
        public abstract T Visit(TrackGaugeNode node);
        public abstract T Visit(TrackCantSetCenterNode node);
        public abstract T Visit(TrackCantSetFunctionNode node);
        public abstract T Visit(TrackCantBeginTransitionNode node);
        public abstract T Visit(TrackCantBeginNode node);
        public abstract T Visit(TrackCantEndNode node);
        public abstract T Visit(TrackCantInterpolateNode node);
        public abstract T Visit(TrackCantNode node);
        public abstract T Visit(StructureLoadNode node);
        public abstract T Visit(StructurePutNode node);
        public abstract T Visit(StructurePut0Node node);
        public abstract T Visit(StructurePutBetweenNode node);
        public abstract T Visit(RepeaterBeginNode node);
        public abstract T Visit(RepeaterBegin0Node node);
        public abstract T Visit(RepeaterEndNode node);
        public abstract T Visit(BackgroundChangeNode node);
        public abstract T Visit(StationLoadNode node);
        public abstract T Visit(StationPutNode node);
        public abstract T Visit(SectionBeginNode node);
        public abstract T Visit(SectionBeginNewNode node);
        public abstract T Visit(SectionSetSpeedLimitNode node);
        public abstract T Visit(SignalSpeedLimitNode node);
        public abstract T Visit(SpeedLimitSetSignalNode node);
        public abstract T Visit(SignalLoadNode node);
        public abstract T Visit(SignalPutNode node);
        public abstract T Visit(BeaconPutNode node);
        public abstract T Visit(SpeedLimitBeginNode node);
        public abstract T Visit(SpeedLimitEndNode node);
        public abstract T Visit(PretrainPassNode node);
        public abstract T Visit(LightAmbientNode node);
        public abstract T Visit(LightDiffuseNode node);
        public abstract T Visit(LightDirectionNode node);
        public abstract T Visit(FogInterpolateNode node);
        public abstract T Visit(FogSetNode node);
        public abstract T Visit(DrawDistanceChangeNode node);
        public abstract T Visit(CabIlluminanceInterpolateNode node);
        public abstract T Visit(CabIlluminanceSetNode node);
        public abstract T Visit(IrregularityChangeNode node);
        public abstract T Visit(AdhesionChangeNode node);
        public abstract T Visit(SoundLoadNode node);
        public abstract T Visit(SoundPlayNode node);
        public abstract T Visit(Sound3dLoadNode node);
        public abstract T Visit(Sound3dPutNode node);
        public abstract T Visit(RollingNoiseChangeNode node);
        public abstract T Visit(FlangeNoiseChangeNode node);
        public abstract T Visit(JointNoisePlayNode node);
        public abstract T Visit(TrainAddNode node);
        public abstract T Visit(TrainLoadNode node);
        public abstract T Visit(TrainEnableNode node);
        public abstract T Visit(TrainStopNode node);
        public abstract T Visit(TrainSetTrackNode node);
        public abstract T Visit(LegacyFogNode node);
        public abstract T Visit(LegacyCurveNode node);
        public abstract T Visit(LegacyPitchNode node);
        public abstract T Visit(LegacyTurnNode node);
        public abstract T Visit(IncludeNode node);
        public abstract T Visit(Syntax1Node node);
        public abstract T Visit(Syntax2Node node);
        public abstract T Visit(Syntax3Node node);
        public abstract T Visit(LoadListNode node);
        public abstract T Visit(VarAssignNode node);
        public abstract T Visit(AdditionNode node);
        public abstract T Visit(SubtractionNode node);
        public abstract T Visit(MultiplicationNode node);
        public abstract T Visit(DivisionNode node);
        public abstract T Visit(UnaryNode node);
        public abstract T Visit(ModuloNode node);
        public abstract T Visit(AbsNode node);
        public abstract T Visit(Atan2Node node);
        public abstract T Visit(CeilNode node);
        public abstract T Visit(CosNode node);
        public abstract T Visit(ExpNode node);
        public abstract T Visit(FloorNode node);
        public abstract T Visit(LogNode node);
        public abstract T Visit(PowNode node);
        public abstract T Visit(RandNode node);
        public abstract T Visit(SinNode node);
        public abstract T Visit(SqrtNode node);
        public abstract T Visit(NumberNode node);
        public abstract T Visit(DistanceVariableNode node);
        public abstract T Visit(StringNode node);
        public abstract T Visit(VarNode node);

        /// <summary>
        /// 引数に与えられたASTノードを評価します。
        /// </summary>
        /// <param name="node">評価するASTノード</param>
        /// <returns>評価結果</returns>
        public T Visit(MapGrammarAstNodes node)
        {
            return Visit((dynamic)node);
        }
    }
}
