using R7.DesignPattern.InterfaceOverInheritance.SoundBehaviour;
using R7.DesignPattern.InterfaceOverInheritance.WalkingBehaviour;

namespace R7.DesignPattern.InterfaceOverInheritance
{
    internal class Cat : Animal, IWalkable, ISound
    {
        private IWalkingBehaviour _walkBehaviour;
        private ISoundBehaviour _soundBehaviour;
        public Cat(IWalkingBehaviour walkingBehaviour,
            ISoundBehaviour soundBehaviour)
        {
            _walkBehaviour = walkingBehaviour;
            _soundBehaviour = soundBehaviour;
        }

        public void MakeSound()
        {
           _soundBehaviour.MakeSound();
        }

        public void Walk()
        {
            _walkBehaviour.Walk();
        }
    }
}
