namespace R7.DSA.Arrays
{
    public class TimeToMakeAllElementsOfArrayEqual
    {
        /// <summary>
        /// Console.WriteLine($"{TimeToMakeAllElementsOfArrayEqual.Find([2, 4, 1, 3, 2])}");
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int Find(int[] arr)
        {
            int N = arr.Length;
            int max = arr[0];
            for (int i = 1; i < N; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int timeRequired = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] != max)
                {
                    timeRequired += (max - arr[i]);
                }
            }
            return timeRequired;
        }
    }
}
