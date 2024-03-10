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

            int[] prices = { 7,1,5,3,6,4 };
            //       Days   1, 2,3, 4, 5, 6 

            int profit = 0;
            int intialBuy = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > intialBuy)
                {
                    intialBuy = prices[i];
                }
                else
                {
                    int currentProfit= prices[i] - intialBuy;
                    profit = Math.Max(profit, currentProfit);
                }

            }

            return profit;
            //What I want to do
            // Part 1 
            // In order to get the profit need to get the lowest price in a array
            // Note : Profit only happens when  : selling price is > buying Price


            // Part 2
            // Iterate over the loop and see if the (//check lowest )  p[i] < buyingPrice that mean there is no profit set the buyingPrice as p[i] 
            // Else check for profit which is  prices[p] - buyingprice where (selling price at that time)




            //return 0;

        }
    }
}







