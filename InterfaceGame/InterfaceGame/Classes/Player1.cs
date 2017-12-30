using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceGame.Classes
{
    public class Player1 
    {
        public string Name;
        public int Health;
        public int DamagePerAttack;

        public Player1(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }

    }

}
