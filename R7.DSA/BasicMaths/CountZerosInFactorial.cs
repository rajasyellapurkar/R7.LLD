namespace R7.DSA.BasicMaths
{
    internal class CountZerosInFactorial
    {
        public static int FindCount(int n)
        {
            int count = 0;
            int powerOf5 = 5;
            int temp = n;
            while (temp != 0)
            {
                count += n / powerOf5;
                temp = temp / 5;
                powerOf5 *= 5;
            }
            return count;
        }
    }
}
