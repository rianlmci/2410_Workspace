using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labLINQ
{
    public class DemoLINQ1
    {
        #region list of cities 
        private static List<City> cities = new List<City> {
            new City("Boston", UsState.MA, 617594, 48.3),
            new City("Columbus", UsState.OH, 787033, 217.2),
            new City("Houston", UsState.TX, 2099451, 599.6),
            new City("Indianapolis", UsState.IN, 820445, 176.5),
            new City("Los Angeles", UsState.CA, 3792621, 468.7),
            new City("New York", UsState.NY, 8175133, 302.6),
            new City("Phoenix", UsState.AZ, 1445632, 516.7),
            new City("Salt Lake City", UsState.UT, 186440, 111.1),
            new City("Seattle", UsState.WA, 608660, 83.9)
        };
        #endregion

        #region Start
        public static void Start()
        {
            Console.WriteLine("\nL I N Q 1   D E M O");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("\n\n1) All states:");
            AllStates();

            Console.WriteLine("\n\n2) All states no duplicates:");
            AllStatesNoDoubles();

            Console.WriteLine("\n\n3) Cities with more than 1 million people:");
            CitiesGreaterThan1000000();

            Console.WriteLine("\n\n4) Name and population where more than 1 million:");
            NameAndPopulationWhereGreater1000000();

            Console.WriteLine("\n\n5) Cities whose name starts with 'S':");
            CitiesWhoseNameStartsWithS();

            Console.WriteLine("\n\n6) Cities sorted by area (large to small):");
            CitiesSortedByArea();

            Console.WriteLine("\n\n7) Group by State:");
            GroupByState();

            Console.WriteLine("\n\n. . . press enter . . .");
            Console.Read();
        }
        #endregion

        private static void AllStates()
        {
            cities.Add(new City("Moab", UsState.UT, 5317, 4.795));
            IEnumerable<UsState> allStates =
                from c in cities
                select c.State;
            cities.Add(new City("Sandy", UsState.UT, 9550, 24.16));
            //LINQ has deffered execution, so it calculates the enumerable ONLY
            //once we call the enumeration.
            //so the order doesn't matter in the same way as we're used to.


            //old for each unwoke
            /*
            foreach (UsState oneState in allStates)
            {
                Console.Write($"{oneState} ");
            }
            Console.WriteLine();
            


            //bespoke: string join
            Console.WriteLine(string.Join(", ", allStates));
            */

            ///method syntax///
            allStates = cities.Select(c => c.State);
            Console.WriteLine(string.Join(", ", allStates));
        }

        private static void AllStatesNoDoubles()
        {   /*
            IEnumerable <UsState> allUniqueStates =
                (from c in cities
                select c.State).Distinct();

            Console.WriteLine(string.Join(", ", allUniqueStates));
            */

            
            //method syntax//
            IEnumerable <UsState> allUniqueStates = cities
                .Select(c => c.State).
                Distinct();
            
            Console.WriteLine(string.Join(", ", allUniqueStates));
        }

        private static void CitiesGreaterThan1000000()
        {   /*
            IEnumerable<City> largePopCities =
                 from c in cities
                 where c.Population > 1_000_000
                 select c;

            Console.WriteLine(string.Join("\n", largePopCities));
            */

            //method syntax//
            IEnumerable<City> largePopCities = cities
                .Where(c => c.Population > 1_000_000);
          
            Console.WriteLine(string.Join(", ", largePopCities));
        }

        private static void NameAndPopulationWhereGreater1000000()
        {   /*
            //cant change var because we made a new anon type
            var nameAndPopOfLargeCities =
                from c in cities
                where c.Population > 1_000_000
                select new {c.Name, c.Population};
            
            foreach (var element in nameAndPopOfLargeCities) {
                Console.WriteLine($"{element.Name} {element.Population}");
            }
            */

            //method syntax//
            var nameAndPopOfLargeCities = cities
                .Where(c => c.Population > 1_000_000)
                .Select(c => new { c.Name, c.Population });

            foreach (var element in nameAndPopOfLargeCities)
            {
                Console.WriteLine($"{element.Name} {element.Population}");
            }
        }

        private static void CitiesWhoseNameStartsWithS()
        {   /*
            IEnumerable<City> citieswithS =
                from c in cities
                where c.Name[0] == 'S'
                select c;
            
            Console.WriteLine(string.Join("\n", citieswithS));
            */

            //method syntax//
            IEnumerable<City> citieswithS = cities
                .Where(c => c.Name.StartsWith('S'));
            Console.WriteLine(string.Join("\n", citieswithS));
        }

        private static void CitiesSortedByArea()
        {   /*
            IEnumerable<City> citiesByArea =
                from c in cities
                orderby c.Area descending
                select c;
            */
            
            //method syntax//
            IEnumerable<City> citiesByArea = cities.OrderByDescending(c => c.Area);
            Console.WriteLine(string.Join("\n", citiesByArea));
        }

        private static void GroupByState()
        {
            IEnumerable<City> citiesByState =
                from c in cities
                orderby c.State
                select c;

                Console.WriteLine(string.Join("\n", citiesByState));
        }

    }
}
