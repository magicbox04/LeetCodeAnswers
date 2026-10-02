namespace LeetCodeAnswers._1448_Count_Good_Nodes_in_Binary_Tree;
using Utilities;

// https://leetcode.com/problems/count-good-nodes-in-binary-tree/description/
public class Solution
{
    public int GoodNodes(TreeNode root)
    {
        return ActualGoodNodes(root, root.val);
    }

    private int ActualGoodNodes(TreeNode root, int maxValue)
    {
        if (root == null)
            return 0;

        int isGood = 0;
        if (root.val >= maxValue)
        {
            maxValue = root.val;
            isGood = 1; 
        }

        int left = ActualGoodNodes(root.left, maxValue);
        int right = ActualGoodNodes(root.right, maxValue);

        int returnVal = left + right + isGood;

        return returnVal;
    }
}