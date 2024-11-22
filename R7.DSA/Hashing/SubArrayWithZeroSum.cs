namespace R7.DSA.Hashing
{
    public class SubArrayWithZeroSum
    {
        public static List<int[]> BruteForce(int[] arr)
        {
            int N = arr.Length;
            List<int[]> result = new();
            for (int i = 0; i < N; i++)
            {
                int subArraySum = 0;
                for (int j = i; j < N; j++)
                {
                    subArraySum += arr[j];
                    if (subArraySum == 0)
                    {
                        result.Add([i, j]);
                    }
                }
            }
            return result;
        }
        public static bool Exists(int[] arr)
        {
            int N = arr.Length;
            int[] prefixSum = new int[N];
            prefixSum[0] = arr[0];
            HashSet<int> prefixSumHashSet = new HashSet<int>();
            for(int i=1; i<N; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + arr[i];
                if (prefixSumHashSet.Contains(prefixSum[i]))
                {
                    return true;
                }
                else
                {
                    prefixSumHashSet.Add(prefixSum[i]);
                }
            }
            return false;
        }
    }
}
