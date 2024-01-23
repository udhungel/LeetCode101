using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class ValidAnagram_242
    {
        //Input: s = "anagram", t = "nagaram"
        //Output: true

        public static bool GetValidAnagram()
        {
            string s = "a";
            string t = "ab";

           var retVal =  s.GroupBy(x=>x).Select(x => new { Key = x.Key, Count = x.Count() });

            foreach (var item in retVal)
            {
                var x = item.Key;
                var y =  item.Count;

                var result = t.Exists(ch => ch == item.Key);
                if (result)
                {
                    var tCharCount = t.Count(c => c == item.Key);
                    if (tCharCount == item.Count)
                        continue;



                }
                else
                {
                    return false;

                }


            }
            return true; 
        }
    }
}
