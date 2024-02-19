using System;
namespace R7.DesignPattern.InterfaceOverInheritance.SoundBehaviour
{
    internal class LoundSoundBehaviour : ISoundBehaviour
    {
        public void MakeSound()
        {
            Console.WriteLine("Makes Lound Sound");
        }
    }
}
