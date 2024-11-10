namespace R7.DSA.MultiDimensionalArrays
{
    public class AntiDiagonalElements
    {
        public static int[][] AnitDiagonalOfAnArray(int[][] arr)
        {
            int N = arr[0].Length;
            int[][] result = new int[(2*N)-1][];
            int resultRow = 0;

            int i = 0;
            int j;
            for (j = 0; j < N; j++)
            {
                result[resultRow] = new int[N];
                for (int k = 0; k < N; k++)
                {
                    if ((i + k) < N && (j - k) >= 0)
                    {
                        result[resultRow][k] = arr[i + k][j - k];
                    }
                    else
                    {
                        result[resultRow][k] = 0;
                    }
                }
                resultRow++;
            }

            j = N-1;
            for (i = 1; i < N; i++)
            {
                result[resultRow] = new int[N];
                for (int k = 0; k < N; k++)
                {
                    if ((i + k) < N && (j - k) >= 0)
                    {
                        result[resultRow][k] = arr[i + k][j - k];
                    }
                    else
                    {
                        result[resultRow][k] = 0;
                    }
                }
                resultRow++;
            }
            return result;
        }

    }
}
