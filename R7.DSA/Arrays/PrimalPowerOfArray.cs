namespace R7.DSA.Arrays
{
    public class PrimalPowerOfArray
    {
        public static int PrimalPower(int[] arr)
        {
            int N = arr.Length;
            int primalPower = 0;
            for (int i=0;i<N; i++)
            {
                if (arr[i] > 0 && IsPrime(arr[i]))
                {
                    primalPower++;
                }
            }
            return primalPower;
        }

        private static bool IsPrime(int a)
        {
            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
