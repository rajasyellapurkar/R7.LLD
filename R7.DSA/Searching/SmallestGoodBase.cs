namespace R7.DSA.Searching
{
    // https://leetcode.com/problems/smallest-good-base/description/
    internal class SmallestGoodBaseProblem
    {
        public static void Execute()
        {
            string a = "1000000000000000000";
            SmallestGoodBaseProblem obj = new();
            string result = obj.SmallestGoodBase(a);
        }
        public string SmallestGoodBase(string n)
        {

            long num = long.Parse(n);
            long answer = -1;

            for (int i = 63; i > 0; i--)
            {
                long l = 2;
                long h = num - 1;
                while (l <= h)
                {
                    long m = l + (h - l) / 2;
                    long pOfM = 1;
                    long sum = 0;
                    bool ovrflwFlag = false;
                    for (int j = 0; j <= i; j++)
                    {
                        sum += pOfM;
                        if (sum > num)
                        {
                            break;
                        }
                        if (j < i && ((num - sum) / m) < pOfM)
                        {
                            ovrflwFlag = true;
                            break;
                        }
                        else if (j < i)
                        {
                            pOfM *= m;
                        }
                    }
                    if (sum > num || ovrflwFlag)
                    {
                        h = m - 1;
                    }
                    else if (sum < num)
                    {
                        l = m + 1;
                    }
                    else
                    {
                        return m.ToString();
                    }
                }
            }
            return answer.ToString();
        }

        public string SmallestGoodBaseBruteForce(string n)
        {
            long num = long.Parse(n);
            long answer = -1;

            for (long i = 2; i < num; i++)
            {
                long temp = num;
                while (temp > 1)
                {
                    long remainder = temp % i;
                    temp = temp / i;
                    if (remainder != 1)
                    {
                        break;
                    }
                }
                if (temp == 1)
                {
                    answer = i;
                    break;
                }
            }
            return answer.ToString();
        }
    }
}
