using System;
using System.Collections.Generic;
using System.Text;

namespace TheFingerGame.Classes.Interfaces
{
    interface IMoveSlow
    {
        int Distance { get; set; }

        void MoveSlow();
    }
}

