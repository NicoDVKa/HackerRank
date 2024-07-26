

using System.Net.Http.Headers;

namespace HackerRank.Algorithms.Birthday_Cake_Candles
{
    public class BirthdayCakeCandles
    {
        public static int Execute(List<int> candles)
        {
            candles.Sort();
            var tallestCandle = candles.Where(candle => candle == candles.Last());
            return tallestCandle.Count();
        }
    }
}
