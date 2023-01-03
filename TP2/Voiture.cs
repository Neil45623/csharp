using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Voiture
    {
        string marque = "Renault";
        string modèle = "Clio 3";
        int nbPorte = 5;
        string Couleur = "jaune";

        public void Description()
        {
            Console.WriteLine($"La voiture est une {marque} {modele} avec {nbPorte} portes de couleur {Couleur}");
        }
    }
}
