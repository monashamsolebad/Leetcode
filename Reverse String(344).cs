public class Solution {
    
    public void ReverseString(char[] str) {
           helper(str,0,str.Length-1);
    }
    
    public void helper(char[] str, int left, int right)
    {
        if(left>=right)
        {
            return;
        }
        
        char tmp = str[left];
        str[left++]= str[right];
        str[right--] = tmp;
        helper(str,left,right);
    }
}
