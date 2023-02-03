using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{

//    Example 1:

//Input: x = 121
//Output: true
//Explanation: 121 reads as 121 from left to right and from right to left.
//Example 2:

//Input: x = -121
//Output: false
//Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
//Example 3:

//Input: x = 10
//Output: false
//Explanation: Reads 01 from right to left.Therefore it is not a palindrome.




    public static class PalindromeNumber_9
    {
        public static bool IsPalindrome(int x = 121)
        {
            int reversedX= 0;
            int remainderX = 0;
            int y = x;
            if (x<0)
            {
                return false;

            }
            while (y != 0)
            {
                remainderX = y % 10;
                reversedX = reversedX * 10 + remainderX;
                y = y / 10; 
            }
            return reversedX == y ? true : false ;                      
           /*
            * 121 = 121   ; 16461 = 16461  return true  else return false 
            * x %10 = 1 -- this our remainder 
            * result * 10 + remaider
            * 120 / 10 = 12 
            * x/10 ==> 12  
            * put in a loop 
            * 
         
            * 
            * 
            */           
           
        }
    }
}
