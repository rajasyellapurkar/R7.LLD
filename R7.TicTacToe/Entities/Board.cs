
namespace R7.TicTacToe.Entities
{
    public class Board
    {
        List<List<Cell>> _cells = new List<List<Cell>>();

        public Board(int boardSize)
        {
            InitializeBoard(boardSize);
        }

        private void InitializeBoard(int boardSize)
        {
            _cells = new List<List<Cell>>(boardSize);
            for (int i = 0; i < boardSize; i++)
            {
                _cells[i] = new List<Cell>(boardSize);
            }
        }
    }
}
