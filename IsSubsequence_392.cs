using LanguageExt.UnitsOfMeasure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public  class IsSubsequence_392
    {
       

        public static bool IsSubsequence()
        {
            string s = "abc", t = "ahbgdc";
            // true
            int i = 0; //to hold the index of the string s , it is a counter 

            // increasing index of t while checking if any characters in s exists in t 
            // we are also checking its relative position 
            for (int j = 0; j < t.Length && i<s.Length; j++)
            {
                if (s[i] == t[j])
                {
                    i++;

                }

            }
            return i == s.Length;
        }

    
    }
}
