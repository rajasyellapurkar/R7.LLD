namespace R7.DSA.Sorting
{
    public class SortInAlternateAscDesc
    {
        /// <summary>
        ///   .   .   .
        /// .   .   .   .
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] SortPattern(int[] arr)
        {
            int N = arr.Length;
            Array.Sort(arr);
            bool flag = false;
            for(int i=0; i < N-1; i++)
            {
                if (flag)
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
                flag = !flag;
            }
            return arr;
        }
    }
}
