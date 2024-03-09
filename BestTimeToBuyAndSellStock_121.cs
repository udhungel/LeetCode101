using System;


namespace LeetCode101
{
    public static class BestTimeToBuyAndSellStock_121
    {
        public static int GetBestTimeToBuyAndSellStock()
        {
            //        Input: prices = [7,1,5,3,6,4]
            //        Output: 5
            //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
            //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

            int[] prices = { 7, 1, 5, 3, 6, 4 };

            //What I want to do
            // Note : Profit only happens when  : selling price is > buying Price             
            // Iterate over the loop and see if the  p[i] > buyingPrice that mean there is no profit set the buyingPrice as p[i] 
            // Else check for profit which is  prices[p] - buyingprice where (selling price at that time)

            int buyingPrice = prices[0];
            int profit = 0;

            for (int p = 1; p < prices.Length; p++)
            {
                if (prices[p] < buyingPrice)
                {
                    buyingPrice = prices[p];
                }
                else
                {
                    int currentProfit = prices[p] - buyingPrice;
                    profit = Math.Max(profit, currentProfit);
                }

            }

            return profit;  
            

        }
    }
}
