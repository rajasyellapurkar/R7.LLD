
using System;
namespace R7.DesignPattern.InterfaceOverInheritance.SoundBehaviour
{
    internal class SilentSoundBehaviour : ISoundBehaviour
    {
        public void MakeSound()
        {
            Console.WriteLine("Makes Silent Sound");
        }
    }
}
