using System;

namespace MortalKombatConsoleGame
{
    class Program
    {
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
                gameOn = StartFight();
            }
        }

        public static bool StartFight()
        {
            
        }
    }
}
