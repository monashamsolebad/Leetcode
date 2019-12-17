public class Solution {
    public int MaxSubArray(int[] nums) {
        
            var max = int.MinValue;
            var tempMax = 0;
            foreach (var t in nums)
            {
                tempMax += t;                
                if (tempMax > max)
                {
                    max = tempMax;
                }
                if (tempMax < 0)
                {
                    tempMax = 0;
                }
            }

            return max;
    }
}