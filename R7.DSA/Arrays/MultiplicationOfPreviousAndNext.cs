namespace R7.DSA.Arrays
{
    public class MultiplicationOfPreviousAndNext
    {
        public static int[] MultipliedArray(int[] arr)
        {
            int previousElementValue;
            int multipliedValue;
            int N = arr.Length;
            if(N == 1)
            {
                return arr;
            }
            if(N == 2)
            {
                arr[0] = arr[0] * arr[1];
                arr[1] = arr[0];
                return arr;
            }
            else
            {
                previousElementValue = arr[0];
                arr[0] = arr[0] * arr[1];
                int lastElementValue = arr[N - 1] * arr[N - 2];
                for (int i = 1; i < N-1; i++)
                {
                    multipliedValue = previousElementValue * arr[i + 1];
                    previousElementValue = arr[i];
                    arr[i] = multipliedValue;
                }
                arr[N - 1] = lastElementValue;
            }
            return arr;
        }
    }
}
