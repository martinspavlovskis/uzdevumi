using System;

namespace DragRace
{
    public class Lexus : Car, ICar, IBoost
    {
        public override void SpeedUp() 
        {
            CurrentSpeed = CurrentSpeed += 10;
        }
        public override void SlowDown()
        {
            CurrentSpeed = CurrentSpeed -= 8;
        }
        public void UseNitrousOxideEngine() 
        {
            CurrentSpeed = CurrentSpeed +=40;
        }
    }
}