﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Superhero_Academy
{
    class Mutant : Superhero
    {
        //Mutanter blir starkare men långsammare
        private int MutantStrength;
        private int MutantSpeed;

        void MutantTranform()
        {
            MutantStrength = Strength * 5;

            MutantSpeed = Speed / 2;
        }
    }
}
