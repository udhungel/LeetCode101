using LanguageExt.Pretty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class ClimbingStairs_70
    {
        public static int ClimingStairs(int n)
        {
            //Example 1:

            //Input: n = 2
            //Output: 2
            //Explanation: There are two ways to climb to the top.
            //1. 1 step + 1 step
            //2. 2 steps
            //Example 2:

            //Input: n = 3
            //Output: 3
            //Explanation: There are three ways to climb to the top.
            //1. 1 step + 1 step + 1 step
            //2. 1 step + 2 steps
            //3. 2 steps + 1 step




            /*
             *                       
             *                
             *                                                                 ______________
             *                                                      ______5____|
             *                                           ____4______|
             *                                  ___3_____|
             *                        ___2______|
             *                 __1____|                                                                                         
             *           __0___|
             *           
             *           
             *                 __1____|                                number of way to reach step 1     = A                           
             *           __0___|
             *           
             *           No of ways : 1 
             *                                                                     +              
             *               
             *                        ___2______|                     number of way to reach step 2  = B                             
             *                 __1____|
             *           __0___|                                                   = 
             *           
             *           2 ways 
             *                                  ___3_____|            numerber of way to reach step 3  = C                         
             *                        ___2______|
             *                 __1____|
             *           __0___|
             *           
             *           3 ways 
             *           
             *                                           ____4______|
             *                                  ___3_____|
             *                        ___2______|
             *                 __1____|                                                                                         
             *           __0___|
             *           
             *           1 step + 1 step + 1 step + 1 step 
             *           1 step + 2 step + 1 step  
             *           1 step + 1 step +  2 step 
             *           2 step  + 1 step + 1 step
             *           2 step + 2 steps 
             *           
             *           (n) Steps |   1  |  2   |    3     |      4   |  5    |  6
             *   (c)  Different Ways |   1  |  2   |    3   |      5    |   8   |  13
             */

            //What i want to do ? Declare a, b ,c and add c = a+b  and then interchange the value of a & b in a for loop 
            //// 1,1,2,3,5,8,11
            ////       a b c
            ///


            int a = 1;
            int b = 2;
            int c = 0;

            if (n == 1)
                return 1;
            if (n == 2) return 2;

            for (int i = 3; i <=n; i++)
            {
                c = a + b;
                a = b;
                b = c;

            }

            return c; 






        }
    }
}
