



namespace LeetCode.Sort_An_Array
{
    public class SortAnArray
    {
        public static int[] Execute(int[] arrayToSort)
        {
            return MergeSort(arrayToSort.ToList()).ToArray();
        }

        static List<int> MergeSort(List<int> arr)
        {
            if (arr.Count == 1) return arr;

            int middle = arr.Count / 2;
            List<int> leftArray = arr.Take(middle).ToList();
            List<int> rightArray = arr.Skip(middle).ToList();

            List<int> sortedLeftArray = MergeSort(leftArray);
            List<int> sortedRightArray = MergeSort(rightArray);

            return Merge(sortedLeftArray, sortedRightArray);
        }

        static List<int> Merge(List<int> leftArray, List<int> rightArray)
        {
            List<int> resultArray = [];

            while (leftArray.Count > 0 && rightArray.Count > 0)
            {
                if (leftArray[0] < rightArray[0])
                {
                    resultArray.Add(leftArray[0]);
                    leftArray.RemoveAt(0);
                }
                else
                {
                    resultArray.Add(rightArray[0]);
                    rightArray.RemoveAt(0);
                }
            }
            if (leftArray.Count > 0)
                resultArray.AddRange(leftArray);

            if (rightArray.Count > 0)
                resultArray.AddRange(rightArray);

            return resultArray;
        }
    }
}
