

namespace HackerRank.Plus_Minus
{
    public class PrintPlusMinus
    {
        public static void Print() 
        {
            List<int> ints = new List<int>() { 9, 1 ,0 , -1 , -4, 3 , 0, 0};
            
            IList<string> ratios =  PlusMinus.plusMinus(ints);    

            foreach (string str in ratios) 
                Console.WriteLine(str);
        }
    }
}
