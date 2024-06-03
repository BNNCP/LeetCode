/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> traversal = new HashSet<ListNode>();
        while (head != null)
        {
            if (traversal.Contains(head))
            {
                return true;
            }
            traversal.Add(head);
            head = head.next;
        }
        return false;
    }
}