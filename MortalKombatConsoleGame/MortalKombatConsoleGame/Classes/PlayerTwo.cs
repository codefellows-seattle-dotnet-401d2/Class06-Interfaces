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

        public PlayerTwo(string characterName)
        {
            Health = 50;
            Position = 2;
            CoverOn = false;
            CharacterName = characterName;
        }

        public void TakeCoverFrom(Player playerOne)
        {
            playerOne.DamagePerAttack = DamageWhenCover;
            CoverOn = !CoverOn;
        }
    }
}
