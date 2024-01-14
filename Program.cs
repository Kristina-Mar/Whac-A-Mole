namespace Whac_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHits = 0;
            int numberOfGuesses = 0;
            TimeSpan timeElapsedTimeSpan;
            double timeElapsedInSeconds; // converted TimeSpan so we can compare it to the set time limit in seconds
            Game game = new Game();
            Mole mole = new Mole();
            Player player = new Player();
            Console.WriteLine("Write the same number from 0 to 9 that appears on the screen as quickly as possible.");
            Console.WriteLine($"You have {game.TimeLimit} seconds to correctly match as many numbers as possible.");
            Console.WriteLine("Press any key to start the game.");
            game.StartGame();
            while (true)
            {
                mole.MoleShow();
                player.Whac(Console.ReadKey().KeyChar.ToString()); // The player doesn't have to press Enter, the line gets read after pressing one key.
                timeElapsedTimeSpan = DateTime.Now - game.StartTime; // Logs the time of the player pressing the key and compares it to the time when the game started.
                timeElapsedInSeconds = timeElapsedTimeSpan.TotalSeconds;
                if (timeElapsedInSeconds > game.TimeLimit)
                {
                    break; // game ends when the time runs out
                }
                if (mole.WasIHit(player.WhacNumber))
                {
                    numberOfHits ++;
                }
                else
                {
                    Console.Beep(1000, 400); // The console beeps if the player's number doesn't match. Beep shorter than 400 ms cannot be heard through (my) external speakers.
                }
                numberOfGuesses++;
            }
            Console.Clear();
            double reactionTime = Math.Round(game.TimeLimit / numberOfGuesses, 2); // Rounds to 2 decimal points for better readability.
            Console.WriteLine($"You correctly matched {numberOfHits} numbers in {game.TimeLimit} seconds.");
            Console.WriteLine($"Your average reaction time was {reactionTime} seconds per guess.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
