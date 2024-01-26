using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class ClimbingStairs_70
    {
        public static int ClimingStairs(int n)
        {
            //if (n == 1)
            //    return 1;
            //if (n == 2)
            //    return 2;
            //int c = 0;
            //int a = 1;
            //int b = 2;
            //// 1,1,2,3,5,8,11
            ////   a b c
            //for (int i = 3; i <= n; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;

            //}
            //return c;

            //---------------------------------------------------------------------------------------//
            //---------------------------------------------------------------------------------------//
            //----------------------------------------Dynamic Programming---------------------------//            

            if (n == 1)
                return n;
            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            //Console.WriteLine(dp[n]);  
            return dp[n];

        }
    }
}
