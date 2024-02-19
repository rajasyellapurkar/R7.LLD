namespace R7.SnakeAndLadders.Entities
{
    public class LadderCell : Cell
    {
        private int _start;
        private int _end;
        public LadderCell()
        {
            CellType = CellType.Ladder;
        }
        public override int GetNextPosition()
        {
            return _end;
        }

        public int Start
        {
            get { return _start; }
        }

        public int End
        {
            get
            {
                return _end;
            }
        }
    }
}
