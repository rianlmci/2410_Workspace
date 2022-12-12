using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLinq2
{
    public class LinqAutomobile
    {
        private static List<Automobile> automobiles = new List<Automobile> {
           new Automobile(2005, AutomobileCategory.Bus, ConsoleColor.Yellow),
           new Automobile(2012, AutomobileCategory.Car, ConsoleColor.Red),
            new Automobile(2002, AutomobileCategory.Truck, ConsoleColor.Blue),
            new Automobile(2005, AutomobileCategory.Car, ConsoleColor.Green),
            new Automobile(2010, AutomobileCategory.Car, ConsoleColor.Red) };

        public static void Challenges()
        {
            Console.WriteLine("\n* * * * * * * * * * * * * * * * *");
            Console.WriteLine("all automobiles:");
            foreach (Automobile automobile in automobiles) {
                automobile.Display();
            }

            Console.WriteLine("\n* * * * * * * * * * * * * * * * *");
            Console.WriteLine("automobiles that were built up until 2010\n");
            var twentytens = automobiles.Where(a => a.Year <= 2010);
            PrintMyCars(twentytens);


            Console.WriteLine("\n* * * * * * * * * * * * * * * * *");
            Console.WriteLine("automobiles that are red\n");
            var red= automobiles.Where(a => a.Color == ConsoleColor.Red);
            PrintMyCars(red);


            Console.WriteLine("\n* * * * * * * * * * * * * * * * *");
            Console.WriteLine("automobiles that are blue or that were built in 2005\n");
            var blueOr2005 = automobiles.Where(a => a.Color == ConsoleColor.Blue || a.Year == 2005);
            PrintMyCars(blueOr2005);

            Console.WriteLine("\n* * * * * * * * * * * * * * * * *");
            Console.WriteLine("automobiles that are not Red and not a bus\n");
            var notRedAndNotBus = automobiles.Where(a => a.Color != ConsoleColor.Red && a.Catagory != AutomobileCategory.Bus);
            PrintMyCars(notRedAndNotBus);
        }

        private static void PrintMyCars(IEnumerable<Automobile> automobiles) {
            foreach (Automobile automobile in automobiles)
            {
                automobile.Display();
            }
        }
    }
}
