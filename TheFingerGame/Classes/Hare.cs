using System;
using System.Collections.Generic;
using System.Text;
using TheFingerGame.Classes.Interfaces;

namespace TheFingerGame.Classes
{
    public class Hare : IMoveFast
    {
        public int Distance { get; set; }

        public void MoveFast()
        {
            Random rand = new Random();
            int speed = rand.Next(2, 6);
            Distance = Distance - speed;
            Console.Write("The Hare flailed wildly.");
            Console.WriteLine(" Hare is " + Distance + " meters from the finish line.");
        }
    }
}
