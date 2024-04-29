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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode headNode = ListNode();
        ListNode tempNode = headNode;
        while (list1 && list2)
        {
            if (list1.val > list2.val)
            {
                tempNode.next = list2;
                list2 = list2.next;
            }
            else
            {
                tempNode.next = list1;
                list1 = list1.next;
            }
            tempNode.next;
        }

        if (list1)
        {
            tempNode.next = list1;
        }
        else if (list2)
        {
            tempNode.next = list2;
        }

        return headNode.next;
    }
}


// 1 > 3 > 5
// 2 > 4 > 6

// 1 > 2 > 3
// 4 > 5 > 6