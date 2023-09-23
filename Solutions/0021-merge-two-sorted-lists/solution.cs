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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
     if (list1 == null && list2 == null)
        return null;
    ListNode result = new ListNode();
    ListNode resultCopy = result;
    var first1 = list1;
    var first2 = list2;
    while (first1 != null || first2 != null)
    {
        if (first1 == null)
        {
            result.val = first2.val;
            result.next = first2.next;
        }


        if (first2 == null)
        {
            result.val = first1.val;
            result.next = first1.next;

        }

        if (first1 == null || first2 == null)
            break;

        if (first1.val <= first2.val)
        {
            result.val = first1.val;
            result.next = new ListNode();
            result = result.next;
            first1 = first1.next;
        }
        else
        {
            result.val = first2.val;
            result.next = new ListNode();
            result = result.next;
            first2 = first2.next;
        }


    }

    return resultCopy;
    }
}
