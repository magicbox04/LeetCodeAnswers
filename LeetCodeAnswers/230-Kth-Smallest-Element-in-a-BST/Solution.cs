namespace Utilities._230_Kth_Smallest_Element_in_a_BST;
// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
public class Solution
{
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root;
        
        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            
            TreeNode p = stack.Pop();
            k--;

            if (k == 0)
            {
                return p.val;
            }
            curr  = p.right;
        }

        return -1;
    }
}