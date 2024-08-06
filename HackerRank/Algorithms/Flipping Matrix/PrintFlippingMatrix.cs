

namespace HackerRank.Algorithms.Flipping_Matrix
{
    public class PrintFlippingMatrix
    {
        public static void Print()
        {
            List<List<int>> matrix = [[112, 42, 83, 119],
                                      [56, 125, 56, 49],
                                      [15, 78, 101, 43],
                                      [62, 98, 114, 108]];

            Console.WriteLine($"The matrix is: ");
            matrix.ForEach(x => {
                x.ForEach(j => Console.Write(j + " "));
                Console.WriteLine();
            });

            var result = FlippingMatrix.Execute(matrix);
            Console.WriteLine($"The result is: {result}");

        }
    }
}
