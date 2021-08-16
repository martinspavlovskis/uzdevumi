using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    class Jaguar : Car, ICar
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
