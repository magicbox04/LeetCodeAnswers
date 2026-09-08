namespace LeetCodeAnswers._128_Longest_Consecutive_Sequence;
// https://leetcode.com/problems/longest-consecutive-sequence/description/
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> uniqueNums = new HashSet<int>(nums);
        int maxIncrement = 0;
        foreach (int num in uniqueNums)
        {
            if (uniqueNums.Contains(num - 1))
            {
                continue;
            }
            else
            {
                int increment = 0;
                while (uniqueNums.Contains(num + increment))
                {
                    maxIncrement = Math.Max(maxIncrement, increment + 1);

                    increment++;
                }
            }
        }
        return maxIncrement;
    }
}