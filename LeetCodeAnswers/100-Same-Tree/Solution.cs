namespace LeetCodeAnswers._100_Same_Tree;
using Utilities;
public class Solution
{
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