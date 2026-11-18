namespace LeetCodeAnswers._78_Subsets;

public class Solution
{
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        var path = new List<int>();
        backtrack(result, path, nums, 0);
        return result;
    }

    void backtrack(List<IList<int>> result, List<int> path, int[] nums, int start)
    {
        result.Add(new List<int>(path));

        for (int i = start; i < nums.Length; i++)
        {
            path.Add(nums[i]);
            backtrack(result, path, nums, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}