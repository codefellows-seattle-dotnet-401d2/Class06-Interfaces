using System;
using System.Collections.Generic;
using System.Text;
using MortalKombatConsoleGame.Interfaces;

namespace MortalKombatConsoleGame.Classes
{
    class PlayerOne : Player, IAttacker, IBadge
    {
        public int Punch()
        {
            throw new NotImplementedException();
        }

        public int Kick()
        {
            throw new NotImplementedException();
        }

        public void RankUp(int currentLevel)
        {
            throw new NotImplementedException();
        }
    }
}
