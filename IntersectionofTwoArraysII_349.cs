using LanguageExt.TypeClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class IntersectionofTwoArraysII_349
    {
        public static int[] IntersectionofTwoArraysII()
        {


            int[] nums1 = { 1, 2, 2, 1 }, nums2 = { 2, 2 };
            //output returmArray = {2 }

            /*
                group by clause for num1 and then use a dictionary                 
                iterate through the nums 2 and if the dictionary has value add to the resulting list
             */
            // time complexity of O(m + n), where m and n are the lengths of the two input arrays

            List<int> result = new List<int>();

            var dict = nums1.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            for (int i = 0; i < nums2.Length; i++)
            {
                if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
                {
                    result.Add(nums2[i]);
                    dict[nums2[i]]--; 

                }

            }
            return result.Distinct().ToArray(); 
        }
    }
}
