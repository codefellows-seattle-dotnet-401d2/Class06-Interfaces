using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Classes;

namespace MageFight.Interfaces
{
    interface IWhiteMagic
    {
        void CastCure();
        void CastReflect();
        bool CastHoly(Mage enemy);
    }
}
