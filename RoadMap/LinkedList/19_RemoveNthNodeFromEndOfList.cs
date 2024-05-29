/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        Dictionary<int, ListNode> NodeMap = new Dictionary<int, ListNode>();
        int index = 0;
        for (ListNode node = head; node != null; node = node.next)
        {
            NodeMap.Add(index, node);
            index++;
        }

        int target = index - n;
        if (target == 0)
        {
            return head.next;
        }
        ListNode targetNode = NodeMap[target];
        ListNode prevNode = NodeMap[target - 1];
        prevNode.next = targetNode.next;

        return head;
    }
}