using LanguageExt;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class FirstUniqueCharacterinaString_387
    {
        public static int FirstUniqChar()
        {
            //Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
            string s = "leetcode";
            //Output: 0
            /*
             * Group then together and find the count == 1 
             * Index by
             */
            var retVal = s.GroupBy(x => x).Select(x => new { Key = x.Key, Count = x.Count() }).FirstOrDefault(x => x.Count == 1);
            return retVal == null ? -1 : s.IndexOf(retVal.Key); 

        }
    }
}
