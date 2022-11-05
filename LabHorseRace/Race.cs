using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LabHorseRace
{
    public class Race
    {
        private Lane[] lanes;
        private RaceHorse[] horses;
        private RaceHorse winner = null;

        public Race() {
            lanes = new Lane[] {
                new Lane(8, 4, 40),
                new Lane(8, 6, 40),
                new Lane(8, 8, 40)};

            horses = new RaceHorse[] {
                new RaceHorse("Bob", ConsoleColor.Yellow, lanes[0]),
                new RaceHorse("Boo", ConsoleColor.Red, lanes[1]),
                new RaceHorse("Goo", ConsoleColor.Green, lanes[2])};

        }

        public void Start() {
            
            foreach (Lane lane in lanes) {
                lane.Paint();
            }
            
            foreach (RaceHorse horse in horses) {
                horse.StartPosition();
            }

            Console.CursorVisible = false;
            while (!RaceisFinished()) //TODO
            {
                foreach (RaceHorse horse in horses) {
                    horse.Move();
                }
                Thread.Sleep(200); // in milliseconds
            }
            Console.BackgroundColor = ConsoleColor.Black;
            
            Console.ForegroundColor = winner.Color;
            Lane lastLane = lanes[lanes.Length - 1];
            Console.SetCursorPosition(lastLane.StartLeft, lastLane.StartTop+2);
            Console.WriteLine($"Winner: {winner.Name}");
            
        }

        private bool RaceisFinished()
        {
            bool stillRunning = false;

            foreach (RaceHorse horse in horses) {
                if (!horse.isFinished())
                {
                    stillRunning = true;
                }
                else if (winner == null){
                    winner = horse;
                }
            }
            return !stillRunning;
        }
    }
}
