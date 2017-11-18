﻿using Irony.Ast;
using Irony.Parsing;

namespace Bve5_Parsing.MapGrammar.AstNodes.Structure
{
    /*
     * TrackのAST木定義
     */

    /// <summary>
    /// Structure[key].Put(trackkey, x, y, z, rx, ry, rz, tilt, span)
    /// </summary>
    public class PutNode : Syntax_2
    {
        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            ParseTreeNodeList nodes = treeNode.GetMappedChildNodes();

            //引数の登録
            AddArguments("trackkey", nodes, 3, typeof(string));
            AddArguments("x", nodes, 4, typeof(double));
            AddArguments("y", nodes, 5, typeof(double));
            AddArguments("z", nodes, 6, typeof(double));
            AddArguments("rx", nodes, 7, typeof(double));
            AddArguments("ry", nodes, 8, typeof(double));
            AddArguments("rz", nodes, 9, typeof(double));
            AddArguments("tilt", nodes, 10, typeof(double));
            AddArguments("span", nodes, 11, typeof(double));
        }
    }

    /// <summary>
    /// Structure[key].Put0(trackkey, tilt, span)
    /// </summary>
    public class Put0Node : Syntax_2
    {
        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            ParseTreeNodeList nodes = treeNode.GetMappedChildNodes();

            //引数の登録
            AddArguments("trackkey", nodes, 3, typeof(string));
            AddArguments("tilt", nodes, 4, typeof(double));
            AddArguments("span", nodes, 5, typeof(double));
        }
    }

    /// <summary>
    /// Structure[key].PutBetween(trackkey1, trackkey2, flag) | Structure[key].PutBetween(trackkey1, trackkey2)
    /// </summary>
    public class PutBetweenNode : Syntax_2
    {
        public override void Init(AstContext context, ParseTreeNode treeNode)
        {
            base.Init(context, treeNode);
            ParseTreeNodeList nodes = treeNode.GetMappedChildNodes();

            //引数の登録
            AddArguments("trackkey1", nodes, 3, typeof(string));
            AddArguments("trackkey2", nodes, 4, typeof(string));
            if(nodes.Count > 5)
                AddArguments("flag", nodes, 5, typeof(double));
        }
    }
}