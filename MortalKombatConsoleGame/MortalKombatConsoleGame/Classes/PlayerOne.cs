using System;
using System.Collections.Generic;
using System.Text;
using MortalKombatConsoleGame.Interfaces;

namespace MortalKombatConsoleGame.Classes
{
    class PlayerOne : Player, IAttacker
    {
        public int Punch()
        {
            throw new NotImplementedException();
        }

        public int Kick()
        {
            throw new NotImplementedException();
        }
    }
}
