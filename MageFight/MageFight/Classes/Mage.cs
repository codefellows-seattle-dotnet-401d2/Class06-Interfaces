using System;
using System.Collections.Generic;
using System.Text;

namespace MageFight.Classes
{
    public abstract class Mage
    {
        internal string Name { get; set; }
        internal int HP { get; set; }
        internal int MP { get; set; }

        public abstract bool W_Attack(Mage enemy);
        public abstract bool M_Attack(int choice, Mage enemy);
    }
}
