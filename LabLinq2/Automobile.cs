using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLinq2
{   public enum AutomobileCategory {
        Bus, Car, Truck
    } 

    public class Automobile
    {
        public int Year { get; }

        public AutomobileCategory Catagory { get; }

        public ConsoleColor Color { get; }

        public Automobile(int year, AutomobileCategory catagory, ConsoleColor color)
        {
            Year = year;
            Catagory = catagory;
            Color = color;
        }

        public void Display()
        {
            ConsoleColor originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0}", Year);

            // TODO
            Console.ForegroundColor = Color;
            Console.WriteLine("\n");
            switch (Catagory) { 
                case AutomobileCategory.Car:
                    AsciiImage.Car();
                    break;
                case AutomobileCategory.Truck:
                    AsciiImage.Truck();
                    break;
                case AutomobileCategory.Bus:
                     AsciiImage.Bus();
                    break;   

                default:
                    Console.WriteLine(Catagory);
                    break;
            }
            Console.WriteLine("---------------------");
            Console.ForegroundColor = originalColor;
        }
    }
}

