using LanguageExt.TypeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class TopKFrequent_347
    {
        public static int[] TopKFrequent()
        {
        //Example 1
        //Input: nums = [1, 1, 1, 2, 2, 3], k = 2
        //Output: [1,2]
           
        int[] nums = { 4, 4, 4, 6, 6, 3,3,3,3 };
        int k = 2;
            // result to be {3,4} 

            /*
             * Group by - when you have items more than 1 occurence 
             * Dictionary 
             * Order them based on count orderbydesc based on count 
             */
            var result = nums.GroupBy(x => x)
                             .ToDictionary(x => x.Key, x => x.Count())
                             .OrderByDescending(x => x.Value)
                             .Select(x => x.Key)
                             .Take(2)
                             .ToArray();
          


           
        return new int[] { };
        }
    }
}
