using System;
using System.Collections.Generic;
using System.Text;
using TheFingerGame.Classes.Interfaces;

namespace TheFingerGame.Classes
{
    class Tortoise : IMoveSlow
    {
        public int Distance { get; set; }

        public void MoveSlow()
        {
            Random rand = new Random();
            int speed = rand.Next(2, 4);
            Distance = Distance - speed;
            Console.Write("The Tortoise powered forward.");
            Console.WriteLine(" Tortoise is " + Distance + " meters from the finish line.");
        }
    }
}
