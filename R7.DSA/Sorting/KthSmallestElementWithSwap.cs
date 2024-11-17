namespace R7.DSA.Sorting
{
    public class KthSmallestElementWithSwap
    {
        /// <summary>
        /// Find the Bth smallest element in given array A. 
        /// NOTE: Users should try to solve it in less than equal to B swaps.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Find(int[] arr, int k)
        {
            int N = arr.Length;
            int i = 0;
            while(i <= k)
            {
                int minIndex = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

                i++;
            }
            return arr[k-1];
        }
    }
}
