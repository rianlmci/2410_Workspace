using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{   /// <summary>
    /// Cat pet communicates with a unique sound 
    /// </summary>
    class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
        }

        public override string Communicate()
        {
            return "meeeeeow!";
        }
    }
}
