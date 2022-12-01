using System;
using System.Collections.Generic;

namespace LabDelegate 
{ 
    public delegate double ConversionDelegate(double value);
    public class ClassExercise
    {
        public static void IntroToDelegate()
        {
            IList<double> data = new List<double> { 2, 4, 6, 8, 10 };
            ConversionDelegate inToCm = LengthConverter.InchToCm;
            
            //Console.WriteLine($"10 inches is {LengthConverter.InchToCm(10)} centimeters"); //indirect call
            Console.WriteLine($"10 inches is {inToCm(10)} centimeters"); //direct delegate call
            Console.WriteLine();

            // TODO d) convert list then call DisplayList

            IList<double> cmList = ConvertList(data, LengthConverter.InchToCm);
            IList<double> mList = ConvertList(data, LengthConverter.InchToM);
            //IList<double> fList = ConvertList(data, FeetToInchAdapter);
            IList<double> fList = 
                ConvertList(data, d => LengthConverter.FeetToInch((int)Math.Round(d)));
            DisplayList(data,"Original List:");
            Console.WriteLine();
            DisplayList(cmList, "Centimeter List:");
            Console.WriteLine();
            DisplayList(fList, "Feet List:");


            // TODO f) What about FeetToInch? (adapter method, anonymous method)

            Console.WriteLine("\n");
        }
        
        /* possible adapter method that passed a specific type.
        private static double FeetToInchAdapter(double d) {
            return LengthConverter.FeetToInch((int)Math.Round(d));
        }
        */
        private static void DisplayList<T>(IList<T> list, string title) {
            Console.WriteLine(title);
            Console.WriteLine(String.Join(", ",list));
        }

        /// <summary>
        ///  Converts every item in the list using the logic found in the conversion delgate's type.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="convert"></param>
        /// <returns></returns>
        private static IList<double> ConvertList(IList<double> data, ConversionDelegate convert)
        {
            IList<double> newList = new List<double>();
            foreach (double onedouble in data)
            {
                newList.Add(convert(onedouble));
            }

            return newList;
        }
    }
}