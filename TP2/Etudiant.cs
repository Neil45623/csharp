using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Etudiant
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }

        public Etudiant(string nom, string prenom, int age)
        {
            nom = nom;
            this.prenom = prenom;
            this.age = age;
        }
        public bool EstMajeur()
        {
            return age >= 18;
        }

        public string NomComplet()
        {
            return prenom + " " + nom;
        }

        public string Saluer()
        {
           return $"Bonjour, je m'appelle {Nom} {prenom} et j'ai {age}";

        }
    }
}
