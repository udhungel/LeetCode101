using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LeetCode101
{
    public static class ReverseIntegar_7
    {
        public static int ReverseIntegar()
        {
            int x = -1230; // Output :  -321  --
            bool isNegative = false;
            /*
             * Step 1 : Check if it is negative or not 
             * Ste 2 : Multiply it with -1 -- positive number 
             * Ste 3 : Reverse the number
             * Ste 4 : return the parsed result ( if it was -ve number multiply if - to get the expected output 
             */
            if (x<0)
            {
                isNegative = true;
                x = x * -1; // positive number 
            }
            string strVal = new String(x.ToString().Reverse().ToArray());

            bool isSucess =  int.TryParse(strVal, out int result);

            return isNegative ? result * -1 : result;






        }
    }
}
