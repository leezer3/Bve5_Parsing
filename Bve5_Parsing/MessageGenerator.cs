namespace Bve5_Parsing
{
    /// <summary>
    /// メッセージの種別を表します。
    /// MessageGeneratorクラスのプロパティに対応します。
    /// </summary>
    public enum ParseMessageType
    {
        /// <summary>
        /// Default composite format string: 有効なマップファイルではありません。
        /// </summary>
        InvalidMapFormat,

        /// <summary>
        /// Default composite format string: {0}の検証に失敗しました。
        /// </summary>
        FailedPredicate,

        /// <summary>
        /// Default composite format string: 入力文字列{0}が予期されたマップ構文'{1}'と一致しませんでした。
        /// </summary>
        InputMismatch,

        /// <summary>
        /// Default composite format string: 入力文字列{0}にマップ構文'{1}'がありません。
        /// </summary>
        MissingToken,

        /// <summary>
        /// Default composite format string: 入力文字列{0}のマップ構文を特定できませんでした。
        /// </summary>
        NoViable,

        /// <summary>
        /// Default composite format string: 入力文字列{0}が予期されたマップ構文'{1}'と一致しませんでした。
        /// </summary>
        UnwantedToken,

        /// <summary>
        /// Default composite format string: {0}は無効な引数です。
        /// </summary>
        InvalidArgument,

        /// <summary>
        /// Default composite format string: '{0}'は有効な式ではありません。
        /// </summary>
        InvalidExpression,

        /// <summary>
        /// Default composite format string: ファイルパスが指定されていません。
        /// </summary>
        FilePathNotSpecified,

        /// <summary>
        /// Default composite format string: 指定されたファイル「{0}」は存在しません。
        /// </summary>
        FileNotFound,

        /// <summary>
        /// Default composite format string: 「{0}」の読み込みに失敗しました。
        /// </summary>
        FileFailedLoad,
        /// <summary>
        /// Default composite format string: 「{0}」の読み込みに失敗しました。
        /// </summary>
        FileEmpty,
        /// <summary>
        /// Default composite format string: 「{0}」の読み込みに失敗しました。
        /// </summary>
        UnknownEncoding
    }

    /// <summary>
    /// デフォルトのメッセージ生成クラス
    /// メッセージの種別に応じて、メッセージを生成します。
    /// このクラスを継承し、ErrorListenerまたはパーサーのコンストラクタに指定することで、メッセージをカスタマイズできます。
    /// </summary>
    public class MessageGenerator
    {
        // ReSharper disable UnusedMember.Global
        public virtual string InvalidMapFormat => "Not a valid map file.";
        public virtual string FailedPredicate => "Verification failed for {0}";
        public virtual string InputMismatch => "The input string {0} is not valid for the expected Map Format {1}";
        public virtual string MissingToken => "The input string {0} is missing the map syntax token {1}";
        public virtual string NoViable => "Unable to determine the map syntax for input {0}";
        public virtual string UnwantedToken => "The input string {0} did not match the expected map syntax {1}";
        public virtual string InvalidArgument => "{0} is not a valid argument.";
        public virtual string InvalidExpression => "{0} is not a valid expression.";
        public virtual string FilePathNotSpecified => "No file path was specified.";
        public virtual string FileNotFound => "The specified file {0} does not exist.";
        public virtual string FileFailedLoad => "The specified file {0} failed to load.";
        public virtual string FileEmpty => "The specified file {0} appears to be empty.";
        public virtual string UnknownEncoding => "Unable to determine the character encoding ";
        // ReSharper restore UnusedMember.Global
        public virtual string FilePath => "（File path：{0}）";

        public virtual string GetMessage(ParseMessageType type, string filePath, params object[] args)
        {
            // ReSharper disable once PossibleNullReferenceException
            string msg = string.Format((string)GetType().GetProperty(type.ToString()).GetValue(this), args);

            if (filePath != null)
            {
                msg += string.Format(FilePath, filePath);
            }

            return msg;
        }
    }
}
