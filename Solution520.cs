using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
//All letters in this word are capitals, like "USA".
//All letters in this word are not capitals, like "leetcode".
//Only the first letter in this word is capital, like "Google".
    public static class Solution520
    {
        public static bool DetectCapitalUse(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    counter++;

                }
            }
            return counter == word.Length || counter == 0 || counter == 1 && char.IsUpper(word[0]) ? true : false;
             /*
             counter == word.Length; --- true   counter === count of word 
             counter == 0;     --- true          none are capital so it is all small letter 
             counter == 1 and char.IsUpper(word[0]) -- true 
             false ; 


            */



            return false; 
           
        }
    }
}
