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
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head==null)
        {
            return head;
        }

        ListNode prev = null;
        ListNode curr = head;
        ListNode next ;

        while(curr!= null)
        {
            next = curr.next; //store the original next(1 -> 2 = 2) before break the link, last (5 -> null= null).
            curr.next = prev; //point the curr to prev (1 -> null), last = (5 -> 4);
            prev = curr; //prev become curr (null become 1), last will become(5)
            curr = next; //curr become (2), last will become (null)
        }
        return prev;
    }
}