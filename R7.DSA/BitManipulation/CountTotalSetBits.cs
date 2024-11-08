namespace R7.DSA.BitManipulation
{
    public static class CountTotalSetBits
    {
        public static int CountSetBitsSumApproach_1(int A)
        {
            int sum = 0;
            for(int i=1; i<=A; i++)
            {
                sum += CountOfSetBitInAInteger(i);
            }
            return sum;
        }

        public static int CountSetBitsSumApproach_2(int A)
        {
            int sum = 0;

            int i = 0;

            // 1 << i gives 2^i value
            // 1 << 3 gives 2^3 i.e. 8
            while((1 << i) <= A)
            {
                bool flagToCountOne = false;
                int countAfter = 1 << i;

                for(int j=0; j <= A; j++)
                {
                    if (flagToCountOne)
                    {
                        sum++;
                    }
                    if (countAfter == 1)
                    {
                        countAfter = 1 << i;
                        flagToCountOne = !flagToCountOne;
                    }
                    else
                    {
                        countAfter--;
                    }
                }

                i++;
            }
            return sum;
        }

        private static int CountOfSetBitInAInteger(int N)
        {
            int count = 0;
            while(N > 0)
            {
                int leftMostBit = N & 1;
                if(leftMostBit == 1)
                {
                    count++;
                }
                N = N >> 1;
            }
            return count;
        }

    }
}
