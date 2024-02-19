namespace R7.SnakeAndLadders.Entities
{
    public class Player
    {
        public User User { get; set; } = null!;
        private List<Piece> Pieces { get; set; } = [];
    }
}
