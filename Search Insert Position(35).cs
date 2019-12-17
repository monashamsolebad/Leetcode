public class Solution {
    public int SearchInsert(int[] nums, int target) {
            var low = 0;
            var high = nums.Length - 1;

            while(low <= high)
            {
                var mid = (high - low) / 2 + low;

                if(nums[mid] == target)
                {
                    return mid;
                }
                else if(nums[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low;
    }
}