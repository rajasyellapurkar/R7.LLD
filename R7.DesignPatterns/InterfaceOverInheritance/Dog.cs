using R7.DesignPattern.InterfaceOverInheritance.WalkingBehaviour;

namespace R7.DesignPattern.InterfaceOverInheritance
{
    internal class Dog : Animal, IWalkable
    {
        private IWalkingBehaviour _walkBehaviour;
        public Dog(IWalkingBehaviour walkingBehaviour)
        {
            _walkBehaviour = walkingBehaviour;
        }
        public void Walk()
        {
            _walkBehaviour.Walk(); 
        }
    }
}
