namespace R7.DSA.ProblemSolving
{
    /*
     * Given an array of integers A consisting of only 0 and 1.
       Find the maximum length of a contiguous subarray with equal number of 0 and 1.
     */
    internal static class ContiguousArray
    {
        public static int FindMaxLength(int[] arr)
        {
            int n = arr.Length;
            int[] modifiedArr = new int[n];

            // Replace 0 with -1
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    modifiedArr[i] = -1;
                }
                else
                {
                    modifiedArr[i] = 1;
                }
            }

            // Determine the prefix sum
            int[] prefixSum = new int[n + 1];
            prefixSum[0] = 0;
            for (int i = 0; i < n; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + modifiedArr[i];
            }

            // When sum of a sub-array is zero then valule at P|L-1 and P|R are equal
            // Find duplicates which are at max distance
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            int maxLength = 0;
            for(int i = 0; i < n; i++)
            {
                if (hashMap.ContainsKey(prefixSum[i + 1]))
                {
                    int diff = i + 1 - hashMap[prefixSum[i + 1]];
                    if(diff > maxLength)
                    {
                        maxLength = diff;
                    }
                }
                else
                {
                    hashMap.Add(prefixSum[i + 1], i + 1);
                }
            }
            return maxLength;
        }
    }
}
