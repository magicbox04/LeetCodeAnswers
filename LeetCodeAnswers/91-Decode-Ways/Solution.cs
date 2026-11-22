namespace LeetCodeAnswers._91_Decode_Ways;

public class Solution
{
    public int NumDecodings(string s)
    {
        int n = s.Length;
        int[] dp = new int[n + 1];
        dp[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            if (s[i - 1] != '0')
            {
                dp[i] = dp[i - 1];
            }

            if (i >= 2)
            {
                int two = (s[i - 2] - '0') * 10 + (s[i - 1] - '0');
                if (two >= 10 && two <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }
        }
        return dp[n];
    }
}