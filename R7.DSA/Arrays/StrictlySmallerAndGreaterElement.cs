namespace R7.DSA.Arrays
{
    public class StrictlySmallerAndGreaterElement
    {
        public static int Find(int[] arr)
        {
            int N = arr.Length;
            int max = arr[0];
            int min = arr[0];
            int result = 0;
            for (int i = 1; i < N; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"[{min} - {max}]");

            for (int i = 0; i < N; i++)
            {
                if (arr[i] > min && arr[i] < max)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
