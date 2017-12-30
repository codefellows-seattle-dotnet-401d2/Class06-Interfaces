using System;
using System.Collections.Generic;
using System.Text;
using TheFingerGame.Classes.Interfaces;

namespace TheFingerGame.Classes
{

    class Cat : IMoveFast, IMoveSlow
    {
        public int Distance { get; set; }

        public void DecideSpeed()
        {
            Random rand = new Random();
            int laziness = rand.Next(0, 3);
            switch (laziness)
            {
                case 0:
                    MoveFast();
                    break;
                case 1:
                    MoveSlow();
                    break;
                case 2:
                    Console.Write("The Cat took a nap.");
                    break;
            }
            Console.WriteLine(" Cat is " + Distance + " meters from the finish line.");
        }

        public void MoveFast()
        {
            Random rand = new Random();
            int speed = rand.Next(3, 6);
            Distance = Distance - speed;
            Console.WriteLine("The Cat chased a bug for a bit.");
        }

        public void MoveSlow()
        {
            Random rand = new Random();
            int speed = rand.Next(1, 4);
            Distance = Distance - speed;
            Console.WriteLine("The Cat wandered towards the finishline.");
        }
    }
}
