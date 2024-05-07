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
    public bool IsSymmetric(TreeNode root)
    {
        return CheckSymetry(root.left, root.right);
    }

    public bool CheckSymetry(TreeNode left, TreeNode right)
    {
        if (left == null || right == null)
        {
            return left?.val == right?.val;
        }
        if (left.val != right.val)
        {
            return false;
        }
        return CheckSymetry(left.left, right.right) && CheckSymetry(left.right, right.left);
    }
}