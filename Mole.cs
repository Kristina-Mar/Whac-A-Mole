using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Whac_A_Mole
{
    internal class Mole
    {
        public int MoleNumber; // the number the player tries to match
        public void MoleShow()
        {
            Random randomNumberGenerator = new Random();
            MoleNumber = randomNumberGenerator.Next(10);
            Console.Clear();
            Console.WriteLine($"Write the same number in the console:");
            Console.WriteLine($"{MoleNumber}");
        }
        public bool WasIHit(int WhacNumber)
        {
            return MoleNumber == WhacNumber;
        }
    }
}
