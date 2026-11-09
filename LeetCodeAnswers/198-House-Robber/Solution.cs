namespace LeetCodeAnswers._198_House_Robber;

public class Solution
{
    public int Rob(int[] nums) {
        int prev2 = 0, prev1 = 0;
        foreach (int n in nums) 
        {
            int cur = Math.Max(prev1, prev2 + n);
            prev2 = prev1;
            prev1 = cur;
        }
        return prev1;
    }
}