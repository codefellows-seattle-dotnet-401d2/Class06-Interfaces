using System;
using System.Collections.Generic;
using System.Text;

// Implement Inheritance Player1 v Player 2 classes
// start with outside of classes program.cs (using.InterfaceGame.Classes)
// players are classes
// instantiate objects in Main

namespace InterfaceGame.Classes
{
    public class Game
    {

        static void Main(string[] args)
        {
            // these should be Player1 and Player2 Objects from the CLASSES
            Player1 player1 = new Player1("Player1", 20, 5);
            Player2 player2 = new Player2("Player2", 20, 5);
            //Fighter player1 = new Fighter("Player1", 20, 5);
            //Fighter player2 = new Fighter("Player2", 25, 3);

            string Winner = DeclareWinner(player1, player2, "Player1");

            Console.WriteLine(Winner + " is the winner!");
            Console.ReadLine();
        }

        public static string DeclareWinner(Player1 fighter1, Player2 fighter2, string firstAttacker)
        {

            // while fighters health is greater than 0, keep attacking
            while (fighter1.Health > 0 && fighter2.Health > 0)
            {
                // subtracting damage from opponents health
                if (firstAttacker == fighter1.Name)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                }
                else
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                }

                // determining who's turn it is by alternating firstAttacker's value
                if (firstAttacker == fighter2.Name)
                {
                    firstAttacker = fighter1.Name;
                }
                else
                {
                    firstAttacker = fighter2.Name;
                }
            }

            // when fighter1's health is depleted, return opponents name; else return winner
            if (fighter1.Health <= 0)
            {
                return fighter2.Name;
            }
            else
            {
                return fighter1.Name;
            }

        }
    }
}
