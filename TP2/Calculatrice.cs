using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Calculatrice
    {
        int a;
        int b;
        public int Additionner()
        {
           return a += b;
        }

        public int Multiplier()
        {
            return a *= b;
        }
    }
}
