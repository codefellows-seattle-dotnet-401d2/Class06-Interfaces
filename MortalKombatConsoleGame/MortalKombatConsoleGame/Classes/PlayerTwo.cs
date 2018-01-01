using System;
using System.Collections.Generic;
using System.Text;
using MortalKombatConsoleGame.Interfaces;

namespace MortalKombatConsoleGame.Classes
{
    public class PlayerTwo : Player, IDefender
    {
        private int DamageWhenCover = 2;
        private int DamageWhenHurt = 10;

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
