

namespace LeetCode.Sort_An_Array
{
    public class PrintSortAnArray
    {
     

        //SortAnArray.Execute(array).ForEach(x => Console.Write(x + " "));

        public static void Print()
        {

            List<int> array = [-1, 5, 1, int.MaxValue, 1, 2, 0, 0];

            SortAnArray.Execute(array).ForEach(x => Console.Write(x + " "));
        }
    }
}
