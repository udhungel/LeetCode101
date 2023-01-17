using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class RunningSum1DArray_1480
    {
        public static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];  //define the array as the same length of nums
            result[0] = nums[0];                  // first is always the same
            for (int i = 1; i < nums.Length; i++)  // loop from second and add to array result position 1 where  num[1] + result[0] 
            {
                result[i] = nums[i] + result[i - 1];

            }
            return result;

        }
    }
}
