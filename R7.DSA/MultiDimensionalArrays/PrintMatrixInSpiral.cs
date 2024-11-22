namespace R7.DSA.MultiDimensionalArrays
{
    public class PrintMatrixInSpiral
    {
        public static void Print(int[][] matrix)
        {
            int M = matrix.Length;
            int N = matrix[0].Length;

            int T = 0;
            int B = M - 1;

            int L = 0;
            int R = N - 1;

            while(T <= B && L <= R)
            {
                for(int j = L; j <= R; j++)
                {
                    Console.Write($"{matrix[T][j]} ");
                }
                for(int i = T + 1; i <= B; i++)
                {
                    Console.Write($"{matrix[i][R]} ");
                }
                for(int j = R - 1; j >= L; j--)
                {
                    Console.Write($"{matrix[B][j]} ");
                }
                for (int i = B - 1; i > T; i--)
                {
                    Console.Write($"{matrix[i][L]} ");
                }

                T++;
                B--;

                L++;
                R--;
            }
        }
    }
}
