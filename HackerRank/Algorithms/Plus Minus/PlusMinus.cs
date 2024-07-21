

namespace HackerRank.Plus_Minus
{
    public class PlusMinus
    {
        public static IList<string> plusMinus(List<int> arr)
        {
            float countInts = arr.Count;
            float ratioPositive = arr.Where(x => x > 0).Count() / countInts;
            float ratiosNegative = arr.Where(x => x < 0).Count() / countInts;
            float ratiosZero = arr.Where(x => x is 0).Count() / countInts;

            return new List<string>() { ratioPositive.ToString("N6"), ratiosNegative.ToString("N6"), ratiosZero.ToString("N6") };
        }
    }
}
