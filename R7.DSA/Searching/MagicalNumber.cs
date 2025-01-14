namespace R7.DSA.Searching
{
    // https://leetcode.com/problems/nth-magical-number/
    internal class MagicalNumber
    {
        public static void Execute()
        {
           int result =  NthMagicalNumber(1000000000, 40000, 40000);
        }
        public static int NthMagicalNumber(int n, int a, int b)
        {
            int M = 1000000007;
            long low = Min(a, b, a * b);
            long high = low * n % M;
            while(low <= high)
            {
                long mid = low + (high - low) / 2;
                long numberOfDivisors = NumberOfDivisors(mid, a, b);
                if (numberOfDivisors == n)
                {
                    return (int) mid;
                }
                else if (numberOfDivisors > n)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        private static long NumberOfDivisors(long x, int a, int b)
        {
            int lcm = a > b ? a : b;
            while (true)
            {
                if (lcm % a == 0 && lcm % b == 0)
                {
                    break;
                }
                lcm++;
            }
            return (x / a) + (x / b) - (x / lcm);
        }

        public static int NthMagicalNumber1(int n, int a, int b)
        {
            int M = 1000000007;
            int x = 1;
            int y = 1;
            int z = 1;

            int p1;
            int p2;
            int p3;

            int currAns = 1;

            for (int i = 1; i <= n; i++)
            {
                p1 = (a * x) % M;
                p2 = (b * y) % M;
                p3 = (a * b * z) % M;

                currAns = Min(p1, p2, p3);
                if (p1 == currAns)
                {
                    x++;
                }
                if (p2 == currAns)
                {
                    y++;
                }
                if (p3 == currAns)
                {
                    z++;
                }
            }
            return currAns;
        }

        private static int Min(int a, int b, int c)
        {
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            return min;
        }
    }
}
