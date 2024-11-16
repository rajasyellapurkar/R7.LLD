namespace R7.DSA.Hashing
{
    public class MinDistanceBetweenTwoEquals
    {
        public static int[] FindIndices(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int N = arr.Length;
            int minDiff = int.MaxValue;
            int leftIndex = -1, rightIndex = -1;
            for(int i=0; i<N; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    int currDiff = i - dict[arr[i]];
                    if(currDiff < minDiff)
                    {
                        minDiff = currDiff;
                        leftIndex = dict[arr[i]];
                        rightIndex = i;
                    }
                }
                dict[arr[i]] = i;
            }
            return [leftIndex, rightIndex];
        }
    }
}
