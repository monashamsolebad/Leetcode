public class Solution {
 
    private static string SayNext(string start)
    {
        var res = new StringBuilder();
        var pre = 0;
        for (int i = 0; i < start.Length; i++)
        {
            if (start[i] != start[pre])
            {
                res.Append(i - pre).Append(start[pre]);
                pre = i;
            }
        }

        res.Append(start.Length - pre).Append(start[pre]);

        return res.ToString();
    }

    public string CountAndSay(int n) {
            if (n == 1) return "1";

            var pre = CountAndSay(n - 1);

            return SayNext(pre);    
    }
        
    
}