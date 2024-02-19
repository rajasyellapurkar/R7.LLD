namespace R7.TicTacToe.Entities
{
    public abstract class Player
    {
        public char Symbol { get; set; }

        public abstract Cell MakeMove();
    }
}
