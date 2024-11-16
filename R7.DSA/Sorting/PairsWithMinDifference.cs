namespace R7.DSA.Sorting
{
    public class PairsWithMinDifference
    {
         public static List<int[]> FindPairs(int[] arr)
        {
            List<int[]> results = new List<int[]>();
            int N = arr.Length;
            int minDiff = int.MaxValue;

            Array.Sort(arr);
            for(int i = 0; i < N-1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                if(diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            for (int i = 0; i < N - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                if (diff == minDiff)
                {
                    results.Add([arr[i], arr[i + 1]]);
                }
            }
            return results;
        }
    }
}
