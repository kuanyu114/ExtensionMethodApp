using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp
{
    public static class m_ExtensionMethod
    {
        /// <summary>
        /// soruce是null,傳回空字串
        /// 如果字串長度大於期望長度, 將截斷字串並加入替換字串, 總長度等於期望長度
        /// 如果替換字串長度大於期望長度, 替換字串將為空字串 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="length">期望字串長度</param>
        /// <param name="suffix">替換字串</param>
        /// <returns></returns>
        public static string Truncate(this string source, int length, string suffix = "...")
        {
            if (source == null) return "";
            if (source.Length <= length) return source;

            if (suffix.Length > length) suffix = "";
            return source.Substring(0, length - suffix.Length) + suffix;

        }
        /// <summary>
        /// 確保在期望範圍內
        /// </summary>
        /// <param name="num"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>       
        public static int EnsureInRange(this int num, int lower, int upper)
        {
            if (num < lower) return lower;
            else if (num > upper) return upper;
            return num;

        }

        public static string[] GetSubArray(this string[] source, int beginIndex, int endIndex)
        {
            if (source == null) return new string[] { };
            beginIndex = beginIndex.EnsureInRange(0, source.Length - 1);
            endIndex = endIndex.EnsureInRange(0, source.Length - 1);

            if (beginIndex > endIndex)//若大小相反，自動對調
            {
                int tempInt = endIndex;
                endIndex = beginIndex;
                beginIndex = tempInt;
            }
            string[] result = new string[endIndex];
            for (int i = 0; i < endIndex; i++)
            {
                result[i] = source[beginIndex];
                beginIndex++;
            }
            return result;
        }

        //public static T[] GetSubArray <T>(this T[] source, int beginIndex, int endIndex)
        //{
        //    if (source == null) return Array.Empty<T>();
        //    beginIndex = beginIndex < 0 ? 0 : beginIndex;
        //    endIndex = endIndex < 0 ? 0 : endIndex;
        //    beginIndex = beginIndex < source.Count() ? source.Count()-1 : beginIndex;
        //    endIndex = endIndex > source.Count() ? source.Count() - 1 : endIndex;
        //    if(beginIndex > endIndex)
        //    {
        //        int tempInt = endIndex;
        //        endIndex = beginIndex;
        //        beginIndex = tempInt;
        //    }
        //    T[] result = new T[endIndex];
        //    for (int i = 0; i < endIndex; i++)
        //    {
        //        result[i] = source[beginIndex];
        //        beginIndex++;
        //    }
        //    return result;
        //}
    }
}
