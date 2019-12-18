public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if (nums.Length != nums.Distinct().Count())
      {
       return true;
      }
        return false;
    }
}
