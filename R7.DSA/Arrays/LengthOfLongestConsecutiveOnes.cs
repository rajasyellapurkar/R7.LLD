namespace R7.DSA.Arrays
{
    public class LengthOfLongestConsecutiveOnes
    {
        public static int Count(string arr)
        {
            int N = arr.Length;
            int[] leftSumArr = new int[N + 1];
            int[] rightSumArr = new int[N + 1];

            for(int i=0; i < N; i++)
            {
                if (arr[i] == '1')
                {
                    leftSumArr[i + 1] = leftSumArr[i] + 1;
                }
                else if (arr[i] == '0')
                {
                    leftSumArr[i + 1] = 0;
                }
            }

            for (int i = N-1; i >= 0; i--)
            {
                if (arr[i] == '1')
                {
                    rightSumArr[i] = rightSumArr[i+1] + 1;
                }
                else if (arr[i] == '0')
                {
                    rightSumArr[i] = 0;
                }
            }

            int totalOnes = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == '1')
                {
                    totalOnes++;
                }
            }

            int sumAtZero = 0;
            int maxSum = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] == '0')
                {
                    sumAtZero = leftSumArr[i] + rightSumArr[i + 1] + 1;
                    if(sumAtZero > maxSum)
                    {
                        maxSum = sumAtZero;
                    }
                }
            }
            
            if(maxSum > totalOnes)
            {
                return totalOnes;
            }
            else
            {
                return maxSum;
            }
        }
    }
}
