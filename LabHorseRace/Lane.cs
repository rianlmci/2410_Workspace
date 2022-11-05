using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabHorseRace
{
    public class Lane
    {
        public int StartLeft { get; } //get means read only!
        public int StartTop { get; } //fields are capitalized
        public int Length { get; }

        public ConsoleColor Color { get; }
        
        //note that paramaters/variables are lowercase
        public Lane(int startLeft, int startTop, int legnth, 
            ConsoleColor color = ConsoleColor.DarkGray) // optional argument
        {
            StartLeft = startLeft;
            StartTop = startTop;
            Length = legnth;
            Color = color;
        }

        public void Paint() {
            ConsoleColor originalBackground = Console.BackgroundColor;
            Console.SetCursorPosition(StartLeft, StartTop);
            Console.BackgroundColor = Color;
            Console.WriteLine(new String(' ', Length));
        }
    }
}
