using LanguageExt.Common;
using LanguageExt.TypeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class ContainsDuplicateII_219
    {
        public static bool ContainsDuplicateII()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2; //false

            /* Step 1 : Select with value and index 
             *       Element    ||   Index              
             *          1              0
             *          2              1
             *          3              2 
             *          1              3
             *          
             * Step 2 : Group By           
             */

            var visited = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited.ContainsKey(nums[i]) && i - visited[nums[i]] <= k)
                {
                    return true;
                }
                visited[nums[i]] = i;
            }

            return false;

        }

    }
}
