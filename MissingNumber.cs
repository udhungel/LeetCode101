using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class MissingNumber
    {
        public static int Missing_Number()
        {
            int[] nums = { 0, 1 }; // { 1, 3, 0 };
            //Input: nums = [3, 0, 1]
            //Output: 2
            /* Explanation: n = 3 since there are 3 numbers,
             * so all numbers are in the range [0,3]. 
             * 2 is the missing number in the range since it does not appear in nums.             * 
             * ---------------- Steps----------------------------------------------------------------------------- 
             * Min = 0  ; Max = 3 
             * Range - IEnumber{int} - {1,2,3}  -- check if the  missing number that is in nums array 
             */
            int minVal = nums.Min(); 
            int maxVal = nums.Max();
            var retVal = Enumerable.Range(0, nums.Max()+ 1).Except(nums).ToArray();

            //int[] arrayVal = new int[maxVal+2];
            //for (int i = minVal; i <= maxVal+1; i++)
            //{
            //    arrayVal[i] = i;
            //}

            //int retVal =  arrayVal.Except(nums).First(); 



            return retVal.FirstOrDefault();

        }
    }

}
