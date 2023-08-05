using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class RemoveDuplicatesFromSortedArrayII
    {
        public static int RemoveDuplicates()
        {
            // example
            //Input: nums = [0, 0, 1, 1, 1, 1, 2, 3, 3]
            //Output: 7, nums = [0, 0, 1, 1, 2, 3, 3, _, _]
            int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

            var resultArray = nums.GroupBy(x => x).SelectMany(x=>x.Take(2)).ToArray();

            Array.Copy(resultArray, nums, resultArray.Length);

            // Brainstorming and foreach loop inner loop explanation 

            // Group by Key    0   |   1              |  2          |  3
            // Item            0,0     1, 1, 1, 1,      2             3, 3 

            //foreach (var group in resultArray)
            //{
            //    Console.WriteLine($"Group Key {group.Key}");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine($"Item Key {item}");

            //    }

            //}





            return resultArray.Length;
        }
    }
}
