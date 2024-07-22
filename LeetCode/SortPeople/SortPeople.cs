
namespace LeetCode.SortPeople
{
    public class SortPeople
    {

        public static string[] Execute(string[] names, int[] heights)
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();

            for (int i = 0; i < names.Length; i++)
                pairs.Add(heights[i], names[i]);

            return pairs.OrderByDescending(pair => pair.Key)
                        .Select(x => x.Value)
                        .ToArray();
        }
    }
}
