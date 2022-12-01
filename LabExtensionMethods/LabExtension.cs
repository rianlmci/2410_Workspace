using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExtensionMethods
{
    public static class LabExtension
    {
        public static void Challenges() {
            ICollection<int> numbers = 
                new List<int> {0,1,13,2,5,7,4,6,6,15,3,4};
            Console.WriteLine($"All numbers                              : {String.Join(' ',numbers)}.");
            Console.WriteLine($"Sum of all numbers                       : {numbers.Sum()}.");
            Console.WriteLine($"Number of elements using Count()         : {numbers.Count()}.");
            Console.WriteLine($"Number of elements using .Count          : {numbers.Count}." +
                         $"\n(always use property over an extension method, its more efficient.)");
            Console.WriteLine($"Average of all numbers                   : {numbers.Average()}.");
            Console.WriteLine($"First five elements                      : {String.Join(' ', numbers.Take(5))}.");
            Console.WriteLine($"Largest of first four elements           : {numbers.Take(4).Max()}.");
            Console.WriteLine($"Last number of first four elements       : {numbers.Take(4).Last()}.");
            Console.WriteLine($"Last four elements                       : {String.Join(' ', numbers.Skip(numbers.Count-4))}.");
            Console.WriteLine($"Smallest number of the last four elements: {numbers.Skip(numbers.Count-4).Min()}.");
        }
    }
}
