namespace R7.DSA.Arrays
{
    public static class FizzBuzzProblem
    {
        public static string[] FizzBuzzArrayOfStrings(int A)
        {
            string[] array = new string[A];
            for (int i = 1; i <= A; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    array[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    array[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    array[i - 1] = "Buzz";
                }
                else
                {
                    array[i - 1] = i.ToString();
                }
            }
            return array;
        }
    }
}
