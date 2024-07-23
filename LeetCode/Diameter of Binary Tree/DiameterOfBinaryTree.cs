using LeetCode.SameTree;

namespace LeetCode.Diameter_of_Binary_Tree
{
    public class DiameterOfBinaryTree
    {
        int max = 0;

        public int GetDiameter(TreeNode root)
        {
            this.CalculateDiameter(root);
            return max;
        }

        public int CalculateDiameter(TreeNode root)
        {
            if (root == null) return 0;
            int left = this.CalculateDiameter(root.left);
            int right = this.CalculateDiameter(root.right);
            max = Math.Max(max, left + right);
            return Math.Max(left, right) + 1;
        }
    }
}
