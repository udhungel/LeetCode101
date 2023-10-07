using LanguageExt.UnitsOfMeasure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class LengthofLastWord_58
    {
        public static int GetCountLastWord()
        {
            string s = "Hello  World";
            //expected output 5 

            //var arrVal = s.Split().Where(x => !string.IsNullOrWhiteSpace(x));
            //int myVal = arrVal.Reverse().First().Length;

            var arrVal = s.Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
            int myVal = arrVal.Select(x => x.Length).Last();

            return myVal; 
            
            
        }
    }
}
