namespace LeetCodeAnswers._15_3_Sum;
// https://leetcode.com/problems/3sum/
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        nums.Sort();
        for (int target = 0; target < nums.Length - 2; target++)
        {
            if (target > 0 && nums[target] == nums[target - 1])
            {
                continue;
            }

            if (nums[target] > 0)
            {
                break;
            }
            
            int left = target + 1;
            int right =  nums.Length - 1;
            while (left < right)
            {
                if (nums[target] + nums[left] + nums[right] == 0)
                {
                    result.Add(new List<int> { nums[target], nums[left], nums[right] });
                    left++;
                    right--;
                    while (left < right && nums[left - 1] == nums[left])
                    {
                        left++;
                    }
                    while (left < right && nums[right + 1] == nums[right])
                    {
                        right--;
                    }
                }
                else if (left < right && nums[target] + nums[left] + nums[right] < 0)
                {
                    left++;
                    
                }
                else
                {
                    right--; 
                }
            }
        }
        return result;
    }
}