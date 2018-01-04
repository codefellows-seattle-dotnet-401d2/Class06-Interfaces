using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Classes;
using MageFight.Interfaces;

namespace MageFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            Console.WriteLine("Program starting...\n");

            // Will continue to display the menu options until Exit is selected
            do
            {
                option = MainMenu();
                if (option == "4") continue;
            } while (option != "4");

            Console.Write("\nProgram terminating... press Enter to exit...");
            Console.ReadLine();
        }

        /// <summary>
        /// Displays menu options to choose a character. Starts game with chosen character and random enemy character.
        /// </summary>
        /// <returns>Will exit method with option chosen. "4" will exit the app.</returns>
        private static string MainMenu()
        {
            Console.Write(
                "Welcome to Mage Fight! Pick a Mage to battle with:" +
                "\n1. White Mage" +
                "\n2. Black Mage" +
                "\n3. Red Mage" +
                "\n4. Exit Game" +
                "\nEnter selection: "
                );
            string userInput = Console.ReadLine();
            bool isValidInput = true;

            switch (userInput)
            {
                case "1":
                    PlayGame(new WhiteMage(), GetEnemy());
                    break;
                case "2":
                    PlayGame(new BlackMage(), GetEnemy());
                    break;
                case "3":
                    PlayGame(new RedMage(), GetEnemy());
                    break;
                case "4":
                    break;
                default:
                    isValidInput = false;
                    Console.WriteLine("Input not valid! Try again.");
                    break;
            }
            // Will display main menu again if user did not select a proper menu item.
            return (isValidInput) ? userInput : MainMenu();
        }

        /// <summary>
        /// Main loop of the game. Displays available input options, will call appropriate attack method which returns a bool used to determine if this main loop should continue.
        /// </summary>
        /// <param name="player">player executing the move</param>
        /// <param name="enemy">player being attacked</param>
        private static void PlayGame(Mage player, Mage enemy)
        {
            bool continueGame = true;
            do
            {
                Console.Write(
                    "Choose Attack!:" +
                    "\n White Mage attack selection: 1. Weapon  2. Cure  3. Holy  4. Reflect" +
                    "\n Black Mage attack selection: 1. Weapon  2. Blizzara  3. Fire  4. Thundaga" +
                    "\n Red Mage attack selection: 1. Weapon  2. Blizzara  3. Cure  4. Fire  5. Holy  6. Reflect  7. Thundaga" +
                    "\nEnter selection: "
                    );
                string userInput = Console.ReadLine();
                Console.WriteLine("");
                switch (userInput)
                {
                    case "1":
                        continueGame = player.W_Attack(enemy);
                        break;
                    case "2":
                        continueGame = player.M_Attack(2, enemy);
                        break;
                    case "3":
                        continueGame = player.M_Attack(3, enemy);
                        break;
                    case "4":
                        continueGame = player.M_Attack(4, enemy);
                        break;
                    case "5":
                        continueGame = player.M_Attack(5, enemy);
                        break;
                    case "6":
                        continueGame = player.M_Attack(6, enemy);
                        break;
                    case "7":
                        continueGame = player.M_Attack(7, enemy);
                        break;
                    default:
                        Console.WriteLine("Input not valid! Try again.");
                        break;
                }
            } while (continueGame);
        }

        /// <summary>
        /// Used to choose an enemy at random.
        /// </summary>
        /// <returns>random Mage instance</returns>
        private static Mage GetEnemy()
        {
            Random r = new Random();
            int rEnemy = r.Next(0, 3);
            if (rEnemy == 0)
            {
                Console.WriteLine("You are fighting a White Mage!");
                return new WhiteMage();
            }
            else if (rEnemy == 1)
            {
                Console.WriteLine("You are fighting a Black Mage!");
                return new BlackMage();
            }
            else
            {
                Console.WriteLine("You are fighting a Red Mage!");
                return new RedMage();
            }
        }
    }
}
