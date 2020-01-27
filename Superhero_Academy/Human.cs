using System;
using System.Collections.Generic;
using System.Text;

namespace Superhero_Academy
{
    class Human : Superhero
    {
        //Human kan skapa eller fixa saker, det behöver intelligens och stamina
        int fix;

        void Fixer()
        {
            fix = (Stamina - 2) + Intelligens;
        }
    }
}
