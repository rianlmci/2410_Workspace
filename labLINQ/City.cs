using System;
namespace labLINQ
{
    

    public class City
    {
        public string Name { get; }
        public UsState State { get; }
        public int Population { get; }
        public double Area { get; }

        public City(string n, UsState s, int p, double a)
        {
            Name = n;
            State = s;
            Population = p;
            Area = a;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) P:{2} A:{3}", Name, State, Population, Area);
        }
    }
}
