using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class MoveZeroes_283
    {
        public static void MoveZeroes()
        {
            int[] nums = { 0, 1, 0, 3, 12 };


            //Output = [1,3,12,0,0]
            /*
             *     index          |    value            |       expected 
             *        0                  0                        1
             *        1                  1                        3
             *        2                  0                       12 
             *        3                  3                        0
             *        4                  12                       0
             */

            // break it into 2 parts 
            var nonZeroValues = nums.Where(x => x != 0).ToArray();
            var ZeroValues = nums.Where(x => x == 0).ToArray();

            //foreach 1st part

            for (int i = 0; i < nonZeroValues.Length; i++)
            {
                nums[i] = nonZeroValues[i];
            }

            for (int i = 0; i < ZeroValues.Length; i++)
            {
                nums[i + nonZeroValues.Length] = ZeroValues[i];
            }
        }
    }
}
