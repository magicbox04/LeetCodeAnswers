namespace LeetCodeAnswers._347_Top_K_Frequent_Elements;
// https://leetcode.com/problems/top-k-frequent-elements/
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 0);
            }
            dict[nums[i]]++;
        }
        return dict
            .OrderByDescending(kv => kv.Value)
            .Take(k)
            .Select(kv => kv.Key)
            .ToArray();
    }
}