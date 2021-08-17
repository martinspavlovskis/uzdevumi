using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class CozaLoza
    {
        public static string MakeCoza(int i)
        {
            if (i % 3 == 0)
                return "Coza ";
            else if (i % 5 == 0)
                return "Woza ";
            else if (i % 7 == 0)
                return "CozaLoza ";
            else if (i % 3 != 0 || i % 5 != 0 || i % 7 != 0)
                return i + " ";                     
            return "1";
        }
    }
}
