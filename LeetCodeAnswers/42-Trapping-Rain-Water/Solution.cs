namespace LeetCodeAnswers._42_Trapping_Rain_Water;

public class Solution
{
    public int Trap(int[] height) {
        int [] result = new int[height.Length];
        int localMax = 0;
        for (int i = 0; i < height.Length; i++)
        {
            localMax = Math.Max(localMax, height[i]);
            result[i] = Math.Max(result[i], localMax);
        }

        localMax = 0;
        for (int i = height.Length - 1; i >= 0; i--)
        {
            localMax = Math.Max(localMax, height[i]);
            result[i] = Math.Min(result[i], localMax) - height[i];
        }

        return result.Sum();
    }
}