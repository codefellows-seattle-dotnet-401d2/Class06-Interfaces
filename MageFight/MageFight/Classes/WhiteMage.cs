using System;
using System.Collections.Generic;
using System.Text;
using MageFight.Interfaces;

namespace MageFight.Classes
{
    public class WhiteMage : Mage, IWhiteMagic
    {
        public WhiteMage()
        {
            HP = 100;
            MP = 100;
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
