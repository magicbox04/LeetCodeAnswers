namespace LeetCodeAnswers._572_Subtree_of_Another_Tree;
using Utilities;
// https://leetcode.com/problems/subtree-of-another-tree/description/
public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null) 
            return false;
        if (IsSameTree(root, subRoot)) 
            return true;
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode a, TreeNode b) {
        if (a == null && b == null) 
            return true;
        if (a == null || b == null) 
            return false;
        if (a.val != b.val) 
            return false;
        return IsSameTree(a.left, b.left) && IsSameTree(a.right, b.right);
    }
}