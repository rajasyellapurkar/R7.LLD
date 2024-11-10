namespace R7.DSA.MultiDimensionalArrays
{
    public class RotateMatrixByNinetyDegree
    {
        public static int[][] RotateMatrixBy90(int[][] arr)
        {
            int N = arr.Length;

            // A transpose
            for(int i = 0; i < N; i++)
            {
                for(int j = i; j < N; j++)
                {
                    int temp = arr[i][j];
                    arr[i][j] = arr[j][i];
                    arr[j][i] = temp;
                }
            }

            for(int i =0; i < N; i++)
            {
                for(int j=0; j< N/2; j++)
                {
                    int temp = arr[i][j];
                    arr[i][j] = arr[i][N - 1 - j];
                    arr[i][N - 1 - j] = temp;
                }
            }

            return arr;
        }
    }
}
