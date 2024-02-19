using System;
namespace R7.DesignPattern.InterfaceOverInheritance.WalkingBehaviour
{
    internal class FastWalkingBehaviour : IWalkingBehaviour
    {
        public void Walk()
        {
            Console.WriteLine("Fast Walking Behavior");
        }
    }
}
