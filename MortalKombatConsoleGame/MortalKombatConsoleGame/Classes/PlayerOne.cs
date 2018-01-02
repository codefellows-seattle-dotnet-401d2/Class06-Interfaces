using System;
using System.Collections.Generic;
using System.Text;
using MortalKombatConsoleGame.Interfaces;

namespace MortalKombatConsoleGame.Classes
{
    class PlayerOne : Player, IAttacker, IBadge
    {
        public PlayerOne(string characterName, int damagePerAttack)
        {
            Health = 50;
            Rank = 1;
            Position = 0;
            CharacterName = characterName;
            DamagePerAttack = damagePerAttack;
        }

        public void Punch(Player player)
        {
            player.Health -= DamagePerAttack / 2;
        }

        public void Kick(Player player)
        {
            player.Health -= DamagePerAttack;
        }

        public int RankUp(int numberOfWins)
        {
            Rank = numberOfWins;
            return Rank;
        }
    }
}
