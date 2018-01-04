using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Classes;

namespace MageFight.Interfaces
{
    interface IBlackMagic
    {
        bool CastFire(Mage enemy);
        bool CastBizzara(Mage enemy);
        bool CastThundaga(Mage enemy);
    }
}
