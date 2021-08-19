using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        public string name;
        public string sex;
        public string father { get; set; }
        public string mother { get; set; }

        public Dog(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public string FathersName()
        {
            return father ?? "Unknown";
        }
        public bool HasSameMotherAs(Dog otherDog)
        {
            return mother == otherDog.mother;
        }
    }
}
