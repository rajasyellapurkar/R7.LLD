namespace R7.DSA.Sorting
{
    public class IsAirthmeticProgression
    {
        /// <summary>
        /// Given an integer array A of size N. 
        /// Return 1 if the array can be arranged to form an arithmetic progression, otherwise return 0.
        /// </summary>
        /// <param name="arr">Integer array</param>
        /// <returns>Return 1 if the array can be arranged to form an arithmetic progression, otherwise return 0.</returns>
        public static bool Check(int[] arr)
        {
            int N = arr.Length;
            Array.Sort(arr);
            int diff = arr[1] - arr[0];
            for(int i = 1; i < N-1; i++)
            {
                if (arr[i+1] - arr[i] != diff)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
