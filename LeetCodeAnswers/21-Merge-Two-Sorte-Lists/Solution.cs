namespace LeetCodeAnswers._21_Merge_Two_Sorte_Lists;

// https://leetcode.com/problems/merge-two-sorted-lists/
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy  =  new ListNode(-1);
        ListNode tail = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }
            tail=tail.next;
        }

        tail.next = list1 == null ? list2 : list1;
        return dummy.next;
    }
}