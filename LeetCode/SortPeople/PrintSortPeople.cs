

namespace LeetCode.SortPeople
{
    public class PrintSortPeople
    {
        public static void Print()
        {
            string[] names = ["Alice", "Bob", "Bob"];
            int[] heights = [155, 185, 171];
            var result = SortPeople.Execute(names, heights);
            result.ToList().ForEach(x => Console.Write(x + " "));

            Console.WriteLine();

            names = ["Lio", "Jaki", "Mute", "DVK"];
            heights = [168, 175, 178, 177];
            result = SortPeople.Execute(names, heights);
            result.ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
