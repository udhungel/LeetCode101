using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class FindtheIndexoftheFirstOccurrenceinaString_5
    {

        public static string FindtheIndexoftheFirstOccurrenceinaString()
        {
            //Given two strings needle and haystack,
            //return the index of the first occurrence of needle in haystack,
            //or -1 if needle is not part of haystack.
            //Example 1 -------------------------------------------------------------
            // haystack = "sadbutsad", needle = "sad"  Output = 0  Explanation sad" occurs at index 0 and 6.The first occurrence is at index 0, so we return 0.
            // Example 2 ---------------------------------------------------------
            //haystack = "leetcode", needle = "leeto"  output = -1 Explanation: "leeto" did not occur in "leetcode", so we return -1.


            string haystack = "sadbutsad", needle = "sad";
            //Explanation sad" occurs at index 0 and 6
            //Step 1 : we will use indexof which return an int if the index of the word is present otherwise it will return -1       


            var result = haystack.IndexOf(needle);  // 0  first occurence , this is enough for the Question 

            
            var resultOccurence2 = haystack.IndexOf(needle, haystack.IndexOf(needle) + 1); // 6  second occurence 


            return "";



        }
           
    }
}
