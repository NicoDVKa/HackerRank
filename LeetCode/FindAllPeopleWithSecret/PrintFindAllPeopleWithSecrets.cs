
using System.Security.Cryptography.X509Certificates;

namespace LeetCode.FindAllPeopleWithSecret
{
    public class PrintFindAllPeopleWithSecrets
    {
        public static void Print()
        {
            Console.WriteLine();
            IList<int> result;

            result = FindAllPeopleWithSecret.Execute(4, [[3, 1, 3], [1, 2, 2], [0, 3, 3]], 3);
            result.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            result = FindAllPeopleWithSecret.Execute(5, [[1, 2, 1], [2, 3, 1], [3, 4, 2]], 1);
            result.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            result = FindAllPeopleWithSecret.Execute(6, [[1, 2, 5], [2, 3, 8], [1, 5, 10]], 1);
            result.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            result = FindAllPeopleWithSecret.Execute(11, [[5, 1, 4], [0, 4, 18]], 1);
            result.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            result = FindAllPeopleWithSecret.Execute(5, [[1, 4, 3], [0, 4, 3]], 3);
            result.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            result = FindAllPeopleWithSecret.Execute(6, [[0, 2, 1], [1, 3, 1], [4, 5, 1]], 1);
            result.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();


        }
    }
}
