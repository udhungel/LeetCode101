using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    internal static class ValidParenthesis_20
    {
        public static bool IsValid_Parenthesis()
        {
            string s = "]"; //example 2 
            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' },
            };

            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == ')' || c == '}' || c == ']') //closing braces 
                {
                    if (stack.Count > 0) // eg stack count is 1 
                    {
                        if (dict[stack.Peek()] != c)
                        {
                            return false;

                        }
                        stack.Pop(); // empty 
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                { 
                stack.Push(c); // intially it will push to stack 
                }

            }

            return stack.Count == 0;  // true ; 

            
        }
        
        
        /* Dictionaru to hold the char in the string since we know the contraint are  basically all the characters that are in example
             * Stack to hold the intial value -- 
             * Foreach loop to iterate through my string s 
             * 
            
             */




        
    }
}
