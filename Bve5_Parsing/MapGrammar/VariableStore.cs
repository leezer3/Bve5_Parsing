﻿using System.Collections.Generic;

namespace Bve5_Parsing.MapGrammar
{
    /// <summary>
    /// 変数管理クラス
    /// </summary>
    public class VariableStore
    {
        public Dictionary<string, object> Vars { get; private set; }

        /// <summary>
        /// 変数を追加、もしくは上書きします。
        /// </summary>
        /// <param name="key">変数名</param>
        /// <param name="val">変数の値</param>
        public void SetVar(string key, object val)
        {
            if (Vars.ContainsKey(key))
                Vars[key] = val;
            else
                Vars.Add(key, val);
        }

        /// <summary>
        /// 変数を取得します。
        /// </summary>
        /// <param name="key">変数名</param>
        /// <returns>変数の値</returns>
        public object GetVar(string key)
        {
            if (Vars.ContainsKey(key))     /*変数が登録されてる*/
                return Vars[key];
            else                           /*変数が登録されていない*/
                return 0;
        }

        /// <summary>
        /// 変数をすべてクリアします。
        /// </summary>
        public void ClearVar()
        {
            Vars = new Dictionary<string, object>();
        }
    }
}
