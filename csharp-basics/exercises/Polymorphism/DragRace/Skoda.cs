using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    class Skoda : Car, ICar
    {

        public override void SpeedUp()
        {
            CurrentSpeed = CurrentSpeed += 8;
        }

        public override void SlowDown()
        {
            CurrentSpeed = CurrentSpeed -= 6;
        }

    }
}
