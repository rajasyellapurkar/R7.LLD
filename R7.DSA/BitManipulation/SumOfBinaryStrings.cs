namespace R7.DSA.BitManipulation
{
    public class SumOfBinaryStrings
    {
        /// <summary>
        /// Given two binary strings A and B. Return their sum (also a binary string).
        /// 
        /// Console.WriteLine($"{SumOfBinaryStrings.Sum("1111111111","11011111")}");
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static string Sum(string A, string B)
        {
            int sizeOfA = A.Length;
            int sizeOfB = B.Length;

            int sumArrSize = Math.Max(sizeOfA, sizeOfB);
            char[] sumArr = new char[sumArrSize + 1];

            char carry = '0';

            char[] a = A.Reverse().ToArray();
            char[] b = B.Reverse().ToArray();

            for (int i = 0; i < sumArrSize; i++)
            {
                int countOfOne = 0;
                if (i < sizeOfA && a[i] == '1')
                {
                    countOfOne++;
                }
                if (i < sizeOfB && b[i] == '1')
                {
                    countOfOne++;
                }
                if (carry == '1')
                {
                    countOfOne++;
                }

                if (countOfOne == 0)
                {
                    sumArr[i] = '0';
                    carry = '0';
                }

                if (countOfOne == 1)
                {
                    sumArr[i] = '1';
                    carry = '0';
                }

                if (countOfOne == 2)
                {
                    sumArr[i] = '0';
                    carry = '1';
                }

                if (countOfOne == 3)
                {
                    sumArr[i] = '1';
                    carry = '1';
                }
            }
            if (carry == '1')
            {
                sumArr[sumArrSize] = carry;
            }
            string result = new string(sumArr.Reverse().ToArray());
            return result;
        }
    }
}
