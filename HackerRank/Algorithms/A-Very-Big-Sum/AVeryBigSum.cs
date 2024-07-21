
namespace HackerRank.A_Very_Big_Sum
{
    public class AVeryBigSum
    {
        public static long aVeryBigSum(List<long> ar)
        {
            long result = 0;

            foreach (long v in ar) result += v;
 
            return result;
        }

        public static long aVeryBigSumV1(List<long> ar)
        {
            return ar.Sum(x => x);
        }
    }
}
