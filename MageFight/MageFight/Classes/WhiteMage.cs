using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Interfaces;

namespace MageFight.Classes
{
    public class WhiteMage : Mage, IWhiteMagic
    {
        public WhiteMage()
        {
            Name = "White Mage";
            HP = 100;
            MP = 100;
        }

        public void CastCure()
        {
            HP += 35;
            MP -= 30;
            Console.WriteLine(Name + " cast cure. Health restored by 35 HP.");
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
        }

        public bool CastHoly(Mage enemy)
        {
            enemy.HP -= 20;
            HP += 15;
            MP -= 40;
            Console.WriteLine("Attacked " + enemy.Name + " with holy for 20 points of damage and " + Name + " restored 15 HP! " + enemy.Name + " Health: " + enemy.HP);
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
            if (enemy.HP > 0) return true;
            else return false;
        }

        public void CastReflect()
        {
            MP -= 15;
            Console.WriteLine("Cast Reflect. " + Name + " reflects damage for 1 turn.");
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
        }

        /// <summary>
        /// Used to handle casting specific mage spells since I am not able to call methods from an interface on a generic mage class.
        /// </summary>
        /// <param name="choice">Spell method to use</param>
        /// <param name="enemy">Mage instance to pass into spell method</param>
        /// <returns>true if enemy HP is still > 0</returns>
        public override bool M_Attack(int choice, Mage enemy)
        {
            bool continueGame = true;
            switch (choice)
            {
                case 2:
                    CastCure();
                    break;
                case 3:
                    continueGame = CastHoly(enemy);
                    break;
                case 4:
                    CastReflect();
                    break;
                default:
                    Console.WriteLine("Failed to cast spell...");
                    break;
            }
            return continueGame;
        }

        public override bool W_Attack(Mage enemy)
        {
            enemy.HP -= 4;
            Console.WriteLine("Attacked " + enemy.Name + " with a staff for 4 points of damage! " + Name + " restored 10 MP.");
            Console.WriteLine("Enemy " + enemy.Name + " health: " + enemy.HP);
            if (enemy.HP > 0) return true;
            else return false;
        }
    }
}
