using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class LongestCommonPrefix_14
    {
        /*
            * Example 1:

            Input: strs = ["flower","flow","flight"]
            Output: "fl"
            Example 2:

            Input: strs = ["dog","racecar","car"]
            Output: ""
            Explanation: There is no common prefix among the input strings.
         */




        public static string MaxLength1()
        {
            string[] strVals = { "flower", "flow", "flight" };
            var maxlength = strVals.Max(x => x.Length);
            string prefix; 
            var maxlenthString = strVals.FirstOrDefault(x => x.Length == maxlength);  //find the max length elment 
            for (int i = maxlength; i >= 0; i--)
            {
                prefix = maxlenthString.Substring(0,i);
                if (strVals.All(x=>x.StartsWith(prefix)))
                {
                    return prefix;
                }              

            }
            return ""; 
        }
    }
}
