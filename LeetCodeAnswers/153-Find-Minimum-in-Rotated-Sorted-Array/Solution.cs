namespace LeetCodeAnswers._153_Find_Minimum_in_Rotated_Sorted_Array;
// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
public class Solution
{
    public int FindMin(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int midPoint = 0;
        while (left <= right)
        {
            midPoint = left + (right - left) / 2;

            if (nums[midPoint] < nums[right])
            {
                right = midPoint;
            }
            else
            {
                left = midPoint + 1;
                
            }
        }
        return nums[midPoint];
    }
}