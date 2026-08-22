namespace LeetCodeAnswers._15_3_Sum;
// https://leetcode.com/problems/3sum/
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        nums.Sort();
        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length-2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            if (nums[i] > 0)
            {
                break;
            }
            
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });                    
                    left++;
                    right--;
                    
                    while (left < right && nums[left] == nums[left-1])
                    {
                        left++;
                    }

                    while (left < right && nums[right] == nums[right+1])
                    {
                        right--;
                    }
                }
                else if (nums[i] + nums[left] + nums[right] < 0)
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