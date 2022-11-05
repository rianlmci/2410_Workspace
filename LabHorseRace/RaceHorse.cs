using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabHorseRace
{
    public class RaceHorse
    {
        private Random random = new Random();
        public string Name { get; }

        public ConsoleColor Color { get; }

        /* 
         * step size corrilates with speed, camel cased. 
         * lowercase if it doesnt have access!!
         */
        private int stride;

        private int left; //current position of the horse

        private Lane lane; //Lane on which the horse is running

        private readonly int goalPosition;
        /// <summary>
        /// Information about who, what, and where our RaceHorse is.
        /// </summary>
        /// <param name="name">Name of horse</param>
        /// <param name="color">Color of horse</param>
        /// <param name="lane">Which lane the horse is in</param>
        public RaceHorse(string name, ConsoleColor color, Lane lane)
        {
            Name = name;
            Color = color;
            this.lane = lane;
            left = lane.StartLeft;
            stride = random.Next(1,6);
            goalPosition = lane.StartLeft + lane.Length;
        }
        /// <summary>
        /// Places horse at the beginning of the lane.
        /// </summary>
        public void StartPosition(){
            Console.SetCursorPosition(left,lane.StartTop);
            Console.BackgroundColor = Color;
            Console.WriteLine(" ");
        }
        /// <summary>
        /// Moves the horse ahead by one stride.
        /// </summary>
        public void Move(){
            //resets color
            Console.SetCursorPosition(left, lane.StartTop);
            Console.BackgroundColor = lane.Color;
            Console.WriteLine(" ");
            left += stride;
            if (left + stride > lane.StartLeft + lane.Length) {
                left = lane.StartLeft + lane.Length;
            }
            
            Console.SetCursorPosition(left, lane.StartTop);
            Console.BackgroundColor = Color;
            Console.WriteLine(" ");

        }

        public Boolean isFinished()
        { 
            return left == goalPosition;
        }
    }
}
