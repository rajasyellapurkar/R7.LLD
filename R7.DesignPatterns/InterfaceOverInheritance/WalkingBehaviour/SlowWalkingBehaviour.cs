using System;
namespace R7.DesignPattern.InterfaceOverInheritance.WalkingBehaviour
{
    internal class SlowWalkingBehaviour : IWalkingBehaviour
    {
        public void Walk()
        {
            Console.WriteLine("Slow Walking Behavior");
        }
    }
}
