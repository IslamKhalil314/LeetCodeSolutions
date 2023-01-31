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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
      int i = 0;
    BigInteger sumL1 = 0;
    BigInteger sumL2 = 0;
    while (l1 != null)
    {
        sumL1 += l1.val * BigInteger.Pow(10, i);

        i++;
        l1 = l1.next;
    }

    i = 0;
    while (l2 != null)
    {
        sumL2 += l2.val * BigInteger.Pow(10, i);
        i++;
        l2 = l2.next;
    }

    var finalSum = sumL1 + sumL2;


    var val = (int)(finalSum % 10);
    var node = new ListNode(val);
    finalSum /= 10;
    while (finalSum != 0)
    {
        var val1 = (int)(finalSum % 10);
        var node1 = new ListNode(val1);
        var temp = node;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = node1;
        finalSum /= 10;

    }
    return node;
    }
}