namespace R7.SnakeAndLadders.Entities
{
    public class NormalCell : Cell
    {
        public NormalCell()
        {
            CellType = CellType.NormalCell;
        }
        public override int GetNextPosition()
        {
            return this.Index;
        }
    }
}
