using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class CompteBancaire
    {
        string nomTitulaire = "";
        float sold;

        public float Deposer(float sommeDepose)
        {
            return sold += sommeDepose;
        }

        public float Retirer(float sommeRetirer)
        {
            return sold -= sommeRetirer;
        }

    }
}
