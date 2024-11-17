namespace R7.DSA.Sorting
{
    public class NobleInteger
    {
        /// <summary>
        /// Given an integer array A, find if an integer p exists in the array such that 
        /// the number of integers greater than p in the array equals p.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindNobleInteger(int[] arr)
        {
            int N = arr.Length;
            Array.Sort(arr);
            for(int i=0; i< N-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    continue;
                }
                else
                {
                    int countOfGreaterThan = N - i - 1;
                    if(countOfGreaterThan == arr[i])
                    {
                        return arr[i];
                    }
                }
            }
            return -1;
        }
    }
}
