namespace R7.DesignPattern.FlyweightDesignPattern
{
    /// <summary>
    /// Bullet class is immutable
    /// </summary>
    internal class Bullet
    {
        public string Color { get;}
        public int Size { get;}
        public int SpeedInMsPerSec { get; }

        public Bullet(string color, int size, int speed)
        {
            Color = color;
            Size = size;
            SpeedInMsPerSec = speed;
        }
    }
}
