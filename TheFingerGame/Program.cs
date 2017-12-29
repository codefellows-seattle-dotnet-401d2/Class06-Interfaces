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

            while (true)
            {

                //Instantiate contestants
                Cat Cat = new Cat();
                Cat.Distance = 25;

                Tortoise Tortoise = new Tortoise();
                Tortoise.Distance = 25;

                Hare Hare = new Hare();
                Hare.Distance = 25;

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

                    Cat.DecideSpeed();

                    Console.Read();
                    Console.Clear();
                    if (Cat.Distance <= 0)
                    {
                        Console.WriteLine("The Cat Wins!");
                        RaceInProgress = false;
                        break;
                    }

                    Tortoise.MoveSlow();

                    Console.Read();
                    Console.Clear();
                    if (Tortoise.Distance <= 0)
                    {
                        Console.WriteLine("The Tortoise Wins!");
                        RaceInProgress = false;
                        break;
                    }

                    Hare.MoveFast();

                    Console.Read();
                    Console.Clear();
                    if (Hare.Distance <= 0)
                    {
                        Console.WriteLine("The Hare Wins!");
                        RaceInProgress = false;
                        break;
                    }

                } // end race loop
                Console.Read();
                Console.Clear();

                Console.WriteLine("Press enter to play again.");
                Console.Read();
                Console.Clear();

            } //end game loop
        }
    }
}
