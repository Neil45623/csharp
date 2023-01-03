using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Etudiant
    {
        string Nom = "";
        string prenom = "";
        int age;

        public string Saluer()
        {
           return $"Bonjour, je m'appelle {Nom} {prenom} et j'ai {age}";

        }
    }
}
