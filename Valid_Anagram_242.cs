using LanguageExt;
using LanguageExt.UnitsOfMeasure;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode101
{
    public class Valid_Anagram_242
    {
        public static bool GetValid_Anagram()
        {
            string s = "anagram", t = "nagaram";
            //    Example 1:

            //    Input: s = "anagram", t = "nagaram"
            //    Output: true
            //    Example 2:

            //    Input: s = "rat", t = "car"
            //    Output: false
            List<char> result1 = new List<char>(s); 
          
            for (int i = 0; i < t.Length; i++)
            {
                char c = t[i];
                if (result1.Contains(c))
                {
                    result1.Remove(c);
                }
                else
                {
                    return false;
                }
            }

            return result1.Count > 0 ? false : true;
        }


    }
}
