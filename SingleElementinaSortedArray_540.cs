using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class SingleElementinaSortedArray_540
    {
        public static void SingleElementinaSortedArray()
        {
            //Example 1 : output 2                                    
            int[] nums = { 3, 3, 7, 7, 10, 11, 11 }; //{ 1, 1, 2, 3, 3, 4, 4, 8, 8 };  // Example 2 [3,3,7,7,10,11,11]

            //Steps - groupby clause using where filter select the first item 

            int result = nums.GroupBy(x => x).Where(x=>x.Count()==1).Select(x=>x.Key).First();

          




        }
    }
}
