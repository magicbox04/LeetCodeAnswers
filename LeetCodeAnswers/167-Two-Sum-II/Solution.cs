namespace LeetCodeAnswers._167_Two_Sum_II;
// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/description/
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                return new[] { left+1, right+1 };
            } 
            else if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return null;
    }
}