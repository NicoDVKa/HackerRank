

namespace LeetCode.Sort_of_Increasing_Frecuency
{
    public class PrintSortOfIncreasingFrecuency
    {
        public static void Print()
        {
            int[] nums = [1, 1, 2, 2, 2, 3, 3];
            int[] result;
            
            result = SortOfIncreasingFrecuency.FrequencySort(nums);


            result.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}
