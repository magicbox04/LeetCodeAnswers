using System.Data;
using System.Runtime.InteropServices;
using Utilities;
namespace LeetCodeAnswers;

public class Solution {
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            return Math.Max(MaxDepth(root.left) + 1, MaxDepth(root.right) + 1);
        }
    }
}

class Program {
    static void Main(string[] args) {
        Solution sol = new Solution();
        int[] nums = [1,1,1,2,2,3];
        int[][] matrix = [[1]]; 
        String s1 = "ABAB";
        String s2 = "dcda";
        List<string> strs = new List<string>(["Hello","World"]);
        
        
        Console.WriteLine(sol.TopKFrequent(nums, 2));
    }
}