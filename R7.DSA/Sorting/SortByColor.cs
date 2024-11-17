namespace R7.DSA.Sorting
{
    public class SortByColor
    {
        /// <summary>
        /// Given an array with N objects colored red, white, or blue, sort them so that objects of 
        /// the same color are adjacent, with the colors in the order red, white, and blue.
        /// We will use the integers 0, 1, and 2 to represent red, white, and blue, respectively.
        /// Note: Using the library sort function is not allowed.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Sort(int[] arr)
        {
            int N = arr.Length;

            int countOfZero = 0;
            int countOfOne = 0;
            int countOfTwo = 0;

            for(int i=0; i<N; i++)
            {
                if (arr[i] == 0)
                {
                    countOfZero++;
                }
                if (arr[i] == 1)
                {
                    countOfOne++;
                }
                if (arr[i] == 2)
                {
                    countOfTwo++;
                }
            }

            int j = 0;
            while(countOfZero > 0)
            {
                arr[j] = 0;
                j++;
                countOfZero--;
            }
            while (countOfOne > 0)
            {
                arr[j] = 1;
                j++;
                countOfOne--;
            }
            while (countOfTwo > 0)
            {
                arr[j] = 2;
                j++;
                countOfTwo--;
            }
            return arr;
        }
    }
}
