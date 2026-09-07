using System.Data;
using System.Runtime.InteropServices;
using Utilities;
namespace LeetCodeAnswers;

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
        {
            return true;
        }
        else if ((p == null && q != null) || (p != null && q == null))
        {
            return false;
        }
        else
        {
            if (p.val == q.val)
            {
                bool firstVal  = IsSameTree(p.left, q.left);
                bool secondVal = IsSameTree(p.right, q.right);
                
                return firstVal && secondVal;
            }
        }
        return false;
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