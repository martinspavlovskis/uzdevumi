using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sounds = new List<ISound>() { new Parrot(), new Radio(), new Firework() };
            foreach(var s in sounds)
            {
                s.PlaySound();
            }
        }
    }
}