using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class MajorityElement
    {
        //Input: nums = [3,2,3]     length = 3   so 3/2=              2 > 1.5 
        //Output: 3     

        //Input: nums = [2,2,1,1,1,2,2]
        //Output: 2

        //Hint  element appears more than  length/2

        public static int MajorityElements()
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

            int result = nums.GroupBy(x => x)
                             .Select(x=> new {Key = x.Key , Count = x.Count() } )
                             .Where(x=>x.Count > nums.Length/2)
                             .First().Key;
            //Groupby clause 
            // group by key         1               2    
            // item inside       1,1,1            2,2,2,2 

            // anonymous type    key =    1 |  2      
                               //Count    3 |  4


            return result;

        }
    }
}
