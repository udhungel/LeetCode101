using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class ExcelSheetColumnNumber_171
    {
        public static void GetExcelSheetColumnNumber_171()
        {
            string columnTitle = "ZY";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('A', 1);
            dict.Add('B', 2);
            dict.Add('C', 3);
            dict.Add('D', 4);
            dict.Add('E', 5);
            dict.Add('F', 6);
            dict.Add('G', 7);
            dict.Add('H', 8);
            dict.Add('I', 9);
            dict.Add('J', 10);
            dict.Add('K', 11);
            dict.Add('L', 12);
            dict.Add('M', 13);
            dict.Add('N', 14);
            dict.Add('O', 15);
            dict.Add('P', 16);
            dict.Add('Q', 17);
            dict.Add('R', 18);
            dict.Add('S', 19);
            dict.Add('T', 20);
            dict.Add('U', 21);
            dict.Add('V', 22);
            dict.Add('W', 23);
            dict.Add('X', 24);
            dict.Add('Y', 25);
            dict.Add('Z', 26);
            int res = dict[columnTitle[0]];
            for (int i = 1; i < columnTitle.Length; i++)
            {
                res = (res * 26) + dict[columnTitle[i]];
            }
            
        }
    }
}
