using System;

namespace DragRace
{
    public class Audi : Car, ICar
    {       
        public override void SpeedUp() 
        {
            CurrentSpeed = CurrentSpeed += 9;
        }
        public override void SlowDown()
        {
            CurrentSpeed = CurrentSpeed -= 7;
        }
    }
}