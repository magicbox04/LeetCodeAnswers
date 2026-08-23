namespace LeetCodeAnswers._347_Top_K_Frequent_Elements;

public class Solution_withBucketSort_
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], 0);
            }
            dict[nums[i]]++;
        }
        
        var buckets = new List<int>?[nums.Length + 1];
        foreach (var kv in dict)
        {
            int freq = kv.Value;
            buckets[freq] ??= new List<int>();
            buckets[freq].Add(kv.Key);
        }
        var result = new List<int>(k);
        for (int freq = buckets.Length - 1; freq >= 0 && result.Count < k; freq--)
        {
            if (buckets[freq] == null) continue;
            foreach (var num in buckets[freq])
            {
                result.Add(num);
                if (result.Count == k) break;
            }
        }
        return result.ToArray();
    }
}