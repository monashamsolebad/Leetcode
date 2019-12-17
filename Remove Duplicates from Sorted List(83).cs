public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        
         if (head == null || head.next == null)
            {
                return head;
            }

            var start = head;
            while (start.next != null)
            {
                if (start.val == start.next.val)
                {
                    start.next = start.next.next;
                }
                else
                {
                    start = start.next;
                }
            }

            return head;
    }
}