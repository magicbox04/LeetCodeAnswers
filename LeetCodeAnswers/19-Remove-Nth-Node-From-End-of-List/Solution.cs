namespace LeetCodeAnswers._19_Remove_Nth_Node_From_End_of_List;

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode prev = null;
        while  (head != null) {
            ListNode temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;
        }
        
        ListNode newHead = prev;
        ListNode newPrev = null;
        for (int i = 0; i < n - 1; i++)
        {
            newPrev = newHead;
            newHead = newHead.next;
        }

        if (newPrev != null)
        {
            newPrev.next = newHead.next;
            head = prev;
            prev = null;
            while  (head != null) {
                ListNode temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }
        
            return prev;
        }
        else
        {
            ListNode nexHead = newHead.next;
            newHead.next = newPrev;
            newHead = nexHead;
            
            head = newHead;
            prev = null;
            while  (head != null) {
                ListNode temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }
            return prev;
        }
    }
}