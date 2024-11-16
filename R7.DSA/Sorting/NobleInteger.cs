namespace R7.DSA.Sorting
{
    public class NobleInteger
    {
        public static int FindNobleInteger(int[] arr)
        {
            int N = arr.Length;
            Array.Sort(arr);
            for(int i=0; i< N-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    continue;
                }
                else
                {
                    int countOfGreaterThan = N - i - 1;
                    if(countOfGreaterThan == arr[i])
                    {
                        return arr[i];
                    }
                }
            }
            return -1;
        }
    }
}
