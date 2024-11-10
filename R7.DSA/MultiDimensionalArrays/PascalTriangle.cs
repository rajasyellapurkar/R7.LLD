namespace R7.DSA.MultiDimensionalArrays
{
    public class PascalTriangle
    {
        public static int[][] PascalTriangleGenerator(int N)
        {
            int[][] result = new int[N][];
            
            for(int i = 0; i < N; i++)
            {
                result[i] = new int[N];
                for(int j = 0; j < N; j++)
                {
                    if(j == 0)
                    {
                        result[i][j] = 1; 
                    }
                    else if(i-1 >= 0 && j-1 >= 0)
                    {
                        result[i][j] = result[i - 1][j - 1] + result[i - 1][j]; 
                    }
                    else
                    {
                        result[i][j] = 0;
                    }
                }
            }
            return result;
        }
    }
}
