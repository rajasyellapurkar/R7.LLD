namespace R7.DSA.ProblemSolving
{
    internal static class ConstructArray
    {
        public static void Construct(int a, int b, int d)
        {
            int diff = b - a;
            int sqrt = (int)Math.Sqrt(diff);
            List<int> divisors = new List<int>();
            for (int i = 1; i < sqrt; i++)
            {
                if (diff % i == 0)
                {
                    divisors.Add(i);
                    divisors.Add(diff / i);
                }
            }

            int minSum = int.MaxValue;
            int resultDivisor;
            foreach (int divisor in divisors)
            {
                int i = 0;
                int sum = 0;
                bool subtractFlag = true;
                int y = b;
                int subtractCount = 0;
                int addCount = 1;
                while (i <= d)
                {
                    sum += y;
                    if (subtractFlag)
                    {
                        y = y - (subtractCount * divisor);
                        subtractCount++;
                    }
                    else
                    {
                        y = y + (addCount * divisor);
                        addCount++;
                    }
                    if (y < 0)
                    {
                        subtractFlag = false;
                        y = b;
                    }
                    i++;
                }
                if(((y < b && y <= a) || (y > b)) && sum < minSum)
                {
                    minSum = sum;
                    resultDivisor = divisor;
                }
            }
        }
    }
}
