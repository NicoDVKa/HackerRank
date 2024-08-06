
namespace HackerRank.Algorithms.Flipping_Matrix
{
    public class FlippingMatrix
    {
        public static int Execute(List<List<int>> matrix)
        {
            List<int> result = new List<int>();
            List<int> tmp = new List<int>();    

            int matrixSize = matrix.Count;
            int quadrantSize = matrixSize / 2;

            for (int i = 0; i < quadrantSize; i++)
            {
                for(int j = 0; j < quadrantSize; j++)
                {
                    tmp.Add(matrix[i][j]);  // upper-left
                    tmp.Add(matrix[matrixSize-1-i][j]); //bottom-left
                    tmp.Add(matrix[i][matrixSize-1-j]); //upper-right
                    tmp.Add(matrix[matrixSize-1-i][matrixSize-1-j]); //bottom-right
                    result.Add(tmp.Max());
                    tmp.Clear();
                }
            }

            return result.Sum();
        }
    }
}
