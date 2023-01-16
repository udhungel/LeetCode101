using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class Solution290
    {

        public bool WordPattern(string pattern, string s)
        {
            var strVal = getPattern(s.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)));

            var patternVal = getPattern(pattern.Select(x => x.ToString()));


            var isTrue = strVal.SequenceEqual(patternVal);

            return isTrue;



        }

        private static string getPattern(IEnumerable<string> strVals)
        {
            var grpVals = strVals.Select((x, i) => new { val = x, idx = i })
                                 .GroupBy(x => x.val).ToDictionary(x => x.Key, x => x.First().idx);

            var retVal = string.Join(",", strVals.Select(x => grpVals[x]));


            return retVal;
        }

    }
}
