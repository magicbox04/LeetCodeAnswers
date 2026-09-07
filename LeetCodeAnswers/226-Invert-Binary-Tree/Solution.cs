namespace LeetCodeAnswers._226_Invert_Binary_Tree;
using Utilities;
// https://leetcode.com/problems/invert-binary-tree/description/

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root != null)
        {
            TreeNode tempLeft = root.left;
            TreeNode tempRight = root.right;
            
            InvertTree(tempLeft);
            InvertTree(tempRight);

            root.left = tempRight;
            root.right = tempLeft;
        }
        return root;
    }
}