namespace LeetCodeAnswers._128_Longest_Consecutive_Sequence;
// https://leetcode.com/problems/longest-consecutive-sequence/description/
public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) 
            return 0;

        int max = 0;
        HashSet<int> set = new HashSet<int>(nums);

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int current = num;
                int length = 1;

                while (set.Contains(current + 1))
                {
                    length++;
                    current++;
                }
                
                max = Math.Max(max, length);
            }
        }
        
        return max;
    }
}