using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class LongestSubstring_3
    {

        public static int LongestSubstring()
        {

            /*  given string   -- abcabcbb  --- expecting length of 3 becasue of character that is uniquee ==>  abc
             *             Index->01234567 
             * Index  Scenarios  MaxCount   VariableRepeated that stops the substring uniqueness           
             *  0      abc         3          a
             *  1       bca        3          b
             *  2        cab       3          c
             *  3         abc      3          b
             *  4          bc      2          b
             *  5           cb     2          b
             *  6            b     1          b
             *  7            b     1          last item in the string                   
              -------------------------------------
             output string can be abc || bca || cab    output length will be 3 

            1. Dictionary<char,int> in order to hold the unique char with index 
            2. For loop 
            3. maxcount in order to know the length for output               
            */

            //code 
            string s = "abcabcbb";
            Dictionary<char,int> keyValuePairs= new Dictionary<char,int>(); 
            int maxCount =0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!keyValuePairs.ContainsKey(c))
                {
                    keyValuePairs.Add(c, i);
                    maxCount = Math.Max(keyValuePairs.Count,maxCount);

                }
                else 
                { 
                    i = keyValuePairs[c];
                    keyValuePairs.Clear();
                }

            }

            return maxCount;

           


            //
        }

    }
}

