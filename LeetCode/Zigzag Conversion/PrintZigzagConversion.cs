

namespace LeetCode.Zigzag_Conversion
{
    public class PrintZigzagConversion
    {
        public static void Print()
        {
            string s = "ABC";
            string result = ZigzagConversion.Execute(s, 2);
            Console.WriteLine(result);
        }
    }
}
