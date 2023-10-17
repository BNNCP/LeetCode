using System.Collections.Generic;
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode nodeL = AlternateNode(l1);
        ListNode nodeR = AlternateNode(l2);
        return nodeL;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public void ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode AlternateNode(ListNode node)
    {
        ListNode prevnode = null;
        ListNode thisnode = node;

        while (thisnode != null)
        {
            ListNode nextnode = thisnode.next;
            thisnode.next = prevnode;
            prevnode = thisnode;
            thisnode = nextnode;
        }

        return prevnode;
    }
}

//[1,2,3,4]
//next node = 2; thisnode.next = null;