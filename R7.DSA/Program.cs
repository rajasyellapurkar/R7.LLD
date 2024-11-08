using R7.DSA.Arrays;
using R7.DSA.BitManipulation;
using R7.DSA.Hashing;

namespace R7.DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in FizzBuzzProblem.FizzBuzzArrayOfStrings(15))
            {
                Console.WriteLine(s);
            }
        }

        private static void OldProgramExecutions()
        {

            int[][] a = ArrayForGivenIntegerN.Form2DArray(5);
            Common.Print2DArray(a);
            int result = SmallestSubArrayWithMinAndMax.SmallestSubArrayLength([9, 5, 5, 7, 5, 9, 1]);
            result = SmallestSubArrayWithMinAndMax.SmallestSubArrayLengthSimplified([9, 5, 5, 7, 5, 9, 1]);

            //Two Sum Problem
            int[] twoSumArr = [2, 7, 11, 15];
            Console.WriteLine($"Two Sum Array result: {TwoSumProblem.TwoSumProblemApproach_1(twoSumArr, 9)}");
            Console.WriteLine($"Two Sum Array result: {TwoSumProblem.TwoSumProblemApproach_2(twoSumArr, 9)}");
            Console.WriteLine($"Two Sum Array result: {TwoSumProblem.TwoSumProblemReturnsIndexes(twoSumArr, 9)}");

            int[] hashingProblem2 = [1, 8, 2, 4, 1, 2, 3, 6, 4, 8, 2];
            int[] hashingProblem2Result = HashingProblem2.HashingProblem2UsingHashMap(hashingProblem2);
            Console.WriteLine($"{hashingProblem2Result[0]} {hashingProblem2Result[1]}");

            //Doesn't handle more than one occurence
            int[][] anagramResult = AnagramsProblem.Anagrams(["cat", "dog", "god", "odg"]);

            Console.WriteLine(CountTotalSetBits.CountSetBitsSumApproach_1(5));
            Console.WriteLine(CountTotalSetBits.CountSetBitsSumApproach_2(5));
        }
    }
}
