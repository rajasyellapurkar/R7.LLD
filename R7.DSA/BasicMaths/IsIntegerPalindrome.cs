namespace R7.DSA.BasicMaths
{
    internal class IsIntegerPalindrome
    {
        public static bool IsPalindrome(int n)
        {
            int temp = n;
            int reverse = 0;
            int powerOf10 = 1;
            while(n > 0)
            {
                int mod = n % 10;
                reverse += mod * powerOf10;
                n = n / 10;
                powerOf10 *= 10;
            }
            return temp == reverse;
        }
    }
}
