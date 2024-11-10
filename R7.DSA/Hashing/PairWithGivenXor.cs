namespace R7.DSA.Hashing
{
    public class PairWithGivenXor
    {
        public static int Count(int[] arr, int b)
        {
            int N = arr.Length;
            HashSet<int> hashSet = new HashSet<int>();
            int result = 0;
            for (int i = 0;i < N; i++)
            {
                if (hashSet.Contains(arr[i]))
                {
                    result++;
                }
                else
                {
                    int xorValue = arr[i] ^ b;
                    hashSet.Add(xorValue);
                }
            }
            return result;
        }
    }
}
