using System;
using System.Collections.Generic;
using System.Text;
using MortalKombatConsoleGame.Interfaces;

namespace MortalKombatConsoleGame.Classes
{
    class PlayerTwo : Player, IDefender
    {
        public bool TakeCover()
        {
            throw new NotImplementedException();
        }

        public void Hurt(int attackType)
        {
            throw new NotImplementedException();
        }
    }
}
