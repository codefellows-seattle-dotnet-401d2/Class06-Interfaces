using System;
using System.Collections.Generic;
using System.Text;

namespace MageFight.Classes
{
    public abstract class Mage
    {
        protected int HP { get; set; }
        protected int MP { get; set; }

        public abstract void W_Attack();
        public abstract void M_Attack();
    }
}
