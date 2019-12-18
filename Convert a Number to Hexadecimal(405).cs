public class Solution {
    public string ToHex(int num) {
        // handle edge cases
        if (num == 0) {
            return "0";
        }
        
        string result = string.Empty;
        int count = 0;
       
        while(num != 0 && count < 8) {
            count ++;
         
            int tempNum = num & 15;
            result = GetHex(tempNum) + result;

            num = num >> 4;
        }
        
        return result;
    }
    
    public char GetHex(int num) {
        if (num >= 0 && num <= 9) {
            return (char)(num + '0');
        } else {
            return (char)((num - 10) + 'a');
        }
    }
}
