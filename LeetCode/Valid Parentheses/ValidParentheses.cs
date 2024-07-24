

namespace LeetCode.Valid_Parentheses
{
    public class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            // ()[]{}
            List<char> opening = [ '{', '[', '(' ];
            List<char> closing = ['}', ']', ')'];
            Stack<char> stackOfOpening = new Stack<char>();

            if(s.Length % 2 != 0)
                return false;

            for(int i = 0; i < s.Length; i++)
            {
                if (opening.Contains(s[i]))
                {
                    stackOfOpening.Push(s[i]);
                }
                else
                {
                    if (!stackOfOpening.TryPop(out char tmpParentheses)) 
                        return false;
                    char closingParentheses = s[i];
                    int indexOfTmp = opening.IndexOf(tmpParentheses);
                    int indexOfClosing = closing.IndexOf(closingParentheses);

                    if (indexOfTmp != indexOfClosing)
                        return false;   
                }
            }
            return stackOfOpening.Count == 0;
        }
    }
}
