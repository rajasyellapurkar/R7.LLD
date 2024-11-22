namespace R7.DSA.Arrays
{
    public class AddOneToArrayOfDigits
    {
        public static int[] Add(int[] arr)
        {
            int N = arr.Length;
            int sum = 0;
            int multiplier = 1;
            for (int i = N - 1; i >= 0; i--)
            {
                int weightedVal = arr[i] * multiplier;
                sum += weightedVal;
                multiplier *= 10;
            }
            sum = sum + 1;
            int[] result = new int[N + 1];
            int j = N;
            int resultSumCount = 0;
            while (sum > 0)
            {
                result[j] = sum % 10;
                sum = sum / 10;
                j--;
                resultSumCount++;
            }
            if (resultSumCount > N)
            {
                return result;
            }
            else
            {
                int[] trimmedResult = new int[N];
                for (int i = 0; i < N; i++)
                {
                    trimmedResult[i] = result[i + 1];
                }
                return trimmedResult;
            }
        }
    }
}
