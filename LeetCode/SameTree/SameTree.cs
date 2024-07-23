
namespace LeetCode.SameTree
{
    public class SameTree
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            var listOfTreeP = TreeToList(p);
            var listOfTreeQ = TreeToList(q);
  
            if(listOfTreeP.SequenceEqual(listOfTreeQ))
                return true;

            return false;
        }

        public static List<int?> TreeToList(TreeNode tree)
        {
            List<int?> list = new List<int?>();
            if(tree is null)
                return list;
            list.Add(tree.val);

            if(tree.left is not null)
            {
                var left = TreeToList(tree.left);
                left.ForEach(l => list.Add(l));
            }

            if (tree.left is null && tree.right is not null)
            {
                list.Add(null);
            }

            if (tree.right is not null)
            {
                var right = TreeToList(tree.right);
                right.ForEach(l => list.Add(l));
            }

            return list;
        }
    }
}
