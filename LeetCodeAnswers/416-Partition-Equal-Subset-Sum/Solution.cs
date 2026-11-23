namespace LeetCodeAnswers._416_Partition_Equal_Subset_Sum;

public class Solution
{
    public bool CanPartition(int[] nums) {
        int sum =  nums.Sum();
        if (sum % 2 != 0)
        {
            return false;
        }
        int target = sum / 2;
        bool[] dp = new bool[target + 1];
        dp[0] = true;
        foreach (int currentNum in nums) {
            for (int i = target; i >= currentNum; i--) {
                if (dp[i - currentNum]) {
                    dp[i] = true;
                }
            }
        }

        return dp[target];
    }
}