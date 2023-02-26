using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class ValidPalindrome_125
    {
        public static bool ValidPalindrome()
        {
            string s = "A man, a plan, a canal: Panama";  //output true  //Explanation: "amanaplanacanalpanama" is a palindrome.
            /*
             * Palindrome - it reads the same forward and backward  
             * non-alphanumeric characters  -eg space, brackets, hypen, asterix etc 
             * Step 1: Remove non-alphanumeric characters  and lower the upper case   --> originalString 
             * Step 2 : Reverse it . --- > reversedString 
             * Step 3 : Compare and check if originalString = reversedString , then it is a palindrome . For eg : madam = madam ,  satifies to be a palindrome 
             */
            var originalString = s.ToLower().Where(x => char.IsLetterOrDigit(x));
            var reversedString = originalString.Reverse();

            bool result = originalString.SequenceEqual(reversedString);


            return false;




        }
    }
}
