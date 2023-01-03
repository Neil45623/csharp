using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Etudiant
    {
        string Nom = "ROCHE";
        string prenom = "Neil";
        int age = 20;

        public void Saluer()
        {
            Console.WriteLine($"Bonjour, je m'appelle {Nom} {prenom} et j'ai {age}");

        }
    }
}
