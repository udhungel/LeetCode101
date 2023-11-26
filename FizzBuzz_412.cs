using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class FizzBuzz_412
    {
        public static void FizzBuzz()
        {
            /*
             * 
             *  answer[i] == "FizzBuzz" if i is divisible by 3 and 5.      --- 1     if
                answer[i] == "Fizz" if i is divisible by 3.                --- 2     if
                answer[i] == "Buzz" if i is divisible by 5.                --- 3     if 
                answer[i] == i (as a string) if none of the above conditions are true.   --- else
             */

            int n = 15; // Output = ["1", "2", "Fizz", "4", "Buzz"]
           List<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add($"{i}");
                }

            }



            //Second Result 

            var retVal = Enumerable.Range(1, n)
                                   .Select(x=>x%3== 0 && x % 5 ==0 ? "FizzBuzz" :
                                                         x % 3 == 0 ? "Fizz" :
                                                         x % 5 == 0 ? "Buzz" : 
                                                         x.ToString()

                                   ).ToList();

        }
    }
}

