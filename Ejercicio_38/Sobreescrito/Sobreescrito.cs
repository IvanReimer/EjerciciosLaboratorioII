﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescrito
{
    public class Sobreescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }
        public override bool Equals(object obj)
        {
            return typeof(Sobreescrito) == obj.GetType();
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }


    }
}
