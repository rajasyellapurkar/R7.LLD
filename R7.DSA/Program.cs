using R7.DSA.Arrays;

namespace R7.DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] a = ArrayForGivenIntegerN.Form2DArray(5);
            Common.Print2DArray(a);
            int result = SmallestSubArrayWithMinAndMax.SmallestSubArrayLength([9, 5, 5, 7, 5, 9, 1]);
            result = SmallestSubArrayWithMinAndMax.SmallestSubArrayLengthSimplified([9, 5, 5, 7, 5, 9, 1]);
        }

    }
}
