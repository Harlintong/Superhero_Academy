using System;
using System.Collections.Generic;
using System.Text;

namespace Superhero_Academy
{
    class Shapeshifter : Superhero
    {
        //shapeshifter behöver stamina för att ändra form
        int formChange;

        void Shapeshift()
        {
            formChange = Stamina - 2;
        }
    }
}
