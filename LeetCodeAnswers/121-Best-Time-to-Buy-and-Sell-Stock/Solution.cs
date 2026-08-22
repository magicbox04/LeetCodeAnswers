namespace LeetCodeAnswers._121_Best_Time_to_Buy_and_Sell_Stock;
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public class Solution {
    public int MaxProfit(int[] prices)
    {
        int maxPrice = 0;
        int minPrice = int.MaxValue;
        int minIndex = 0;
        
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
                minIndex = i;
            }

            if (prices[i] - minPrice > maxPrice && minIndex < i)
            {
                maxPrice = prices[i] - minPrice;
            }
        }

        return maxPrice;
    }
}