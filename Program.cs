using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayVal = { "USA", "leetcode", "Google", "FlaG" };
            bool retVal = false;
            foreach (var arrayString in arrayVal)
            {
              retVal =  Solution520.DetectCapitalUse(arrayString);
              Console.WriteLine("Given word is {0} - is {1} ", arrayString, retVal);   
             }
                   
            //Console.WriteLine("{" + string.Join(",", resultArray) + "}");
            Console.ReadLine();
        }
    }
}
