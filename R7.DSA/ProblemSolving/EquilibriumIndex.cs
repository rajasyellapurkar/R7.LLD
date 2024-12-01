namespace R7.DSA.ProblemSolving
{
    internal class EquilibriumIndex
    {
        public static int FindIndex(int[] arr)
        {
            int n = arr.Length;
            int sum = 0;
            for(int i = 0; i< n; i++)
            {
                sum += arr[i];
            }
            int leftSum = arr[0];
            sum = sum - arr[0];
            for(int i = 1; i < n; i++)
            {
                sum -= arr[i];
                if(leftSum == sum)
                {
                    return i;
                }
                leftSum += arr[i];
            }
            return -1;
        }
    }
}
