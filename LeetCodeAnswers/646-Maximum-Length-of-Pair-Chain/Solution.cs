namespace LeetCodeAnswers._646_Maximum_Length_of_Pair_Chain;

public class Solution
{
    public int FindLongestChain(int[][] pairs) {
        Array.Sort(pairs, (a, b) => a[0].CompareTo(b[0]));

        int[] dp = new int[pairs.Length];
        Array.Fill(dp, 1);
        dp[0] = 1;
        for (int i = 1; i < pairs.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (pairs[i][0] > pairs[j][1])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
                
            }
        }
        return dp.Max();
    }
}