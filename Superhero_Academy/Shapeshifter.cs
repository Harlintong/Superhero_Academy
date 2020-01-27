using System;
using System.Collections.Generic;
using System.Text;

namespace Superhero_Academy
{
    class Shapeshifter : Superhero
    {
        int formChange;

        void Shapeshift()
        {
            formChange = Stamina - 2;
        }
    }
}
