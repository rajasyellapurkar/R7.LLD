namespace R7.TicTacToe.Entities
{
    public class HumanPlayer : Player
    {
        public User User { get; set; } = null!;
        private Cell _cell = null!;
        public override Cell MakeMove()
        {
            return new Cell();
        }

        public Cell MakeMove(int x, int y)
        {
            _cell = new Cell { Symbol = Symbol, X = x, Y = y };
            return MakeMove();
        }
    }
}
