public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        ListNode prev = null, current = head, next = null; 
        while (current != null) { 
            next = current.next; 
            current.next = prev; 
            prev = current; 
            current = next; 
        } 
        head = prev;
        return head;
        
    }
}
