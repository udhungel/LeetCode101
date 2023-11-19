using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class ReverseString_344
    {
        public static void GetReverseString()
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            //Output s: ["o","l","l","e","h"]

            s.Reverse().ToArray().CopyTo(s,0);

           var temp = s.Reverse().ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = temp[i];
            }
           
        }
    }
}
