namespace LeetCodeAnswers._104_Maximum_Depth_of_Binary_Tree;
using Utilities;

public class Solution
{
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