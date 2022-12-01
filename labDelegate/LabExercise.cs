using System;
using System.Collections.Generic;

namespace LabDelegate
{
    public class LabExercise
    {
        // TODO 1 and 2: 
        static IList<int> data = new List<int> { 3, 5, 7 };

        public static void Start()
        {
            Action<int> draw = ConsoleDrawing.Triangle;
            
            //DrawAll(ConsoleDrawing.Triangle);
            //DrawAll(ConsoleDrawing.Square);

            draw += ConsoleDrawing.Square;

            DrawAll(draw);

        }

        /// <summary>
        ///  Loops through all the numbers in the list data. 
        ///  for each of the numbers it calls the method(s) associated with the delegate drawMethod
        ///  and passes the number as parameter
        ///  After each call of drawMethod the cursor is advanced to the next line
        /// </summary>
        /// <param name="drawMethod"></param>
        private static void DrawAll(Action<int> drawMethod)
        {
            foreach (int onedata in data)
            {
                drawMethod(onedata);
                Console.WriteLine();
            }
        }
    }
}
