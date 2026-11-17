namespace LeetCodeAnswers._300_Longest_Increasing_Subsequence;

public class Solution
{
    public int LengthOfLIS(int[] nums) {
        int[] length = new int[nums.Length];
        int answer = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            length[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    length[i] = Math.Max(length[i], length[j] + 1);
                    
                }
                
            }
            answer = Math.Max(answer, length[i]);
        }

        return answer;
    }
}