namespace HackerRank.Algorithms.StairCase
{
    public class StairCase
    {
        public static IList<String> Staircase(int n)
        {
            String line;
            List<String> strs = [];
            for (int i = 0; i < n; i++)
            {
                line = new String(' ', n-i-1) + new String('#', i+1);  
                strs.Add(line);
            }
            return strs;
        }
    }
}
