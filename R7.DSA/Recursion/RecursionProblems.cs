namespace R7.DSA.Recursion
{
    public class RecursionProblems
    {
        public static int Fibonacci(int N)
        {
            if (N < 0)
            {
                return -1;
            }
            if (N == 0 || N == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(N - 1) + Fibonacci(N - 2);
            }
        }

        public static int Sum(int N)
        {
            if(N <= 0)
            {
                return -1;
            }
            if(N == 1)
            {
                return 1;
            }
            else
            {
                return N + Sum(N - 1);
            }
        }

        public static int Factorial(int N)
        {
            if (N < 0)
            {
                return -1;
            }
            if (N == 1 || N == 0)
            {
                return 1;
            }
            else
            {
                return N * Factorial(N - 1);
            }
        }

        public static bool IsPalindrome(string str, int l, int r)
        {
            if (str[l] != str[r])
            {
                return false;
            }
            if(l == r || l > r)
            {
                return true;
            }
            return IsPalindrome(str, l + 1, r - 1);
        }
    }
}
