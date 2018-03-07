using System;
using TheFingerGame.Classes;

namespace TheFingerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Great Race, this time joining us is the Cat!");
            Console.Read();
            Console.Clear();

            runGame();
            
        } //main class

        public static void runGame()
        {
            bool gameRunning = true;

            while (gameRunning)
            {

                //Instantiate contestants
                Cat cat = new Cat();
                cat.Distance = 25;

                Tortoise tortoise = new Tortoise();
                tortoise.Distance = 25;

                Hare hare = new Hare();
                hare.Distance = 25;

                Console.WriteLine("The contestants are ready, press Enter to fire off the starting pistol and start the race!");
                Console.Read();
                Console.Clear();


                System.Threading.Thread.Sleep(500);
                Console.WriteLine("BANG!");
                System.Threading.Thread.Sleep(500);
                Console.Clear();
                System.Threading.Thread.Sleep(500);

                bool RaceInProgress = true;

                while (RaceInProgress)
                {

                    RaceInProgress = raceSegment(cat, tortoise, hare, RaceInProgress);

                } // end race loop
                Console.Read();
                Console.Clear();

                Console.WriteLine("Press enter to play again.");
                Console.Read();
                Console.Clear();

            } //end game loop
        } //end game method

        public static bool raceSegment(Cat cat, Tortoise tortoise, Hare hare, bool RaceInProgress)
        {
            cat.DecideSpeed();

            Console.Read();
            Console.Clear();
            if (cat.Distance <= 0)
            {
                Console.WriteLine("The Cat Wins!");
                RaceInProgress = false;
                return RaceInProgress;
            }

            tortoise.MoveSlow();

            Console.Read();
            Console.Clear();
            if (tortoise.Distance <= 0)
            {
                Console.WriteLine("The Tortoise Wins!");
                RaceInProgress = false;
                return RaceInProgress;
            }

            hare.MoveFast();

            Console.Read();
            Console.Clear();
            if (hare.Distance <= 0)
            {
                Console.WriteLine("The Hare Wins!");
                RaceInProgress = false;
                return RaceInProgress;
            }

            return RaceInProgress;
        } //End of game turn method
    }
}
