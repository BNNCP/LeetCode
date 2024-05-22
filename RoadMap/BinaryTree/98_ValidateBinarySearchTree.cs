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
    public bool IsValidBST(TreeNode root)
    {
        return IsValid(root, null, null);
    }

    public bool IsValid(TreeNode root, int? min, int? max)
    {
        if (root == null)
        {
            return true;
        }

        var current = root.val;

        if (current <= min || current >= max)
        {
            return false;
        }

        return IsValid(root.left, min, current) && IsValid(root.right, current, max);
    }
}