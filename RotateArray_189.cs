using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class RotateArray_189
    {
        public static void Rotate()
        {
            
            //initial given array 
            int[] nums = { 1, 2};  // {2,1}

            //no of times the array will rotate
            int k = 3;

            k = k % nums.Length;

            //Code to copy 
            var array1 = nums.Skip(nums.Length - k);  //{5,6,7}
            var array2 = nums.Take(nums.Length - k); //{1,2,3,4} 

            int[] array3 = array1.Concat(array2).ToArray(); // [5,6,7,1,2,3,4]

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = array3[i];

            }


            /*
             * 
             *  OUTPUT ---> Input: nums = [1,2,3,4,5,6,7], k = 3
                                         Output: [5,6,7,1,2,3,4]

            {1,2,3,4,5,6,7,}   ==> Length 7 for the given array 

            rotate 1 steps to the right: [7,1,2,3,4,5,6]
            rotate 2 steps to the right: [6,7,1,2,3,4,5]
            rotate 3 steps to the right: [5,6,7,1,2,3,4]

            1. nums.Length = 7 - 3 = 4  skip these many items in an array1 =  {5,6,7} , we know the value of K 
            2. nums.Length = 7 - 3 = 4  take array2 = {1,2,3,4} 

            3. array1 + array2 = [5,6,7,1,2,3,4]  ==> length of new array = nums 
            4. Set it to nums using for loop        
             */
        }
    }
}
