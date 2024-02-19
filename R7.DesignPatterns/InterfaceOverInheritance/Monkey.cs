using R7.DesignPattern.InterfaceOverInheritance.WalkingBehaviour;

namespace R7.DesignPattern.InterfaceOverInheritance
{
    internal class Monkey : Animal, IWalkable
    {
        private IWalkingBehaviour _walkBehaviour;
        public Monkey(IWalkingBehaviour walkingBehaviour)
        {
            _walkBehaviour = walkingBehaviour;
        }
        public void Walk()
        {
            _walkBehaviour.Walk();
        }
    }
}
