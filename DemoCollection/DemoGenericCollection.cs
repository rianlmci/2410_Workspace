using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace DemoCollection
{   
    public class DemoGenericCollection
    {
        #region DemoWordCount
        public static void WordCount()
        {
            string[] words = File.ReadAllLines("resources//words.txt");
            IDictionary<string, int> st = new Dictionary<string, int>();
            foreach (string word in words){
                if (st.ContainsKey(word))
                    st[word]++;                             
                else  
                    st.Add(word, 1);               
            }

            foreach (KeyValuePair<string, int> kvp in st)
            {
                Console.WriteLine($"Word: {kvp.Key,-4} Count: {kvp.Value}");
            }
           
        }
        #endregion
        
        #region DemoDictionary
        public static void DemoDictionary() { 
            Console.WriteLine("Demo Dictionary");
            Console.WriteLine("---------------"); 
            IDictionary<string, int> st = new Dictionary<string, int>()
            {
                ["Tokyo"] = 3245000,
                ["New York"] = 19750000,
                ["Mumbai"] = 19200000,
                ["London"] = 12875000,
                ["Paris"] = 12161000,
                ["Cambridge"] = 125700

            };
            
            st.Add("Berlin", 3337000);
            //st.Add("Cambridge", 106000); cant add duplicate key

            // Use the item property (indexer) to print the populiation of Paris
            Console.WriteLine($"Population of Paris: {st["Paris"]}");

            // Use the indexer to change the population of Paris to 1234567
            st["Paris"] = 1234567;
            Console.WriteLine($"New population of Paris: {st["Paris"]}");
            
            // If a key does not exist, setting the indexer for that key adds a new
            //key / value pair.
            // use an indexer to add Melbourne with a population of 3188000
            st["Melbourne"] = 3188000;
            
            
            // But: the indexer throws an exception if you try to look up a key 
            //that does not exist
            // try to look up Salt Lake City - Compile and run
            //Console.WriteLine($"Population of Paris: {st["Salt Lake City"]}");
            // If you don't know whether a key exists in a given dictionary you can
            //use TryGetValue
            // TryGetValue returns null; it does not throw an exception (compare to
            //TryParse)
            // check before accessing Salt Lake City
            //st.ContainsKey("Salt Lake City");
            // Alternative: check with ContainsKey
            checkCityPop("Salt Lake City");
            Console.WriteLine();


            // When using foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            // Use the Values property to list all values of the collection
            // Use the Keys property to list all keys of the collection
            Console.WriteLine("All Key Value Pairs:");
            getAllKeyValInfo();
            Console.WriteLine();

            // Use the Values property to list all values of the collection
            Console.WriteLine($"Values: {string.Join(", ", st.Values)}");
            // Use the Keys property to list all keys of the collection
            Console.WriteLine($"Keys: {string.Join(", ", st.Values)}");
            Console.WriteLine();
            
            // Delete Paris from the collection
            st.Remove("Paris");
            // use a foreach loop to print all dictionary entries
            Console.WriteLine("Updated Key Value Pairs:");
            getAllKeyValInfo();

            void checkCityPop(string city) {
                if (!st.TryGetValue(city, out int value))
                {
                    Console.WriteLine($"{city} is not in the symbol table.");
                }
                else
                {
                    Console.WriteLine($"Population of {city}{st[city]}");
                }
            }

            void getAllKeyValInfo() {
                foreach (KeyValuePair<string, int> kvp in st)
                {
                    Console.WriteLine($"City: {kvp.Key,-15} Population: {kvp.Value}");
                }
            }
        }
        #endregion

        #region DemoQueue
        public static void DemoQueue()
        {
            Console.WriteLine("Demo Queue");
            Console.WriteLine("----------");
            
            // create queue of strings called queue, and add 3 animals 
            Queue<string> animals = new Queue<string>(
                new string[] {"bat","bear","bee"});
            
            // use foreach to list all animals in queue
            Console.WriteLine("All animals:");
            foreach (var animal in animals) {
                Console.Write($"{animal} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            
            // peek to see who is next
            Console.WriteLine($"The next animal is {animals.Peek()}");
            Console.WriteLine();

            //remove one person
            Console.WriteLine($"Removing first animal in the queue: {animals.Dequeue()}");
            Console.WriteLine();

            // list all members in queue again
            Console.WriteLine("All animals updated:");
            foreach (var animal in animals)
            {
                Console.Write($"{animal} ");
            }
            
            // using stacks to reverse things
            Stack<string> animalStack = new Stack<string> (animals);
            Console.WriteLine($"All animals in reverse order with a stack: {string.Join(", ", animalStack)}");
        }
        #endregion
    }
}
