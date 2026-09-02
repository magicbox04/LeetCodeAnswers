namespace LeetCodeAnswers._121_Best_Time_to_Buy_and_Sell_Stock;
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public class Solution {
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int lowestPriceIndex = 0;
        int lowesterPrice = int.MaxValue;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < lowesterPrice)
            {
                lowesterPrice = prices[i];
                lowestPriceIndex = i;
            }
            
            if (prices[i] - lowesterPrice > maxProfit)
            {
                maxProfit = prices[i] - lowesterPrice;
            }
        }
        return maxProfit;
    }
}