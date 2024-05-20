using System;
using System.Collections.Concurrent;
using Bve5_Parsing.MapGrammar;

namespace Bve5_Parsing
{
    /// <summary>
    /// Enumに文字列を付加するためのAttributeクラス
    /// </summary>
    public class StringValueAttribute : Attribute
    {
        /// <summary>
        /// Holds the stringvalue for a value in an enum.
        /// </summary>
        public string StringValue { get; protected set; }

        /// <summary>
        /// Constructor used to init a StringValue Attribute
        /// </summary>
        /// <param name="value"></param>
        public StringValueAttribute(string value)
        {
            this.StringValue = value;
        }
    }

    public static class CommonAttribute
    {
        /*
         * Using Enum.ToString() kills performance
         * Keep them in a dictionary instead
         *
         * The reflection is still pretty nasty, but this helps considerably
         */


        // caches
        private static readonly ConcurrentDictionary<MapElementName, string> mapElementNameCache = new ConcurrentDictionary<MapElementName, string>();
        private static readonly ConcurrentDictionary<MapFunctionName?, string> mapFunctionNameCache = new ConcurrentDictionary<MapFunctionName?, string>();
        private static readonly ConcurrentDictionary<MapSubElementName, string> mapSubElementNameCache = new ConcurrentDictionary<MapSubElementName, string>();
        
        public static string GetStringValueCached(this MapElementName value)
        {
            if (mapElementNameCache.TryGetValue(value, out var cached))
            {
                return cached;
            }
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            System.Reflection.FieldInfo fieldInfo = type.GetField(value.ToString());

            //範囲外の値チェック
            if (fieldInfo == null) return null;

            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            if (attribs == null)
            {
                return null;
            }

            // Return the first if there was a match.
            string str = attribs.Length > 0 ? attribs[0].StringValue : null;
            mapElementNameCache[value] = str;
            return str;
        }

        public static string GetStringValueCached(this MapFunctionName value)
        {
            if (mapFunctionNameCache.TryGetValue(value, out var cached))
            {
                return cached;
            }
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            System.Reflection.FieldInfo fieldInfo = type.GetField(value.ToString());

            //範囲外の値チェック
            if (fieldInfo == null) return null;

            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            if (attribs == null)
            {
                return null;
            }

            // Return the first if there was a match.
            string str = attribs.Length > 0 ? attribs[0].StringValue : null;
            mapFunctionNameCache[value] = str;
            return str;
        }

        public static string GetStringValueCached(this MapFunctionName? value)
        {
            // value will never be null
            if (mapFunctionNameCache.TryGetValue(value, out var cached))
            {
                return cached;
            }
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            System.Reflection.FieldInfo fieldInfo = type.GetField(value.ToString());

            //範囲外の値チェック
            if (fieldInfo == null) return null;

            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            if (attribs == null)
            {
                return null;
            }

            // Return the first if there was a match.
            string str = attribs.Length > 0 ? attribs[0].StringValue : null;
            mapFunctionNameCache[value] = str;
            return str;
        }

        public static string GetStringValueCached(this MapSubElementName value)
        {
            if (mapSubElementNameCache.TryGetValue(value, out var cached))
            {
                return cached;
            }
            // Get the type
            Type type = value.GetType();

            // Get fieldinfo for this type
            System.Reflection.FieldInfo fieldInfo = type.GetField(value.ToString());

            //範囲外の値チェック
            if (fieldInfo == null) return null;

            StringValueAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];

            if (attribs == null)
            {
                return null;
            }

            // Return the first if there was a match.
            string str = attribs.Length > 0 ? attribs[0].StringValue : null;
            mapSubElementNameCache[value] = str;
            return str;
        }
    }
}
