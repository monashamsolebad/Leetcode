public class Solution {
    public int CountPrimes(int n) {
        
            var isNotPrime = new bool[n];

            for (var i = 2; i < n; i++)
            {
                if(isNotPrime[i]) continue; 
                var start = i + i;
                while (start < n)
                {                     
                    isNotPrime[start] = true;                     
                    start += i;                 
                }             
            }             
            // remove 0 and 1
            return isNotPrime.Skip(2).Count(x => x == false);
        
    }
}
