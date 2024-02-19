namespace R7.TicTacToe.Entities
{
    public class Game
    {
        Board Board { get; set; }
        List<Player> PlayerList { get; set; } = new List<Player>();

        public Game()
        {
            Board = new Board(3);
        }
    }
}
