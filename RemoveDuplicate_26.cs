using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class RemoveDuplicate_26
    {
        public static int RemoveDuplicates()
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var arrayItems = nums.GroupBy(x => x).Select(x=>x.First()).ToArray();

            //OR
            //var arrayItems = nums.Distinct().ToArray();

            for (int i = 0; i < arrayItems.Length; i++)
            {
                nums[i] = arrayItems[i];

            }

            return arrayItems.Count(); 

            /*Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]   
             * achieve this using groupby or distinct 
             * to have unique value only what we could do is we could reassign the value into nums using for loop 
             
             */


        }


    }
}
