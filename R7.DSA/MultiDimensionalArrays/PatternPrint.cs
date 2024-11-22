namespace R7.DSA.MultiDimensionalArrays
{
    public class PatternPrint
    {
        /// <summary>
        /// PatternPrint.Print(3);
        /// </summary>
        /// <param name="A">Integer value. For e.g. 3</param>
        /// <returns>2D array</returns>
        public static int[][] Print(int A)
        {
            int[][] arr = new int[A][];
            for (int i = 0; i < A; i++)
            {
                arr[i] = new int[A];
                int printVal = 1;
                for (int j = 0; j <= i; j++)
                {
                    arr[i][j] = printVal;
                    printVal++;
                }
            }
            return arr;
        }
    }
}
