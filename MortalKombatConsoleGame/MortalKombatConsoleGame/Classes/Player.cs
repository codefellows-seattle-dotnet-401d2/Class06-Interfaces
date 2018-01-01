using System;
using System.Collections.Generic;
using System.Text;
using MortalKombatConsoleGame.Interfaces;

namespace MortalKombatConsoleGame.Classes
{
    public abstract class Player : IPlayer
    {
        public int CharacterNumber { get; set; }
        public int Health { get; set; }
        public int Rank { get; set; }
        public void Walk()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public int Eat(int food)
        {
            throw new NotImplementedException();
        }
    }
}
