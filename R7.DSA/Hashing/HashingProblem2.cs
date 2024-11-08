namespace R7.DSA.Hashing
{
    public static class HashingProblem2
    {
        /// <summary>
        /// Given an array find the pair of indices (i,j) such that A[i] = A[j] and (i-j) is max
        /// [1, 8, 2, 4, 1, 2, 3, 6, 4, 8, 2]
        /// Output: [1,9]
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int[] HashingProblem2UsingHashMap(int[] a)
        {
            int N = a.Length;
            Dictionary<int, int> map = new Dictionary<int, int>();
            int max = int.MinValue;
            int x = 0, y = 0;
            for (int i = 0; i < N; i++)
            {
                if (map.ContainsKey(a[i]))
                {
                    int diff = Math.Abs(map[a[i]] - i);
                    if (diff > max)
                    {
                        max = diff;
                        y = i;
                        x = map[a[i]];
                    }
                }
                else
                {
                    map[a[i]] = i;
                }
            }
            int[] result = [x, y];
            return result;
        }
    }
}
