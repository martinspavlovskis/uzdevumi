using System;

namespace DragRace
{
    public class Tesla : Car, ICar
    {
        public override void SpeedUp() 
        {
            CurrentSpeed = CurrentSpeed += 15;
        }
        public override void SlowDown()
        {
            CurrentSpeed = CurrentSpeed -= 13;
        }
        public override string StartEngine() 
        {
            return "-- silence ---";
        }
    }
}