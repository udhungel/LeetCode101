using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class RemoveElement_27
    {

        public static int RemoveElement()
        {
            //input parameters 
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            //need to return Output: 5, nums = [0,1,4,0,3,_,_,_]

            var arrayItem = (from n in nums
                             where n != val
                             select n).ToArray();

            for (int i = 0; i < arrayItem.Length; i++)
            {
                nums[i] = arrayItem[i];

            }

            return arrayItem.Count();
        }
    }
}
