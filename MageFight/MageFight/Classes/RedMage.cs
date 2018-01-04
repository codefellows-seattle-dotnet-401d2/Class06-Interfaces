using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Interfaces;

namespace MageFight.Classes
{
    public class RedMage : Mage, IBlackMagic, IWhiteMagic
    {
        public RedMage()
        {
            Name = "Red Mage";
            HP = 120;
            MP = 80;
        }

        public bool CastBizzara(Mage enemy)
        {
            enemy.HP -= 20;
            MP -= 18;
            Console.WriteLine("Attacked " + enemy.Name + " with blizzara for 20 points of damage! " + enemy.Name + " Health: " + enemy.HP);
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
            if (enemy.HP > 0) return true;
            else return false;
        }

        public void CastCure()
        {
            HP += 35;
            MP -= 36;
            Console.WriteLine(Name + " cast cure. Health restored by 35 HP.");
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
        }

        public bool CastFire(Mage enemy)
        {
            enemy.HP -= 10;
            MP -= 6;
            Console.WriteLine("Attacked " + enemy.Name + " with fire for 10 points of damage! " + enemy.Name + " Health: " + enemy.HP);
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
            if (enemy.HP > 0) return true;
            else return false;
        }

        public bool CastHoly(Mage enemy)
        {
            enemy.HP -= 20;
            HP += 15;
            MP -= 48;
            Console.WriteLine("Attacked " + enemy.Name + " with holy for 20 points of damage and " + Name + " restored 15 HP! " + enemy.Name + " Health: " + enemy.HP);
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
            if (enemy.HP > 0) return true;
            else return false;
        }

        public void CastReflect()
        {
            MP -= 18;
            Console.WriteLine("Cast Reflect. " + Name + " reflects damage for 1 turn.");
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
        }

        public bool CastThundaga(Mage enemy)
        {
            enemy.HP -= 30;
            MP -= 48;
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
                    CastCure();
                    break;
                case 4:
                    continueGame = CastFire(enemy);
                    break;
                case 5:
                    continueGame = CastHoly(enemy);
                    break;
                case 6:
                    CastReflect();
                    break;
                case 7:
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
            enemy.HP -= 8;
            MP += 10;
            Console.WriteLine("Attacked " + enemy.Name + " with a long sword for 8 points of damage! " + Name + " restored 10 MP.");
            Console.WriteLine("Enemy " + enemy.Name + " health: " + enemy.HP);
            Console.WriteLine(Name + " Health: " + HP + " MP: " + MP);
            if (enemy.HP > 0) return true;
            else return false;
        }
    }
}
