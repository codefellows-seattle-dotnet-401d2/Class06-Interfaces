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

        public PlayerTwo(int characterNumber)
        {
            Health = 50;
            CoverOn = false;
            CharacterNumber = characterNumber;
        }

        public void TakeCover()
        {
            DamagePerAttack = DamageWhenCover;
            CoverOn = !CoverOn;
        }

        public void Hurt(int attackType)
        {
            Health -= attackType == 1 ? DamagePerAttack : DamagePerAttack * 2;
        }
    }
}
