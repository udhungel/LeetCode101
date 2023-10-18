using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class ContainsDuplicate_217
    {
        public static void ContainsDuplicate()
        {
            int[] nums = new int[]{1,2,3,1 };  // return true

            // Group by with count 
            var retVal = nums.GroupBy(x => x).Select(x => new { Key = x.Key, Count = x.Count() });
            var result = retVal.Any(x => x.Count > 1);
        }
    }
}
