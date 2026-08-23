namespace LeetCodeAnswers;

public class Solution {
    public int MaxProfit(int[] prices)
    {
        int minIndex = 0;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (maxProfit < prices[i] - prices[minIndex])
            {
                maxProfit = prices[i] - prices[minIndex];
            }
            if (prices[i] < prices[minIndex])
            {
                minIndex = i;
            }
            
        }
        return maxProfit;
    }
    
}

class Program {
    static void Main(string[] args) {
        Solution sol = new Solution();
        int[] s = [1,2,3,4];
        
        Console.WriteLine((s));
    }
}