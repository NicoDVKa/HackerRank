
namespace HackerRank.A_Very_Big_Sum
{
    public class PrintAVeryBigSum
    {
        public static void Print()
        {
            var arr = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

            var result = AVeryBigSum.aVeryBigSum(arr);

            Console.WriteLine(result);
        }
    }
}
