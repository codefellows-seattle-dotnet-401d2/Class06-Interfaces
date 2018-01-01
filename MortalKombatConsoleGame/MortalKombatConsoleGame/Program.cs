using System;
using MortalKombatConsoleGame.Classes;

namespace MortalKombatConsoleGame
{
    class Program
    {
        /// <summary>
        /// Main entry point for the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to the simplest Mortal Kombat " +
                              "\n\n This Game is just a demonstration for OOP Interfaces " +
                              "\n Player One is always the attacker and player two will always lose!" +
                              "\n ----------------- To start Playing Press Enter -------------------");
            Console.Read();

            StartGame();
        }

        public static void StartGame()
        {
            bool gameOn = true;
            while (gameOn)
            {
                gameOn = CreatePlayers();
            }
        }

        public static bool CreatePlayers()
        {
            Console.WriteLine(" Enter the first Character/Player Name ");
            string nameOne = Console.ReadLine();

            Console.WriteLine(" Enter the first player Damage per attack points from 1 - 10 ");
            string damagePlayerOne = Console.ReadLine();
            int damageIntOne = int.Parse(damagePlayerOne);

            PlayerOne playerOne = new PlayerOne(nameOne, damageIntOne);

            Console.WriteLine(" Enter the second Character/Player Name ");
            string nameTwo = Console.ReadLine();

            PlayerTwo playerTwo = new PlayerTwo(nameTwo);

            Console.WriteLine(" Do you want to keep fighting? Type 'Y' for Yes or 'N' for No");
            string keepFighting = Console.ReadLine();
            char keepFightingChar = char.Parse(keepFighting);

            bool fightOn;
            fightOn = char.ToUpper(keepFightingChar) == 'Y';

            return fightOn;
        }
    }
}
