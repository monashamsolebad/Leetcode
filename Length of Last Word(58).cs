public class Solution {
    public int LengthOfLastWord(string s) {
        
        if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var trimed = s.TrimEnd();

            int i;
            for (i = trimed.Length - 1; i >= 0; i--)
            {
                if (trimed[i] == ' ')
                {
                    return trimed.Length - 1 - i;
                }
            }

            return trimed.Length - 1 - i >= 0 ? trimed.Length - 1 - i : 0;
    }
}