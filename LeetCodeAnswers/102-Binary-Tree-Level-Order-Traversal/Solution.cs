namespace LeetCodeAnswers._102_Binary_Tree_Level_Order_Traversal;
using Utilities;

    //https://leetcode.com/problems/binary-tree-level-order-traversal/description/
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root) {
       
        var result  = new List<IList<int>>();
        if (root == null)
            return result;
        
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int levelSize = q.Count;
            var level = new List<int>();

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode current = q.Dequeue();
                level.Add(current.val);
                if (current.left != null)
                {
                    q.Enqueue(current.left);
                }

                if (current.right != null)
                {
                    q.Enqueue(current.right);
                }
                
            }
            result.Add(level);
        }

        return result; 
    }
}