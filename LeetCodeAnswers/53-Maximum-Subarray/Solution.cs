namespace LeetCodeAnswers._53_Maximum_Subarray;

public class Solution
{
    public int MaxSubArray(int[] nums) {
        int [] dp = new int[nums.Length];
        int answer = dp[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0)
            {
                dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
                if (dp[i] > answer)
                {
                    answer = dp[i];
                }
            }
            else
            {
                dp[i] = nums[i];
            }
        }

        return answer;
    }
}