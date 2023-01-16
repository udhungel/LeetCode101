using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class Solution13
    {
        /*
            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.
         
        Above condition are my IF condition explicitly . Need to loop from last to first 
        for(i=s.lngth ; i<=0 ; i--)
         if( 
        (I && V||X)
     OR ( X && L||C)
     OR ( C && D||M)
           )
        any codition satisfies above subtract i - i-1;  and i--;
        else
            add 
         */
        public int RomanToInt(string s)
        {

            Dictionary<char, int> romans = new Dictionary<char, int>();
            romans.Add('I', 1);
            romans.Add('V', 5);
            romans.Add('X', 10);
            romans.Add('L', 50);
            romans.Add('C', 100);
            romans.Add('D', 500);
            romans.Add('M', 1000);

            int result = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    if ((s[i - 1] == 'I' && (s[i] == 'V' || s[i] == 'X')) 
                        || (s[i - 1] == 'X' && (s[i] == 'L' || s[i] == 'C'))
                        || (s[i - 1] == 'C' && (s[i] == 'D' || s[i] == 'M'))
                       )
                    {
                        result += romans[s[i]] - romans[s[i - 1]];
                        i -= 1;
                    }
                    else
                        result += romans[s[i]];
                }
                else
                    result += romans[s[i]];
            }
            return result;

        }
    }
}
    
