namespace LeetCodeAnswers._143_Reorder_List;

// https://leetcode.com/problems/reorder-list/description/
public class ListNode {
    public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public void ReorderList(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode midpoint = slow.next;
        ListNode prev = null;
        slow.next = null;

        while (midpoint != null)
        {
            ListNode temp = midpoint.next;
            midpoint.next = prev;
            prev = midpoint;
            midpoint = temp;
        }

        ListNode secondHead = prev;
        while (secondHead != null && head != null)
        {
            ListNode temp1 = head.next;
            ListNode temp2 = secondHead.next;

            head.next = secondHead;
            secondHead.next = temp1;

            head = temp1;
            secondHead = temp2;
        }
    }
}