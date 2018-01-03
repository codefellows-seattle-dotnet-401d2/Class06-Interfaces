using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Interfaces;

namespace MageFight.Classes
{
    public class RedMage : Mage, IBlackMagic, IWhiteMagic
    {
        public RedMage()
        {
            HP = 120;
            MP = 80;
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
