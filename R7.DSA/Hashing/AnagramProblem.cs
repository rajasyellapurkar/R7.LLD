using System.Linq;

namespace R7.DSA.Hashing
{
    public class LengthIndexModel
    {
        public int Length { get; }
        public int Index { get; }

        public LengthIndexModel(int length, int index)
        {
            Length = length;
            Index = index;
        }
    }

    public static class AnagramsProblem
    {
        public static int[][] Anagrams(string[] arr)
        {
            Dictionary<int, LengthIndexModel> anagramWordSum = new Dictionary<int, LengthIndexModel>();
            int N = arr.Length;
            int[][] result = new int[N][];
            int resultIndex = 0;
            for (int i = 0; i < N; i++)
            {
                int sum = GetStringCharSum(arr[i]);
                anagramWordSum[sum] = new LengthIndexModel(arr[i].Length, i);
            }

            for (int i = 0; i < N; i++)
            {
                int sum = GetStringCharSum(arr[i]);
                if (anagramWordSum.ContainsKey(sum))
                {
                    LengthIndexModel lengthIndexModel = anagramWordSum[sum];
                    if (lengthIndexModel.Length == arr[i].Length)
                    {
                        result[resultIndex] = [i, lengthIndexModel.Index];
                        resultIndex++;
                    }
                }
            }
            return result;
        }

        private static int GetStringCharSum(string str)
        {
            int sum = 0;
            foreach (char c in str)
            {
                int x = c - 'a';
                sum += x;
            }
            return sum;
        }
    }
}
