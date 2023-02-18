using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public static class AddBinary_67
    {
        public static string AddBinary()
        {
            String a = "11", b = "1"; 
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0)
                {
                    sum += a[i--] - '0';
                }
                if (j >= 0)
                {
                    sum += b[j--] - '0';
                }
                sb.Insert(0, sum % 2);
                carry = sum / 2;
            }
            if (carry > 0)
            {
                sb.Insert(0, 1);
            }
            return sb.ToString();


        }
    }
}
