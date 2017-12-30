using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGame.Classes
{
    public class Player2 
    {
        public string Name;
        public int Health;
        public int DamagePerAttack;

        public Player2(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}
