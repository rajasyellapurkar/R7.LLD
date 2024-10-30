namespace R7.DSA.Arrays
{
    public class Common
    {
        public static void Print2DArray(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
