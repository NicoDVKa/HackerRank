
using LeetCode.SameTree;

namespace LeetCode.Even_Odd_Tree
{
    public class PrintEvenOddTree
    {

        public static void Print()
        {


            //               1
            //          10       2
            //        5   7    9  11

            TreeNode root1 = new TreeNode(1,
                                left: new TreeNode(10, left: new TreeNode(5), right: new TreeNode(7)),
                                right: new TreeNode(2, left: new TreeNode(9), right: new TreeNode(11)));

            Console.WriteLine(EvenOddTree.Execute(root1));



            //                2
            //           12       8
            //         5   9     n n
            //       18  16

            TreeNode root2 = new TreeNode(2);
            Console.WriteLine(EvenOddTree.Execute(root2));

        }
    }
}
