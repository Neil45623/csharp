using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class CompteBancaire
    {
        string nomTitulaire = "";
        float sold;

        public void Deposer(float sommeDepose)
        {
            return sold += sommeDepose;
        }

        public void Retirer(float sommeRetirer)
        {
            return sold -= sommeRetirer;
        }

    }
}
