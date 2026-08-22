namespace LeetCodeAnswers._11_Container_With_Most_Water;
// https://leetcode.com/problems/container-with-most-water/
public class Solution {
    public int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;
        while (left < right)
        {
            int newMax = Math.Min(height[left], height[right]) * (right - left);
            if (newMax > maxArea)
            {
                maxArea = newMax;
            }
            else if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return maxArea;
    }
}