public class SolveNQueensSolution
{

    private Dictionary<int, bool> rightDiagonal = new Dictionary<int, bool>();
    private Dictionary<int, bool> leftDiagonal = new Dictionary<int, bool>();
    private bool[] rowsFlag;
    private List<IList<string>> result = new();

    public IList<IList<string>> SolveNQueens(int n)
    {
        rowsFlag = new bool[n];
        PlaceNQueen(new int[n], 0);
        return result;
    }

    private void PlaceNQueen(int[] chessArr, int index)
    {
        if (index == chessArr.Length)
        {
            var distinctResult = new List<string>();
            for (int i = 0; i < chessArr.Length; i++)
            {
                string str = string.Empty;
                for (int j = 0; j < chessArr.Length; j++)
                {
                    if (chessArr[i] == j)
                    {
                        str += "Q";
                    }
                    else
                    {
                        str += ".";
                    }
                }
                distinctResult.Add(str);
            }
            result.Add(distinctResult);
            return;
        }
        for (int i = 0; i < chessArr.Length; i++)
        {
            if (isValid(chessArr, index, i))
            {
                chessArr[i] = index; // Queen is placed at row i and column index
                rowsFlag[i] = true;
                rightDiagonal.Add(i + index, true);
                leftDiagonal.Add(i - index, true);
                PlaceNQueen(chessArr, index + 1);
                rowsFlag[i] = false;
                rightDiagonal.Remove(i + index);
                leftDiagonal.Remove(i - index);
            }
            else
            {
                continue;
            }
        }
    }

    private bool isValid(int[] colPos, int index, int i)
    {
        if (rightDiagonal.ContainsKey(i + index) && rightDiagonal[i + index] == true)
        {
            return false;
        }
        if (leftDiagonal.ContainsKey(i - index) && leftDiagonal[i - index] == true)
        {
            return false;
        }
        if (rowsFlag[i] == true)
        {
            return false;
        }
        return true;
    }
}