using System;

namespace LabLambda
{
    public static class ConsoleDrawing
    {
        public static void Square(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                    Console.Write("o ");
                Console.WriteLine();
            }
        }


        public static void Triangle(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("o ");
                Console.WriteLine();
            }
        }

        // draws a rectangular frame of size height and width
        public static void Frame(int height, int width)
        {
            char center;
            for (int i = 0; i < height; i++)
            {
                center = (i == 0 || i == height - 1) ? 'o' : ' ';  // set center element for given row
                for (int j = 0; j < width; j++)
                    Console.Write("{0} ", (j == 0 || j == width - 1) ? 'o' : center);
                Console.WriteLine();
            }
        }

        // draws a line of a specified length with characters c
        public static void Line(int length, char c)
        {
            for (int i = 0; i < length; i++)
                Console.Write("{0} ", c);
            Console.WriteLine();
        }

        // draws a diamond of circles with fixed size 5 x 5
        public static void Diamond5x5()
        {
            Console.WriteLine("    o");
            Console.WriteLine("  o o o");
            Console.WriteLine("o o o o o");
            Console.WriteLine("  o o o");
            Console.WriteLine("    o");
        }
    }
}
