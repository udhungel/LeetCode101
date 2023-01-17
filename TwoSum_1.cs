using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    //    Example 1:

    //Input: nums = [2,7,11,15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    //Example 2:

    //Input: nums = [3,2,4], target = 6
    //Output: [1,2]
    //    Example 3:

    //Input: nums = [3,3], target = 6
    //Output: [0,1]
    public static class TwoSum_1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    /* 
                        outer loop index = 0 ; value =2 
                        inner loop index = 0 ; value = 2 
                        for my outer loop it will be value of i will be 2 till the whole inner loop
                        cycle complete 
                        then we need to sum up and if we find the correct target we will return 
                          2 + 2 == 9 -- false 
                          2 + 7 == 9 -- true       return {0,1}
                          2 + 11 == 9 -- false 
                          2 + 15 == 9 -- false 
                     */
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        int[] arr = { i, j };
                        return arr;

                    }
                }
            }
            return null;
        }
    }
}
