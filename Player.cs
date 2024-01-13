using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whac_A_Mole
{
    internal class Player
    {
        public int WhacNumber; // the number the player writes
        public int Whac(string whac) // fun fact, the correct spelling is actually Whac-A-Mole :)
        {
            if (int.TryParse(whac, out int whacNumber))
            {
                return WhacNumber = whacNumber;
            }
            else
            {
                return 10; // the mole only shows numbers 0 to 9, if the player writes anything else, the mole will never be hit/number matched
            }
            
        }
    }
}
