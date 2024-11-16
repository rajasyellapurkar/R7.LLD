namespace R7.DSA.Hashing
{
    public class SubArrayWithZeroSum
    {
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
