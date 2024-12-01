namespace R7.DSA.ProblemSolving
{
    internal class SubArrayWithLeastAverage
    {
        public static int[] Find(int[] arr, int k)
        {
            int n = arr.Length;
            int[] prefixSum = new int[n+1];
            int l = -1;
            int r = -1;
            for (int i=0; i < n; i++)
            {
                prefixSum[i+1] = prefixSum[i] + arr[i];
            }
            int leastAverage = int.MaxValue;
            for(int i=0; i + k < n; i++)
            {
                int subArraySum = prefixSum[i + k] - prefixSum[i];
                int average = subArraySum / k;
                if(average < leastAverage)
                {
                    l = i;
                    r = i + k;
                    leastAverage = average;
                }
            }
            return [l, r];
        }
        public static int[] FindUsingSlidingWindow(int[] arr, int k)
        {
            int n = arr.Length;
            int minSum = int.MaxValue;
            int subArraySum = 0;
            int l = -1;
            int r = -1;
            for (int i=0; i<k; i++)
            {
                subArraySum += arr[i];
            }
            for (int i=k; i < n; i++)
            {
                if(subArraySum < minSum)
                {
                    l = i-k;
                    r = i;
                    minSum = subArraySum;
                }
                subArraySum = subArraySum - arr[i - k] + arr[i];
            }
            return [l, r];
        }
    }
}
