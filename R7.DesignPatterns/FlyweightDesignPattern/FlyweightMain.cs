using System;
using System.Collections.Generic;

namespace R7.DesignPattern.FlyweightDesignPattern
{
    internal class FlyweightMain
    {
        private static List<FlyingBullet> flyingBullets = new List<FlyingBullet>();
        public static void Entry()
        {
            Console.WriteLine($"Printing Bullet reference (hashcode) for first 5 flying bullets");
            Bullet greenBullet = new Bullet("Green",9, 150);
            for (int i=0; i<10000;  i++)
            {
                FlyingBullet flyingBullet = new FlyingBullet { Bullet = greenBullet };
                if ( i < 5)
                {
                    Console.WriteLine(flyingBullet.Bullet.GetHashCode());
                }
                flyingBullets.Add(flyingBullet);
            }
        }
    }
}
