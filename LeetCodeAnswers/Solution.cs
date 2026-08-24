using System.Data;

namespace LeetCodeAnswers;
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
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
        slow.next = null;
        ListNode prev = null;
        while (midpoint != null)
        {
            ListNode temp = midpoint.next;
            midpoint.next = prev;
            prev = midpoint;
            midpoint = temp;
        }

        while (head != null && prev != null)
        {
            ListNode temp1 = head.next;
            ListNode temp2 = prev.next;
            head.next = prev;
            prev.next = temp1;
            head = temp1; 
            prev = temp2;
        }
    }
}

class Program {
    static void Main(string[] args) {
        Solution sol = new Solution();
        int[] s = [1,2,3,4];
        
        Console.WriteLine((s));
    }
}