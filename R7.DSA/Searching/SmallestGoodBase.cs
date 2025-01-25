namespace R7.DSA.Searching
{
    // https://leetcode.com/problems/smallest-good-base/description/
    internal class SmallestGoodBaseProblem
    {
        public static void Execute()
        {
            string a = "1000000000000000000";
            SmallestGoodBaseProblem obj = new();
            string result = obj.SmallestGoodBaseBruteForce(a);
        }
        public string SmallestGoodBase(string n)
        {
            return string.Empty;
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
