

namespace HackerRank.Algorithms.Mini_Max_Sum
{
    public class PrintMiniMaxSum
    {
        public static void Print()
        {
            var result1 = MiniMaxSum.Execute([1, 2, 3, 4, 5]);
            var result2 = MiniMaxSum.Execute([3, 4, 5, 8, 9]);
            var result3 = MiniMaxSum.Execute([426980153, 354802167, 142980735, 968217435, 734892650]);
            var result4 = MiniMaxSum.Execute([5, 5, 5, 5, 5]);

            Console.WriteLine(result1.First() + " " + result1.Last());
            Console.WriteLine(result2.First() + " " + result2.Last());
            Console.WriteLine(result3.First() + " " + result3.Last());
            Console.WriteLine(result4.First() + " " + result4.Last());
        }
    }
}
