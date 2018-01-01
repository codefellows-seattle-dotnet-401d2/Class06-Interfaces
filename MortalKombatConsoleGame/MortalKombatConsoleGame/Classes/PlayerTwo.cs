using System;
using System.Collections.Generic;
using System.Text;
using MortalKombatConsoleGame.Interfaces;

namespace MortalKombatConsoleGame.Classes
{
    public class PlayerTwo : Player, IDefender
    {
        public int DamageWhenCover = 1;
        public bool CoverOn;

        public void TakeCover()
        {
            DamagePerAttack = DamageWhenCover;
            CoverOn = !CoverOn;
        }

        public void Hurt(int attackType)
        {
            if (attackType == 1)
            {
                Health -= DamagePerAttack;
            }
            else
            {
                Health -= DamagePerAttack * 2;
            }
        }
    }
}
