namespace R7.DSA.BasicMaths
{
    internal class ExcelColumnNumber
    {
        public static int GetColumnNumber(string excelColumn)
        {
            char[] c = excelColumn.ToCharArray();
            int n = c.Length;
            int powerOf26 = 1;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                if(i != 0)
                {
                    powerOf26 *= 26;
                }
                int diff = (c[n - 1 - i] - 'A') % 'A';
                result += (diff + 1) * powerOf26;
            }
            return result;
        }
    }
}
