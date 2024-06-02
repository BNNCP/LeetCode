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
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> result = new List<string>();
        string curVal = "";
        BackTracking(root, ref result, curVal);
        return result;
    }

    public void BackTracking(TreeNode root, ref List<string> result, string curVal)
    {
        if (root != null)
        {
            if (root.left == null && root.right == null)
            {
                curVal += root.val;
                result.Add(curVal);
                return;
            }

            curVal += root.val + "->";
            BackTracking(root.left, ref result, curVal);
            BackTracking(root.right, ref result, curVal);
        }
    }
}