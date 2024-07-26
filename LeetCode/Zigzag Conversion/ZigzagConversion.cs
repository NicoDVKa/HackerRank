

namespace LeetCode.Zigzag_Conversion
{
    public class ZigzagConversion
    {
        public static string Execute(string s, int numRows)
        {

            List<List<char?>> zigzag = StringToZigzagArray(s, numRows);
            zigzag.ForEach(innerArray => innerArray = innerArray.Where(c => c != null).ToList());
            string result = String.Concat(zigzag.SelectMany(innerArray => innerArray));
            return result;
        }

        static List<List<char?>> StringToZigzagArray(string s, int numRows)
        {
            List<List<char?>> zigzag = new List<List<char?>>();

            for (int i = 0; i < numRows; i++)
            {
                zigzag.Add(new List<char?>());
            }

            int column = 0;
            int row = 0, auxiliarRow = numRows - 1;
            Boolean direcctionToDown = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (direcctionToDown)
                {
                    zigzag[row].Add(s[i]);
                    row++;
                }
                else
                {
                    while (auxiliarRow >= 0)
                    {
                        if (auxiliarRow == row)
                        {
                            zigzag[auxiliarRow].Add(s[i]);
                        }
                        else
                        {
                            zigzag[auxiliarRow].Add(null);
                        }
                        auxiliarRow--;
                    }

                    auxiliarRow = numRows - 1;
                    row--;
                    column++;
                }

                if (row == numRows || row == 0 )
                {
                    if (numRows >= 3)
                    {
                        if(row == numRows) row = row - 2;
                        direcctionToDown = !direcctionToDown;
                    }
                    else
                    {
                        if (row == numRows) row = 0;
                    }
                    column++;      
                }

            }

            return zigzag;
        }
    }
}
