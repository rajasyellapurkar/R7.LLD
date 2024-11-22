namespace R7.DSA.Arrays
{
    public class DiffBetwMaxAmongEvenAndMinAmongOdd
    {
        /// <summary>
        /// Method to find the difference between the maximum among all even numbers of A and the minimum among all odd numbers in A.
        /// Input: [0, 2, 9]
        /// Output: -7
        /// Input: [5, 17, 100, 1]
        /// Output: 99
        /// </summary>
        /// <param name="arr">Integer Array</param>
        /// <returns>Return the difference between the maximum among all even numbers of A and the minimum among all odd numbers in A.</returns>
        public static int Find(int[] arr)
        {
            int N = arr.Length;
            int max_even = int.MinValue;
            int min_odd = int.MaxValue;

            for (int i = 0; i < N; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] > max_even)
                {
                    max_even = arr[i];
                }
                else if (arr[i] % 2 != 0 && arr[i] < min_odd)
                {
                    min_odd = arr[i];
                }
            }
            return max_even - min_odd;
        }
    }
}
