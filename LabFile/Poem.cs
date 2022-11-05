﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFile
{
    public class Poem
    {
        public static void PrintPoem(string fileName) {
            using (StreamReader reader = new StreamReader(fileName)) {
                while (!reader.EndOfStream) {
                    Console.WriteLine(reader.ReadLine());
                }
            }
        }
        public static void SavePoemWithLineNumbers() {
            using (StreamReader reader = new StreamReader("Poem.txt"))
            using (StreamWriter writer = new StreamWriter("Poem1.txt"))
            {   int lineCount = 1;
                while (!reader.EndOfStream)
                {
                    Console.WriteLine("{0:00} {1}", lineCount, reader.ReadLine());
                    lineCount++;
                }
            }

        }
    }
}
