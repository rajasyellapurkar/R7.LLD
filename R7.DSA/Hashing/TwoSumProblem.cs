namespace R7.DSA.Hashing
{
    public static class TwoSumProblem
    {
        /// <summary>
        /// Time Complexity : O(nlogn)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static bool TwoSumProblemApproach_1(int[] arr, int sum)
        {
            Array.Sort(arr);
            int N = arr.Length;
            int r = N-1;
            int l = 0;
            while(l <= r)
            {
                int arrSum = arr[l] + arr[r];
                if (arrSum == sum)
                {
                    return true;
                }
                else if (arrSum < sum)
                {
                    l++;
                } 
                else
                {
                    r--;
                }
            }
            return false;
        }

        /// <summary>
        /// TimeComplexity: O(n)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static bool TwoSumProblemApproach_2(int[] arr, int sum)
        {
            HashSet<int> set = new HashSet<int>();
            int N = arr.Length;
            for (int i=0; i<N; i++)
            {
                if(set.Contains(sum - arr[i]))
                {
                    return true;
                } 
                else
                {
                    set.Add(arr[i]);
                }
            }
            return false;
        }

        public static int[] TwoSumProblemReturnsIndexes(int[] arr, int sum)
        {
            Dictionary<int, int> dict = new();
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                if (dict.ContainsKey(sum - arr[i]))
                {
                    return [dict[sum - arr[i]], i + 1];
                }
                else
                {
                    dict[arr[i]] = i + 1;
                }
            }
            return [];
        }
    }
}
