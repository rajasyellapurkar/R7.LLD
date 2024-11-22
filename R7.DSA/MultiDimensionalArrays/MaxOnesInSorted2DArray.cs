namespace R7.DSA.MultiDimensionalArrays
{
    public class MaxOnesInSorted2DArray
    {
        /// <summary>
        /// int rowIndex = MaxOnesInSorted2DArray([[0, 1, 1, 1, 1], [0, 0, 0, 0, 0], [0, 0, 1, 1, 1], [0, 0, 0, 0, 0, 0],[1, 1, 1, 1, 1]]);
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Find(int[][] arr)
        {
            int N = arr.Length;
            int j = N - 1;
            int maxOnes_row_index = 0;
            int maxOnes_count = 0;
            for (int i = 0; i < N; i++)
            {
                int currentRowCount = maxOnes_count;
                while (j >= 0)
                {
                    if (arr[i][j] == 1)
                    {
                        currentRowCount++;
                        j = j - 1;
                    }
                    if (currentRowCount > maxOnes_count)
                    {
                        maxOnes_count = currentRowCount;
                        maxOnes_row_index = i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return maxOnes_row_index;
        }
    }
}
