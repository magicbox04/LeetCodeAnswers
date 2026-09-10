namespace Utilities._238_Product_of_Array_Except_Self;
// https://leetcode.com/problems/product-of-array-except-self/

public class Solution
{
    public int[] ProductExceptSelf(int[] nums) {
        int [] result = new int[nums.Length];
        result[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }
        
        int rightProduct = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            result[i] *= rightProduct * nums[i + 1];
            rightProduct *= nums[i + 1];
        }

        return result;
    }
}