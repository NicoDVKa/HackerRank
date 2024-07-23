namespace LeetCode.SameTree
{
    public class PrintSameTree
    {
        public static void Print()
        {
            TreeNode secondRightChild = new TreeNode(6);
            TreeNode rightChild = new TreeNode(val: 3, right: secondRightChild);
            TreeNode root = new TreeNode();

            
            var result = SameTree.IsSameTree(null, null);    

            Console.WriteLine(  result );
        }
    }
}
