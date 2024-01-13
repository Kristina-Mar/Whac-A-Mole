using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whac_A_Mole
{
    internal class Game
    {
        public double TimeLimit = 0; // in seconds
        public DateTime StartTime;
        public Game(int timeLimit)
        {
            TimeLimit = timeLimit;
        }
        public Game(): this(30) // default time limit set to 30 seconds
        {}
        public void StartGame() // game starts after the player presses any key, start time is saved
        { 
            Console.ReadLine();
            StartTime = DateTime.Now;
        }
    }
}
