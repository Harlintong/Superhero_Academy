using System;
using System.Collections.Generic;
using System.Text;

namespace Superhero_Academy
{
    class Mage : Superhero
    {
        //Mages använder power stamina och speed för att kunna använda deras krafter
        private int magic;
        private int fire;
        private int ice;

        void Magic()
        {
            magic = Power * 3;
        }

        public void Spell()
        {
            fire = (magic + Intelligens) - ((Stamina + Speed) - 3);

            ice = (magic + Intelligens) - (Stamina - 2);
        }
    }
}
