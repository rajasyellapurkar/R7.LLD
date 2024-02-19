namespace R7.SnakeAndLadders.Entities
{
    public abstract class Cell
    {
        public int Index { get; set; }
        public List<Piece> Pieces { get; set; } = new List<Piece>();

        public CellType CellType { get; set; }

        public abstract int GetNextPosition();
    }
}
