using System.IO;
using System.Text;
using Ude;

namespace Bve5_Parsing
{
    internal static class CharsetDectector
    {
        private static bool ShiftJISFound = false;

        /// <summary>Attempts to determine the System.Text.Encoding value for a given BVE5 file</summary>
        /// <param name="FileName">The filename</param>
        /// <param name="Encoding">The found text encoding</param>
        /// <returns>The detected encoding, or UTF-8 if this is not found</returns>
        internal static bool DetermineFileEncoding(string FileName, out Encoding Encoding)
        {
            Encoding = Encoding.UTF8;
            using (StreamReader reader = new StreamReader(FileName))
            {
                var firstLine = reader.ReadLine();
                while (string.IsNullOrEmpty(firstLine) && !reader.EndOfStream)
                {
                    firstLine = reader.ReadLine();
                }

                if (firstLine != null)
                {
                    string[] Header = firstLine.Split(':');
                    /*
                     * NOTE: If no encoding declared, the BVE5 docs state that the file should be encoded in UTF-8
                     * unfortunately, developers don't respect this and sometimes use SHIFT_JIS incorrectly
                     */
                    if (Header.Length > 1)
                    {
                        string[] Arguments = Header[1].Split(',');
                        try
                        {
                            switch (Arguments[0].ToLowerInvariant())
                            {
                                case "shift_jis":
                                    Encoding = Encoding.GetEncoding(932);
                                    ShiftJISFound = true;
                                    break;
                                case "utf-8":
                                    Encoding = Encoding.UTF8;
                                    break;
                                case "utf-32":
                                    Encoding = Encoding.UTF32;
                                    break;
                                default:
                                    Encoding = Encoding.Default;
                                    break;
                            }
                            return true;
                        }
                        catch
                        {
                            Encoding = Encoding.UTF8;
                            return false;
                        }
                    }
                }
            }

            if (ShiftJISFound)
            {
                // we have already found a file encoded in SHIFT_JIS
                Encoding = Encoding.GetEncoding(932);
                return false;
            }

            CharsetDetector det = new CharsetDetector();
            byte[] fileBytes = File.ReadAllBytes(FileName);
            det.Feed(fileBytes, 0, fileBytes.Length);

            switch (det.Charset)
            {
                case Charsets.IBM855:
                    Encoding = Encoding.GetEncoding(855);
                    break;
                case Charsets.IBM866:
                    Encoding = Encoding.GetEncoding(866);
                    break;
                case Charsets.SHIFT_JIS:
                    Encoding = Encoding.GetEncoding(932);
                    break;
                case Charsets.EUCKR:
                    Encoding = Encoding.GetEncoding(949);
                    break;
                case Charsets.BIG5:
                    Encoding = Encoding.GetEncoding(950);
                    break;
                case Charsets.UTF16_LE:
                    Encoding = Encoding.GetEncoding(1200);
                    break;
                case Charsets.UTF16_BE:
                    Encoding = Encoding.GetEncoding(1201);
                    break;
                case Charsets.WIN1251:
                    Encoding = Encoding.GetEncoding(1251);
                    break;
                case Charsets.WIN1252:
                    Encoding = Encoding.GetEncoding(1252);
                    break;
                case Charsets.WIN1253:
                    Encoding = Encoding.GetEncoding(1253);
                    break;
                case Charsets.WIN1255:
                    Encoding = Encoding.GetEncoding(1255);
                    break;
                case Charsets.MAC_CYRILLIC:
                    Encoding = Encoding.GetEncoding(10007);
                    break;
                case Charsets.UTF32_LE:
                    Encoding = Encoding.GetEncoding(12000);
                    break;
                case Charsets.UTF32_BE:
                    Encoding = Encoding.GetEncoding(12001);
                    break;
                case Charsets.ASCII:
                    Encoding = Encoding.GetEncoding(20127);
                    break;
                case Charsets.KOI8R:
                    Encoding = Encoding.GetEncoding(20866);
                    break;
                case Charsets.EUCJP:
                    Encoding = Encoding.GetEncoding(20932);
                    break;
                case Charsets.ISO8859_2:
                    Encoding = Encoding.GetEncoding(28592);
                    break;
                case Charsets.ISO8859_5:
                    Encoding = Encoding.GetEncoding(28595);
                    break;
                case Charsets.ISO_8859_7:
                    Encoding = Encoding.GetEncoding(28597);
                    break;
                case Charsets.ISO8859_8:
                    Encoding = Encoding.GetEncoding(28598);
                    break;
                case Charsets.ISO2022_JP:
                    Encoding = Encoding.GetEncoding(50220);
                    break;
                case Charsets.ISO2022_KR:
                    Encoding = Encoding.GetEncoding(50225);
                    break;
                case Charsets.ISO2022_CN:
                    Encoding = Encoding.GetEncoding(50227);
                    break;
                case Charsets.HZ_GB_2312:
                    Encoding = Encoding.GetEncoding(52936);
                    break;
                case Charsets.GB18030:
                    Encoding = Encoding.GetEncoding(54936);
                    break;
                case Charsets.UTF8:
                    Encoding = Encoding.GetEncoding(65001);
                    break;
            }

            return true;
        }
    }
}
