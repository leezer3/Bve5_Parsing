using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Bve5_Parsing.MapGrammar.EvaluateData
{
    /// <summary>
    /// マップ構文の構文解析結果を格納するクラス
    /// </summary>
    public class MapData
    {
        #region フィールド
        internal readonly List<Statement> _statements;

        internal readonly HashSet<string> _trackKeys;
        #endregion

        #region プロパティ

        /// <summary>
        /// マップファイルのバージョン
        /// </summary>
        public readonly string Version;

        /// <summary>
        /// マップファイルのエンコーディング
        /// </summary>
        public readonly string Encoding;

        /// <summary>
        /// ストラクチャリストのファイルパス
        /// </summary>
        public HashSet<string> StructureListPaths { get; protected internal set; }

        /// <summary>
        /// 停車場リストのファイルパス
        /// </summary>
        public HashSet<string> StationListPaths { get; protected internal set; }

        /// <summary>
        /// 信号リストのファイルパス
        /// </summary>
        public HashSet<string> SignalListPaths { get; protected internal set; }

        /// <summary>
        /// 音リストのファイルパス
        /// </summary>
        public HashSet<string> SoundListPaths { get; protected internal set; }

        /// <summary>
        /// 固定音源リストのファイルパス
        /// </summary>
        public HashSet<string> Sound3DListPaths { get; protected internal set; }

        /// <summary>
        /// 構文データ
        /// </summary>
        public ReadOnlyCollection<Statement> Statements { get; }

        /// <summary>A list of the track keys in the route</summary>
        public HashSet<string> TrackKeys => _trackKeys;

        #endregion

        /// <summary>
        /// インスタンスを生成します。
        /// </summary>
        public MapData(string version, string encoding)
        {
            _statements = new List<Statement>();
            Statements = _statements.AsReadOnly();
            Version = version;
            Encoding = encoding;
            _trackKeys = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            _trackKeys.Add("0");
            SignalListPaths = new HashSet<string>();
            SoundListPaths = new HashSet<string>();
            Sound3DListPaths = new HashSet<string>();
            StationListPaths = new HashSet<string>();
            StructureListPaths = new HashSet<string>();
        }

        /// <summary>
        /// 初期値を代入したインスタンスを生成します。
        /// </summary>
        /// <param name="version">バージョン情報</param>
        /// <param name="encoding">エンコーディング情報</param>
        /// <param name="strListPath">ストラクチャーリストのファイルパス</param>
        /// <param name="staListPath">停車場リストのファイルパス</param>
        /// <param name="sigListPath">信号リストのファイルパス</param>
        /// <param name="souListPath">音リストのファイルパス</param>
        /// <param name="so3ListPath">固定音源リストのファイルパス</param>
        /// <param name="syntaxes">構文</param>
        public MapData(
            string version = null,
            string encoding = null,
            string strListPath = null,
            string staListPath = null,
            string sigListPath = null,
            string souListPath = null,
            string so3ListPath = null,
            IEnumerable<Statement> syntaxes = null
            )
        {
            
            SignalListPaths = new HashSet<string>();
            SoundListPaths = new HashSet<string>();
            Sound3DListPaths = new HashSet<string>();
            StationListPaths = new HashSet<string>();
            StructureListPaths = new HashSet<string>();

            Version = version;
            Encoding = encoding;
            StructureListPaths.Add(strListPath);
            StationListPaths.Add(staListPath);
            SignalListPaths.Add(sigListPath);
            SoundListPaths.Add(souListPath);
            Sound3DListPaths.Add(so3ListPath);

            if (syntaxes == null)
                _statements = new List<Statement>();
            else
                _statements = syntaxes.ToList();
            Statements = _statements.AsReadOnly();

            _trackKeys = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
            _trackKeys.Add("0");
        }

        /// <summary>
        /// 構文データを追加します。
        /// </summary>
        /// <param name="data"></param>
        public void AddStatement(Statement data)
        {
            if(data.Key != null && data.ElementName == MapElementName.Track)
            {
                _trackKeys.Add(data.Key);
            }
            _statements.Add(data);
        }

        public void AddIncludeData(MapData data)
        {
            _statements.AddRange(data.Statements);
            _trackKeys.UnionWith(data.TrackKeys);
            SignalListPaths.UnionWith(data.SignalListPaths);
            SoundListPaths.UnionWith(data.SoundListPaths);
            Sound3DListPaths.UnionWith(data.Sound3DListPaths);
            StationListPaths.UnionWith(data.StationListPaths);
            StructureListPaths.UnionWith(data.StructureListPaths);
        }

        /// <summary>
        /// 文字列から対応するリストファイルのパスを設定する
        /// </summary>
        /// <param name="elementName">LoadListFileNodeのelementName</param>
        /// <param name="path">設定するファイルパス</param>
        public void SetListPathToString(string elementName, string path)
        {
            switch (elementName)
            {
                case "structure":
                    StructureListPaths.Add(path);
                    break;
                case "station":
                    StationListPaths.Add(path);
                    break;
                case "signal":
                    SignalListPaths.Add(path);
                    break;
                case "sound":
                    SoundListPaths.Add(path);
                    break;
                case "sound3d":
                    Sound3DListPaths.Add(path);
                    break;
            }
        }

        #region Override
        /// <summary>
        /// 等価チェック
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            var m = (MapData)obj;

            return
                m.Version == Version &&
                m.Encoding == Encoding &&
                m.StructureListPaths == StructureListPaths &&
                m.StationListPaths == StationListPaths &&
                m.SignalListPaths == SignalListPaths &&
                m.SoundListPaths == SoundListPaths &&
                m.Sound3DListPaths == Sound3DListPaths &&
                m.Statements.SequenceEqual(Statements)
                ;
        }

        public override int GetHashCode()
        {
            return
                Version.GetHashCode() ^
                Encoding.GetHashCode() ^
                StructureListPaths.GetHashCode() ^
                StationListPaths.GetHashCode() ^
                SignalListPaths.GetHashCode() ^
                SoundListPaths.GetHashCode() ^
                Sound3DListPaths.GetHashCode() ^
                Statements.GetHashCode()
                ;
        }
        #endregion
    }
}
