namespace R7.DSA.ProblemSolving
{
    internal static class SortTheUnsortedArray
    {
        /*
         You are given an integer array A having N integers.
         You have to find the minimum length subarray A[l..r] such that sorting this subarray makes the whole array sorted.
         */
        public static int FindMinLength(int[] arr)
        {
            int n = arr.Length;
            int[] sortedArray = new int[n];
            for(int i = 0; i<n; i++)
            {
                sortedArray[i] = arr[i];
            }
            Array.Sort(sortedArray);
            int l = -1;
            int r = -1;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] != sortedArray[i])
                {
                    l = i;
                    break;
                }
            }
            for (int i = n-1; i >= 0; i--)
            {
                if (arr[i] != sortedArray[i])
                {
                    r = i;
                    break;
                }
            }
            return r - l + 1;
        }
    }
}
