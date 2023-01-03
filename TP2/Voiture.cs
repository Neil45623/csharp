using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Voiture
    {
        string marque = "";
        string modèle = "";
        int nbPorte = "";
        string Couleur = "";

        public string Description()
        {
            return $"La voiture est une {marque} {modele} avec {nbPorte} portes de couleur {Couleur}";
        }
    }
}
