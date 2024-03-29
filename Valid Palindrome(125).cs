public class Solution {
    public bool IsPalindrome(string s) {
        
        if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            for (int begin = 0, end = s.Length - 1;begin <= end;begin++, end--)
            {
                while (begin < s.Length && !Char.IsLetterOrDigit(s[begin]))          
                {                     
                    begin++;                 
                }                 
                while (end >= 0 && !Char.IsLetterOrDigit(s[end]))
                {
                    end--;
                }

                if (begin >= s.Length || end < 0)
                {
                    return true;
                }

                if (Char.ToLower(s[begin]) != Char.ToLower(s[end]))
                {
                    return false;
                }
            }

            return true;
    }
}
