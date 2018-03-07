using System;
using System.Collections.Generic;
using System.Text;

namespace TheFingerGame.Classes.Interfaces
{
    interface IMoveFast
    {
        int Distance { get; set; }

        void MoveFast();
    }
}
