namespace R7.DSA.Hashing
{
    public class ArrayWithSumOfTwoEqualSomeOfOtherTwoElements
    {
        public static List<int[]> Find(int[] arr)
        {
            int N = arr.Length;
            Dictionary<int, int[]> hashMap = new Dictionary<int, int[]>();
            List<int[]> result = new List<int[]>();
            for(int i=0; i<N; i++)
            {
                for(int j=i+1; j<N; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (hashMap.ContainsKey(sum))
                    {
                        int[] values = hashMap[sum];
                        int p = values[0];
                        int q = values[1];

                        if(i != p && j !=p && i != q && j != q)
                        {
                            result.Add([i, j, p, q]);
                        }
                    }
                    else
                    {
                        hashMap.Add(sum, [i, j]);
                    }
                }
            }
            return result;
        }
    }
}
