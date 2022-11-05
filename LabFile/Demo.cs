using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace LabFile
{
    public class Demo
    {
        private static Random rand = new Random();
        public static void CreateRandomNumbersFile()
        {
            //Like using try with resoucrces, once we leave {} we leave scope!
            using (StreamWriter writer = new StreamWriter("Numbers.txt"))
            {

                for (int i = 0; i < 4; i++)
                {
                    writer.WriteLine(rand.Next(1, 10)); //LB inclusive, UB exclusive [1,10)

                }
            }
        }

        public static void PrintRandomNumberIfEvenToFile()
        {
            using (StreamReader reader = new StreamReader("Numbers.txt"))
            using (StreamWriter writer = new StreamWriter("Numbers-2.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (int.TryParse(line, out int number))
                    {
                        int lineAsInt = Convert.ToInt32(line);

                        if (lineAsInt % 2 == 0)
                        {
                            Console.WriteLine(line);
                        }
                    }

                }
            }
        }
        //dont use this in calss b/c she want us to practice using!
        public static void ReadAllText(string fileName)
        {   string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines) {
                Console.WriteLine(line);
            }
            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}
