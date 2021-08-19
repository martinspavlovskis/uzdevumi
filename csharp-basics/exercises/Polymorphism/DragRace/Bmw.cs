using System;

namespace DragRace
{
    public class Bmw : Car, ICar, IBoost
    {
        public override void SpeedUp() 
        {
            CurrentSpeed = CurrentSpeed += 14;
        }
        public override void SlowDown()
        {
            CurrentSpeed = CurrentSpeed -= 12;
        }
        public void UseNitrousOxideEngine()
        {
            CurrentSpeed = CurrentSpeed += 40;
        }
    }
}