

namespace LeetCode.Sort_of_Increasing_Frecuency
{
    public class SortOfIncreasingFrecuency
    {
        public static int[] FrequencySort(int[] nums)
        {

            return nums.GroupBy(x => x)
                       .ToDictionary(g => g.Key, g => g.Count())
                       .OrderBy(kvp => kvp.Value)
                       .ThenByDescending(kvp => kvp.Key)
                       .ToDictionary()
                       .SelectMany(kvp => Enumerable.Repeat(kvp.Key, kvp.Value))
                       .ToArray();                        
        }
    }
}
