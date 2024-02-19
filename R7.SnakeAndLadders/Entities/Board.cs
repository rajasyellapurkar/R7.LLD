namespace R7.SnakeAndLadders.Entities
{
    public class Board
    {
        private int size;
        private List<Cell> cells = [];
        private List<SnakeCell> snakes = [];
        private List<LadderCell> ladders = [];

        private Dictionary<CellType, List<Cell>>  _specialCell = new ();
    }
}
