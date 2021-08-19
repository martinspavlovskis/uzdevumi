using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
   public class Car
    {
        private int _currentSpeed;
        public int CurrentSpeed
        {
            get { return _currentSpeed; }
            set { _currentSpeed = value; }
        }
        public virtual void SpeedUp()
        {
            CurrentSpeed = CurrentSpeed + 10;
        }
        public virtual void SlowDown()
        {
            CurrentSpeed = CurrentSpeed - 5;
        }
        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }
        public virtual string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}
