using System;
using System.Collections.Generic;
using System.Text;

namespace MortalKombatConsoleGame.Classes
{
    public abstract class Player
    {
        public int CharacterNumber { get; set; }
        public int Health { get; set; }
        public int Rank { get; set; }
    }
}
