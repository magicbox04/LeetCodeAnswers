namespace LeetCodeAnswers._139_Word_Break;

public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<String> set = new HashSet<string>(wordDict);
        bool [] dp = new bool[s.Length];
        Array.Fill(dp, false);
        int left = 0;
        
        for (int right = 0; right < s.Length; right++)
        {
            for (int index = 0; index < dp.Length; index++)
            {
                if (dp[index] == true && wordDict.Contains(s.Substring(index + 1, right - index)))
                {
                    dp[right] = true;
                }
            }
            if (wordDict.Contains(s.Substring(left, right - left + 1)))
            {
                dp[right] = true;
            }
            
        }
        return dp[s.Length - 1];
    }
}