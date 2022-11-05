using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LabInheritance
{
    // Class Pet should NOT be modified
    public class Pet : IComparable<Pet>
    {
        public string Name { get; private set; }

        public Pet(string name)
        {
            Name = name;
        }

        public virtual string Communicate()
        {
            return "communicate";
        }

        public override string ToString()
        {
            return string.Format("{0} named {1}", this.GetType().Name, Name);
        }

        public int CompareTo(Pet? other) 
            //? means nullable, means you can assign a value to it.
        {
            if (other == null) return 1; 
            //anything is more than nothing in C#
           
            return this.Name.CompareTo(other.Name);
        }
    }

    // TODO 2) declare a class Cat that derives from Pet; 
    //         override the method Communicate to "meow"

}
