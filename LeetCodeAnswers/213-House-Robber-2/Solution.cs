namespace LeetCodeAnswers._213_House_Robber_2;

public class Solution
{
    public int Rob(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        int [] dpWithFirst =  new int[nums.Length];
        int [] dpWithoutFirst =  new int[nums.Length];
        int prev1 = 0;
        int prev2 = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            
            dpWithFirst[i] = Math.Max(prev1, prev2 + nums[i]);
            prev2 = prev1;
            prev1 = dpWithFirst[i];
        }
        prev1 = 0;
        prev2 = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            
            dpWithoutFirst[i] = Math.Max(prev1, prev2 + nums[i]);
            prev2 = prev1;
            prev1 = dpWithoutFirst[i];
        }
        return Math.Max(dpWithFirst[nums.Length - 2], dpWithoutFirst[nums.Length - 1]);
    }
}