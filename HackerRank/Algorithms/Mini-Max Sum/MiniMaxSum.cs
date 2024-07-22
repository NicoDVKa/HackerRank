
namespace HackerRank.Algorithms.Mini_Max_Sum
{
    public class MiniMaxSum
    {
        public static List<long> Execute(List<int> arr)
        {
            long minSum, maxSum;
            List<long> result = [];

            arr.Sort();
            var longArr = arr.Select(x => (long)x).ToList();

            minSum = longArr.Slice(0, arr.Count - 1).Sum();
            maxSum = longArr.Slice(1, arr.Count - 1).Sum();

            result.Add(minSum);
            result.Add(maxSum);

            return result;
        }
    }
}
