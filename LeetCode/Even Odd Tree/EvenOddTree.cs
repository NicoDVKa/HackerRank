

using LeetCode.SameTree;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeetCode.Even_Odd_Tree
{
    public class EvenOddTree
    {


		public static Boolean Execute(TreeNode node)
		{
            Queue<TreeNode> currentLevel = new Queue<TreeNode>();
            Queue<TreeNode> nextLevel = new Queue<TreeNode>();
            currentLevel.Enqueue(node); 
            List<int> levels = new List<int>();
            int level = 1;

			while (currentLevel.Count() > 0)
			{
				TreeNode tmpTree = currentLevel.Dequeue();
                levels.Add(tmpTree.val);
                    
                if(tmpTree.left is not null)
                    nextLevel.Enqueue(tmpTree.left);

                if (tmpTree.right is not null)
                    nextLevel.Enqueue(tmpTree.right);

                if (currentLevel.Count() == 0 && nextLevel.Count() > 0)
                {
                    level++;
                    levels.Add(-1);
                    currentLevel = nextLevel;
                    nextLevel = [];
                }

            }

            Boolean isEven = true;

            for(int i = 0; i < levels.Count ; i++)
            {
                if (levels[i] == -1) continue;

                if (isEven)
                {
                    if (levels[i] % 2 == 0) return false;
                }      
                else
                {
                    if (levels[i] % 2 != 0) return false;
                }

                if (i == levels.Count-1) {
                    break;
                }

                if (levels[i+1] == -1)
                {
                    isEven = !isEven;
                    continue;
                }

                if (isEven && levels[i] >= levels[i + 1])
                    return false;

                if (!isEven && levels[i] <= levels[i + 1])
                    return false;       
            }

            return true;
        }
    }
}
