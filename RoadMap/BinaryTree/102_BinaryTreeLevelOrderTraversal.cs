/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if (root != null)
        {
            queue.Enqueue(root);
        }

        while (queue.Count > 0)
        {
            int levelLength = queue.Count;
            List<int> list = new List<int>();
            for (int i = 0; i < levelLength; i++)
            {
                TreeNode current = queue.Dequeue();

                if (current != null)
                {
                    list.Add(current.val);
                    queue.Enqueue(current.left);
                    queue.Enqueue(current.right);
                }
            }
            if (list.Count > 0)
            {
                result.Add(list);
            }
        }
        return result;
    }
}