
using HackerRank.Plus_Minus;

namespace HackerRank.Algorithms.StairCase
{
    public class PrintStairCase
    {
        public static void Print()
        {
            IList<String> strings = StairCase.Staircase(4);

            foreach (string str in strings)
                Console.WriteLine(str);
        }
    }
}
