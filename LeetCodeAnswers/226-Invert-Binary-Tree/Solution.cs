namespace LeetCodeAnswers._226_Invert_Binary_Tree;
// https://leetcode.com/problems/invert-binary-tree/description/
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

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