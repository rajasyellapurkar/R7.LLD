using R7.DSA.Arrays;
using R7.DSA.BitManipulation;
using R7.DSA.Hashing;
using R7.DSA.MultiDimensionalArrays;

namespace R7.DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void OldProgramExecutions()
        {

            int[][] a = PatternPrinting2.Form2DArray(5);
            Common.Print2DArray(a);
            int result = ClosestMinMax.SmallestSubArrayLength([9, 5, 5, 7, 5, 9, 1]);
            result = ClosestMinMax.SmallestSubArrayLengthSimplified([9, 5, 5, 7, 5, 9, 1]);

            //Two Sum Problem
            int[] twoSumArr = [2, 7, 11, 15];
            Console.WriteLine($"Two Sum Array result: {TwoSumProblem.TwoSumProblemApproach_1(twoSumArr, 9)}");
            Console.WriteLine($"Two Sum Array result: {TwoSumProblem.TwoSumProblemApproach_2(twoSumArr, 9)}");
            Console.WriteLine($"Two Sum Array result: {TwoSumProblem.TwoSumProblemReturnsIndexes(twoSumArr, 9)}");

            int[] hashingProblem2 = [1, 8, 2, 4, 1, 2, 3, 6, 4, 8, 2];
            int[] hashingProblem2Result = HashingProblem2.HashingProblem2UsingHashMap(hashingProblem2);
            Console.WriteLine($"{hashingProblem2Result[0]} {hashingProblem2Result[1]}");

            Console.WriteLine(CountTotalSetBits.CountSetBitsSumApproach_1(5));
            Console.WriteLine(CountTotalSetBits.CountSetBitsSumApproach_2(5));


            foreach (string s in FizzBuzzProblem.FizzBuzzArrayOfStrings(15))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"MaxPossibleLength of odd-even sub-sequence: {OddEvenSubSequence.MaxPossibleLength([36, 41, 55, 35, 52, 36, 34, 92, 13, 32, 42])}");

            int[] arr = [1, 2, 3, 4, 5];
            arr = RotateArrayByKSteps.RotateArray(arr, 42);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine(PrimalPowerOfArray.PrimalPower([-11, 7, 8, 9, 10, 11]));

            arr = MultiplicationOfPreviousAndNext.MultipliedArray([5, 17, 100, 11]);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            MultipleLeftRotationOfArray.MultipleLeftRotatedArray([1, 2, 3, 4, 5], [2, 3]);

            AnagramsProblem.Anagrams(["dog", "ctt", "god", "tct", "odg"]);

            CommonElementsInTwoArrays.CommonElements([2, 1, 4, 10], [3, 6, 2, 10, 10]);

            Console.WriteLine($"{PairWithGivenXor.Count([5, 4, 10, 15, 7, 6], 5)}");

            Console.WriteLine($"{SpecialSubsequencesAG.Count("ABCGAG")}");

            Console.WriteLine($"{LengthOfLongestConsecutiveOnes.Count("11101001")}");

            AntiDiagonalElements.AnitDiagonalOfAnArray([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);

            int[][] pascalTriangle = PascalTriangle.PascalTriangleGenerator(5);
            Common.Print2DArray(pascalTriangle);

            int[][] rotatedMatrixBy90 = RotateMatrixByNinetyDegree.RotateMatrixBy90([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);
            Common.Print2DArray(rotatedMatrixBy90);
        }
    }
}
