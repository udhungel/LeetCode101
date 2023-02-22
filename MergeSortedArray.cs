using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class MergeSortedArray
    {
        public static void Merge()
        {
            //given 
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3;  //m elements  denotes the element that should be merged
            int n = 3;
            //output -- [1,2,2,3,5,6]
            /*********************************************/

            //using linq 
            /*
             * Step 1. Take integars from nums1 as per lenght m = 3 ie. Take 3 items from nums1  ==> myArray 
             * Step 2 . myArray.Concat(nums) 
             * Step 3 . Copy to nums1 
             */

            int[] myArray = nums1.Take(m).ToArray();
            myArray = myArray.Concat(nums2).OrderBy(x=>x).ToArray();

            //copy to nums1
            Array.Copy(myArray,0,nums1,0,myArray.Length);









        }
    }
}
