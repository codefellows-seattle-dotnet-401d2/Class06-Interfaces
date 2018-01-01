using System;
using System.Collections.Generic;
using System.Text;
using MortalKombatConsoleGame.Interfaces;

namespace MortalKombatConsoleGame.Classes
{
    public abstract class Player : IPlayer
    {
        public string CharacterName { get; set; }
        public int Health { get; set; }
        public int Rank { get; set; }
        public int DamagePerAttack { get; set; }
        public int Position { get; set; }

        public void Walk()
        {
            Position++;
        }

        public void Run()
        {
            Position += 2;
        }

        public void Eat()
        {
            Random random = new Random();
            Health += random.Next(0, 3);
        }
    }
}
