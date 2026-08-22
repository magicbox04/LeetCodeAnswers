namespace LeetCodeAnswers._0217_contains_duplicate;

public class Solution {
    // https://leetcode.com/problems/contains-duplicate/description/
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
        {
            if (!set.Add(num))
            {
                return true;
            } 
        }
        return false;
            
        
    }
}