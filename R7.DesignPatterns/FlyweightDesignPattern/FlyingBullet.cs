namespace R7.DesignPattern.FlyweightDesignPattern
{
    internal class FlyingBullet
    {
        public Bullet Bullet { get; set; }
        public (int, int) Coordinates { get; set; }
        public string Shooter {  get; set; }
        public string Direction { get; set; }
    }
}
