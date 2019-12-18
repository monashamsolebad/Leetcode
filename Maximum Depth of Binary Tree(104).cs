public class Solution {
    public int MaxDepth(TreeNode root) {
         if (root == null) return 0;

            return Math.Max(this.MaxDepth(root.left), this.MaxDepth(root.right)) + 1;
    }
}
