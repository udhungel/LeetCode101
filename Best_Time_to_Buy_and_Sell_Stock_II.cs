using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode101
{
    public class Best_Time_to_Buy_and_Sell_Stock_II_122
    {
        public static int Best_Time_to_Buy_and_Sell_Stock()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int profit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    profit += prices[i + 1] - prices[i];
                }
            }
            return profit;
        }
    }
}
