namespace Utilities._235_Lowest_Common_Ancestor_of_a_Binary_Search_Tree;
using Utilities;

// https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/description/

public class Soltuion
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode curr = root;

        while (curr != null)
        {
            if (p.val < curr.val && q.val < curr.val)
            {
                curr = curr.left;
            }
            else if (p.val > curr.val && q.val > curr.val)
            {
                curr = curr.right;
            }
            else
            {
                return curr;
            }
        }

        return null;
    }
}