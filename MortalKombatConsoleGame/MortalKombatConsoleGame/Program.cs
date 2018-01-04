using System;
using System.Linq;
using System.Text;
using MortalKombatConsoleGame.Classes;

namespace MortalKombatConsoleGame
{
    class Program
    {
        /// <summary>
        /// Main entry point for the console Application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to the simplest Mortal Kombat " +
                              "\n\n This Game is just a demonstration for OOP Interfaces " +
                              "\n Player One is always the attacker and player two will always lose!" +
                              "\n ----------------- To start Playing Press Enter -------------------");
            Console.ReadLine();

            // Launching the game
            StartGame();
        }

        // This method will start the game by calling the Create Players method
        public static void StartGame()
        {
            // Returns true when the user want to keep playing
            bool gameOn = true;
            while (gameOn)
            {
                gameOn = CreatePlayers();
            }

            Console.WriteLine(" Thanks for playing...");
            Console.ReadLine();
            Console.WriteLine(" Press enter to leave.");
        }

        /// <summary>
        /// Create new players and launch the Fighting method
        /// </summary>
        /// <returns>Returns True if the player wants to continue playing</returns>
        public static bool CreatePlayers()
        {
            Console.WriteLine(" Enter the first Character/Player Name ");
            string nameOne = Console.ReadLine();

            Console.WriteLine(" Enter the first player Damage per attack points from 1 - 10 ");
            string damagePlayerOne = Console.ReadLine();
            int damageIntOne = int.Parse(damagePlayerOne);

            // Making a new instance of Player one
            PlayerOne playerOne = new PlayerOne(nameOne, damageIntOne);

            Console.WriteLine(" Enter the second Character/Player Name ");
            string nameTwo = Console.ReadLine();

            // Making a new instance of Player two
            PlayerTwo playerTwo = new PlayerTwo(nameTwo);

            StartFighting(playerOne, playerTwo);

            // After the round is finished this will execute to ask the user to play again
            Console.WriteLine(" Do you want to start a new fight? Type 'Y' for Yes or 'N' for No");
            string keepFighting = Console.ReadLine();
            char keepFightingChar = char.Parse(keepFighting);

            bool fightOn;
            fightOn = char.ToUpper(keepFightingChar) == 'Y';

            return fightOn;
        }

        /// <summary>
        /// Start fighting when both players are ready. Instructions will be given to fight and move players on the screen
        /// </summary>
        /// <param name="playerOne">PlayerOne class that implements IPlayer, IAttacker, IBadge interfaces</param>
        /// <param name="playerTwo">PlayerTwo class that implements IPlayer, IDefender interfaces</param>
        public static void StartFighting(PlayerOne playerOne, PlayerTwo playerTwo)
        {
            Console.WriteLine("\n Keyboard controller  A: Punch, S: Kick, E: Eat, K: Take Cover, Right Arrow: Walk, Up Arrow: Run \n");
            while (playerTwo.Health > 0)
            {
                // Building a string to show the progress of the fight on an underscored line '_'
                string firstPart = $"{playerOne.CharacterName} (Rank: {playerOne.Rank}) FIGHTING STAGE[";
                StringBuilder fightingStage = new StringBuilder("________________________________");
                string secondPart = $"] :{playerTwo.CharacterName}'s Health is {playerTwo.Health}";

                // When moving and fighting, the underscores are replaced with Players initials
                fightingStage[playerOne.Position] = playerOne.CharacterName.First();
                fightingStage[playerTwo.Position] = playerTwo.CharacterName.First();

                // Checking if player one has made it to the end of the line. Checking last or before last underscore of the stage are occupied to end the game
                if (fightingStage[fightingStage.Length - 1] != '_' || fightingStage[fightingStage.Length - 2] != '_') break;

                Console.WriteLine(firstPart + fightingStage + secondPart);

                // Reading user's keyboard click
                ConsoleKey key = Console.ReadKey().Key;

                // Cases for user input, each with different action
                switch (key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("\n\n Punch BOOM!!! ");
                        playerOne.Punch(playerTwo);
                        playerOne.Walk();
                        playerTwo.Walk();
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("\n\n Kick YEAO!!! ");
                        playerOne.Kick(playerTwo);
                        playerOne.Walk();
                        playerTwo.Walk();
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("\n\n Yum yum :) You can't kill me that easy");
                        playerTwo.Eat();
                        break;
                    case ConsoleKey.K:
                        Console.WriteLine($"\n\n {playerTwo.CharacterName} is now under cover!");
                        playerTwo.TakeCoverFrom(playerOne);
                        break;
                    case ConsoleKey.RightArrow:
                        if (fightingStage[fightingStage.Length - 1] == '_')
                        {
                            playerOne.Walk();
                            playerTwo.Walk();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        playerOne.Run();
                        playerTwo.Run();
                        break;
                }
            }

            // Game is finished. Rank up the first player and declare them as the winner!
            playerOne.Rank = playerOne.RankUp(playerOne.Rank);
            Console.WriteLine($"\n {playerOne.CharacterName} is the WINNER! Rank upgraded to {playerOne.Rank}\n");
        }
    }
}
