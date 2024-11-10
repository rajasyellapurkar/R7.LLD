namespace R7.DSA.Arrays
{
    public class PatternPrinting2
    {
        /// <summary>
        /// Given an integer N, return a 2D array with below pattern
        /// I/P N = 5
        /// O/P:
        ///     0  0  0  0  1
        ///     0  0  0  2  1
        ///     0  0  3  2  1
        ///     0  4  3  2  1
        ///     5  4  3  2  1
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int[][] Form2DArray(int N)
        {
            int[][] a = new int[N][];
            int k = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                a[i] = new int[N];
                for (int j = 0; j < k; j++)
                {
                    a[i][j] = 0;
                }
                for (int j = k; j < N; j++)
                {
                    a[i][j] = N - j;
                }
                k++;
            }
            return a;
        }
    }
}
