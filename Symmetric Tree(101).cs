public class Solution {
    public bool IsSymmetric(TreeNode root) {
        return root == null || this.isSymmetricRecursion(root.left, root.right);
     
    }
       private bool isSymmetricRecursion(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
            {
                return true;
            }
            else if(node1 == null || node2 == null)
            {
                return false;
            }

            if (node1.val != node2.val)
            {
                return false;
            }

            return this.isSymmetricRecursion(node1.left, node2.right)
                   && this.isSymmetricRecursion(node1.right, node2.left);
        }
}
