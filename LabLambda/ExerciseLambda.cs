using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabLambda
{

    public class ExerciseLambda
    {
        static List<int> data = new List<int> { 3, 5, 7 };

        public static void Start()
        {
            DrawAll(ConsoleDrawing.Triangle);
            DrawAll(ConsoleDrawing.Square);
            DrawAll(x => ConsoleDrawing.Frame(x, (2 * x)));
            DrawAll(y => ConsoleDrawing.Line(y, '~'));
            DrawAll(z => ConsoleDrawing.Diamond5x5());
        }

        private static void DrawAll(Action<int> drawMethod)
        {
            foreach (int number in data)
            {
                drawMethod(number);
                Console.WriteLine();
            }
        }
    }
}
