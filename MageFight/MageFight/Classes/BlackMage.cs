using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Interfaces;

namespace MageFight.Classes
{
    public class BlackMage : Mage, IBlackMagic
    {
        public BlackMage()
        {
            HP = 80;
            MP = 120;
        }

        public override void M_Attack()
        {
            throw new NotImplementedException();
        }

        public override void W_Attack()
        {
            throw new NotImplementedException();
        }
    }
}
