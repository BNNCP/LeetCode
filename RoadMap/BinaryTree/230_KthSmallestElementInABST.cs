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
public class Solution {
    
    private void InOrder(TreeNode root, List<int> result){
        if(root == null){
            return;
        }
        InOrder(root.left, result);
        result.Add(root.val);
        InOrder(root.right, result);
    }

    public int KthSmallest(TreeNode root, int k) {
        List<int> result = new List<int>();
        InOrder(root, result);
        return result[k-1];
    }
}