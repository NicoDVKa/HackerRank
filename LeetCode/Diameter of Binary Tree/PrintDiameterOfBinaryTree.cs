

using LeetCode.SameTree;

namespace LeetCode.Diameter_of_Binary_Tree
{
    public class PrintDiameterOfBinaryTree
    {
        public static void Print()
        {
            int result;
            TreeNode leftChild = new TreeNode(2, new TreeNode(4), new TreeNode(5));
            TreeNode root = new TreeNode(0, leftChild, new TreeNode(3));
            result = new DiameterOfBinaryTree().GetDiameter(root);
            Console.WriteLine(result);


            TreeNode root1 = new TreeNode(0, new TreeNode(2), new TreeNode(3));
            result = new DiameterOfBinaryTree().GetDiameter(root1);
            Console.WriteLine(result);
        }
    }
}
