using System.Linq;

namespace R7.DSA.Hashing
{
    public static class AnagramsProblem
    {
        public static List<List<int>> Anagrams(string[] arr)
        {
            Dictionary<string, List<int>> anagramWordSum = new Dictionary<string, List<int>>();
            List<List<int>> result = new List<List<int>>();
            int N = arr.Length;
            for (int i = 0; i < N; i++)
            {
                string sortedWord = arr[i].Sort();
                if (!anagramWordSum.ContainsKey(sortedWord))
                {
                    anagramWordSum[sortedWord] = [i+1];
                }
                else
                {
                    anagramWordSum[sortedWord].Add(i+1);
                }
            }

            foreach(string key in  anagramWordSum.Keys)
            {
                if (anagramWordSum[key].Count > 1)
                {
                    result.Add(anagramWordSum[key]);
                }
            }
            return result;
        }

        public static string Sort(this string str)
        {
            char[] charArr = str.ToCharArray();
            Array.Sort(charArr);
            return new string(charArr);
        }
    }
}
