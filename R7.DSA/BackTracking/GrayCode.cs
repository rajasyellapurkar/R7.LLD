namespace R7.DSA.BackTracking
{
    internal class GrayCode
    {
        public static void Execute()
        {
            List<string> result = GenerateNumbers(4);
            List<int[]> result2 = GenerateNumbers2(4);
            List<List<int>> subSequence = GenerateSubsets([1, 2, 3]);
        }
        private static List<string> GenerateNumbers(int N)
        {
            if (N == 1)
            {
                return ["0", "1"];
            }
            List<string> prevResult = GenerateNumbers(N - 1);
            List<string> currentResult = new List<string>();
            foreach (string s in prevResult)
            {
                currentResult.Add("0" + s);
                currentResult.Add("1" + s);
            }
            return currentResult;
        }
        private static List<int[]> GenerateNumbers2(int N)
        {
            if (N == 1)
            {
                return [[0], [1]];
            }
            List<int[]> prevResult = GenerateNumbers2(N - 1);
            List<int[]> currentResult = new List<int[]>();
            foreach (int[] arr in prevResult)
            {
                int[] arr1 = new int[N];
                int[] arr2 = new int[N];

                arr1[0] = 0;
                arr2[0] = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr1[i + 1] = arr[i];
                    arr2[i + 1] = arr[i];
                }

                currentResult.Add(arr1);
                currentResult.Add(arr2);
            }
            return currentResult;
        }
        private static List<List<int>> GenerateSubsets(int[] a)
        {
            List<int[]> zeroOnesList = GenerateNumbers2(a.Length);
            List<List<int>> result = new();
            foreach (int[] arr in zeroOnesList)
            {
                List<int> sequence = new List<int>();
                for(int i=0; i<arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        sequence.Add(a[i]);
                    }
                }
                result.Add(sequence);
            }
            return result;
        }
    }
}
