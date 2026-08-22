namespace LeetCodeAnswers._141_Linked_List_Cycle;

// https://leetcode.com/problems/linked-list-cycle/
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class Solution {
    public bool HasCycle(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head; 

        while (fast != null && fast.next != null)
        {
            
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow)
            {
                return true;
            }
        }

        return false;
    }
}