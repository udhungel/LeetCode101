using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class FindMedianSortedArrays_4
    {
        public static double FindMedianSortedArrays()
        {
            
            int[] nums1 = { 1, 2 };
            int[] nums2 = {3};
            //example for num1 & num2     // example 2 
            /*[1,3]                               [1,2]
             * [2]                                [3,4]  Output = 2.5  merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
             Output: 2.00000
              [1,2,3] and median is 2.

             Example 2  -- [1,2,3,4]
            
            1. to merge the array .  myArray =  Concat array2 into array 
            2. Midpoint - myArray.Length / 2 -1 
            3. Check if the array is even or odd 
            even -->  myArray.Length%2 == 0  else //odd 

            Index  ValuesInArray   Length                  
            0         1              1                     
            1         2              2                       
            2         3              3 
            3         4              4 
          
             */
            int[] myArray = nums1.Concat(nums2).OrderBy(x=>x).ToArray();
            int midpoint = myArray.Length / 2 - 1;
            double result = 0; 
            if (myArray.Length % 2 == 0)  //even count in the array 
            {
                result = (double) (myArray[midpoint] + myArray[midpoint + 1]) / 2;  //2+3 

            }
            else
            {
                //  Output: 2.00000
                //[1, 2, 3] and median is 2.
                result =(double) myArray[midpoint + 1]; 


            }
            return result; 
            
        }
    }
}
