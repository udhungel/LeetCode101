using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public  class PlusOne_66
    {
        public static int[] PlusOne()
        {
            int[] digits = {7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6};  //output = 124 Why ? Incrementing by one gives 123 + 1 = 124. Thus, the result should be [1,2,4].
            /*
             * Step 1 : convert it to an integar 
             * Step 2 : Add 1 to it
             * Step 3 : reverse it back an array 
             */

             BigInteger digitValue =  BigInteger.Parse(string.Concat(digits))+1;
            //another way of doing it 

            //int digitValue1 = int.Parse(string.Join("", digits))+1;

            return digitValue.ToString().Select(x => int.Parse(x.ToString())).ToArray();  // projection  124 ==> // 1 
                                                                                                       // 2                                                                                                                      
                                                                                                       // 3
            //another way of doing it 
            //int[] resultArray1 = digitValue.ToString().Select(x => (int)char.GetNumericValue(x)).ToArray();


           // return new int[] { }; 
             

        }
    }
}
