public class Solution {
   public bool IsPalindrome(ListNode head) {
       
        ListNode l=head; int length=0, middle=0;
       
        while(l!=null){
            length++;
            l=l.next;
        }
        if (length==1 || length==0) return true;
        middle=length-length/2-1;
        l=head;
        for (int i=0; i<middle; i++){
            l=l.next;
        }
        ListNode l1=l.next, l2=null;
            while(l1.next!=null){
                l2=l1.next;
                l1.next=l1.next.next;
                l2.next=l.next;
                l.next=l2;
            }
        l1=head; l2=head;
        while(middle>=0) {l2=l2.next; middle--;}
        while (l2!=null){
            if (l1.val!=l2.val) return false;
            l1=l1.next; l2=l2.next;
        }
        return true;
    }
}
