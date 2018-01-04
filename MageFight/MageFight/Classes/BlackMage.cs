using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Interfaces;

namespace MageFight.Classes
{
    public class BlackMage : Mage, IBlackMagic
    {
        public BlackMage()
        {
            Name = "Black Mage";
            HP = 80;
            MP = 120;
        }

        public bool CastBizzara(Mage enemy)
        {
            enemy.HP -= 20;
            MP -= 15;
            Console.WriteLine("Attacked " + enemy.Name + " with blizzara for 20 points of damage! " + enemy.Name + " Health: " + enemy.HP);
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
            if (enemy.HP > 0) return true;
            else return false;
        }

        public bool CastFire(Mage enemy)
        {
            enemy.HP -= 10;
            MP -= 5;
            Console.WriteLine("Attacked " + enemy.Name + " with fire for 10 points of damage! " + enemy.Name + " Health: " + enemy.HP);
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
            if (enemy.HP > 0) return true;
            else return false;
        }

        public bool CastThundaga(Mage enemy)
        {
            enemy.HP -= 30;
            MP -= 40;
            Console.WriteLine("Attacked " + enemy.Name + " with thunder for 30 points of damage! " + enemy.Name + " Health: " + enemy.HP);
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
            if (enemy.HP > 0) return true;
            else return false;
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
                    continueGame = CastBizzara(enemy);
                    break;
                case 3:
                    continueGame = CastFire(enemy);
                    break;
                case 4:
                    continueGame = CastThundaga(enemy);
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
            MP += 10;
            Console.WriteLine("Attacked " + enemy.Name + " with a staff for 4 points of damage! " + Name + " restored 10 MP.");
            Console.WriteLine("Enemy " + enemy.Name + " health: " + enemy.HP);
            if (enemy.HP > 0) return true;
            else return false;
        }
    }
}
