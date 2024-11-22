using R7.DSA.Arrays;
using R7.DSA.BitManipulation;
using R7.DSA.Hashing;
using R7.DSA.MultiDimensionalArrays;
using R7.DSA.Recursion;
using R7.DSA.Sorting;
using R7.DSA.String_Manipulation;

namespace R7.DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private static void OldProgramExecutions()
        {
            Console.WriteLine($"{new string(MiscStringManipulationProblems.ToUpper(['S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y']))}");
            Console.WriteLine($"{new string(MiscStringManipulationProblems.ToUpper(['S', 'c', 'a', 'L', 'e', 'r', '#', '2', '0', '2', '0']))}");

            Console.WriteLine($"{new string(MiscStringManipulationProblems.ToLower(['S', 'c', 'A', 'l', 'e', 'r', 'A', 'c', 'a', 'D', 'e', 'm', 'y']))}");
            Console.WriteLine($"{new string(MiscStringManipulationProblems.ToLower(['S', 'c', 'a', 'L', 'e', 'r', '#', '2', '0', '2', '0']))}");

            string rotatedCharArr = new string(MiscStringManipulationProblems.RotateStringByK(['s', 'c', 'a', 'l', 'e', 'r'], 3));
            Console.WriteLine($"Rotate character array by k: {rotatedCharArr}");

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

            RowWithMaximumNumberOfOnes.GetRowIndex([[0, 0, 0, 1],
                [0, 1, 1, 1],
                [1, 1, 1, 1],
                [0, 0, 0, 0]]);

            MinDistanceBetweenTwoEquals.FindIndices([2, 1, 4, 2, 6, 4, 2, 3, 2, 4, 3]);

            SubArrayWithZeroSum.Exists([1, 1, 1, 1, 1, 1, 1]);

            Console.WriteLine($"{NobleInteger.FindNobleInteger([4, 7, 4, 10, 4])}");

            PairsWithMinDifference.FindPairs([2, 1, 3, 6, 4]);

            SortInAlternateAscDesc.SortPattern([4, 1, 2, 5, 3, 6, 8, 9]);

            ArrayWithSumOfTwoEqualSomeOfOtherTwoElements.Find([7, 3, 2, 8, 12, 1, 5, 4]);

            string reverseStr = "I am going to Delhi";
            ReverseCharArrayWithSpaces.Reverse(reverseStr.ToCharArray());

            ReverseCharArray.Reverse("Raja".ToCharArray());

            IsCharArrayPalindrome.IsPalindrome("malayalam".ToCharArray());

            Console.WriteLine(IsAirthmeticProgression.Check([9, 5, 7, 8, 6, 4, 1, 2, 3, 11]));

            Console.WriteLine(KthSmallestElementWithSwap.Find([2, 5, 1, 98, 45, 7], 4));

            SortByColor.Sort([0, 2, 1, 0, 1, 0, 0, 1, 2, 1, 0, 2]);

            StepWiseSelectionSort.Sort([6, 4, 3, 7, 2, 8]);

            IsPalindromeWithSwap.Check("YMLAAALMA".ToCharArray());

            PrintMatrixInSpiral.Print([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]]);

            // Recursion basic problems
            Console.WriteLine($"Fibonacci of N: {RecursionProblems.Fibonacci(10)}");
            Console.WriteLine($"Sum of N: {RecursionProblems.Sum(10)}");
            Console.WriteLine($"Factorial of N: {RecursionProblems.Factorial(5)}");
            string strRecur = "rajas";
            Console.WriteLine($"Is String Palindrome: {RecursionProblems.IsPalindrome(strRecur, 0, strRecur.Length - 1)}");
            strRecur = "naman";
            Console.WriteLine($"Is String Palindrome: {RecursionProblems.IsPalindrome(strRecur, 0, strRecur.Length - 1)}");

            Console.WriteLine($"Single Number II: {SingleNumber2.FindNumber([2, 3, 4, 5, 2, 2, 5, 4, 5, 4, 3, 3, 185])}");
            
            Console.WriteLine($" IsAlphaNumeric: {MiscStringManipulationProblems.IsAlpha(['S', 'c', 'a', 'l', 'e', 'r', 'A', 'c', 'a', 'd', 'e', 'm', 'y', '2', '0', '2', '0'])}");
            Console.WriteLine($" IsAlphaNumeric: {MiscStringManipulationProblems.IsAlpha(['S', 'c', 'a', 'l', 'e', 'r', '#', '2', '0', '2', '0'])}");
        }
    }
}
