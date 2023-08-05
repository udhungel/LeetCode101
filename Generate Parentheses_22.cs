using System.Linq;

namespace LeetCode101
{
    public static class TopKFrequent_347
    {
        public static int[] TopKFrequent()
        {
        //Example 1
        //Input: nums = [1, 1, 1, 2, 2, 3], k = 2
        //Output: [1,2]
           
        int[] nums = { 4, 4, 4, 6, 6, 3,3,3,3 };
        int k = 2;
            // result to be {3,4} 

            /*
             * Group by - when you have items more than 1 occurence 
             * Dictionary 
             * Order them based on count orderbydesc based on count 
             */
            var result = nums.GroupBy(x => x)
                             .ToDictionary(x => x.Key, x => x.Count())
                             .OrderByDescending(x => x.Value)
                             .Select(x => x.Key) 
                             .Take(2)
                              .ToArray();

            var result4 = nums.GroupBy(x => x)
                             .ToDictionary(x => x.Key, x => x.Count());

            var result3 = nums.GroupBy(x => x)
                           .ToDictionary(x => x.Key, x => x.Count()).OrderByDescending(x => x.Value);

            var result1 = nums.GroupBy(x => x)
                             .Select(x => new { Key1 = x.Key, Count = x.Count() })
                             .OrderByDescending(x=>x.Key1);
                             




            return new int[] { };
        }
    }
}
