namespace R7.DSA.Hashing
{
    public class CommonElementsInTwoArrays
    {
        public static List<int> CommonElements(int[] a, int[] b)
        {
            int N = b.Length;
            Dictionary<int, int> hashMap = new Dictionary<int,int>();
            for(int i = 0; i< N; i++)
            {
                if (hashMap.ContainsKey(b[i]))
                {
                    hashMap[b[i]]++;
                }
                else
                {
                    hashMap.Add(b[i], 1);
                }
            }

            N = a.Length;
            List<int> result = new List<int>();
            for(int i=0; i< N; i++)
            {
                if (hashMap.ContainsKey(a[i]) && hashMap[a[i]] > 0)
                {
                    result.Add(a[i]);
                    hashMap[a[i]]--;
                }
            }
            return result;
        }
    }
}
