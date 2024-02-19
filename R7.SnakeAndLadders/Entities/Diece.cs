namespace R7.SnakeAndLadders.Entities
{
    public class Diece
    {
        private int _noOfFaces;
        private Random _random = new Random();
        
        public int Roll()
        {
            return _random.Next(_noOfFaces);
        }
    }
}
