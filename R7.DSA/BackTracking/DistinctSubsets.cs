namespace R7.DSA.BackTracking
{
    internal class DistinctSubsets
    {
        private static Dictionary<int, int> map = new Dictionary<int, int>();
        private static int[] result;
        public static void Execute()
        {
            int[] arr = [1, 2, 1, 2];
            UpdateMap(arr);
            GenerateSubsets(0);
        }

        private static void UpdateMap(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else
                {
                    map.Add(arr[i], 1);
                }
            }
            result = new int[map.Count];
        }

        private static void GenerateSubsets(int index)
        {
            //base condition
            if (index == map.Count)
            {
                for(int i =0; i < map.Count; i++)
                {
                    Console.Write($" {result[i]} ");
                }
                Console.WriteLine();
                return;
            }
            for(int i = 0; i <= map[map.Keys.ElementAt(index)]; i++)
            {
                result[index] = i;
                GenerateSubsets(index+1);
            }
        }
    }
}
