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
            var resultArray = Solution1.TwoSum(new int[] { 3, 2, 4 }, 6);
            Console.WriteLine("{" + string.Join(",", resultArray) + "}");
            Console.ReadLine();
        }
    }
}
