using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Etudiant
    {
        public string Nom = "";
        public string prenom = "";
        public int age;

        public Etudiant(string nom, string prenom, int age)
        {
            Nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        public string Saluer()
        {
           return $"Bonjour, je m'appelle {Nom} {prenom} et j'ai {age}";

        }

        public void Retourner()
        {
            Console.WriteLine($"{prenom} {Nom}");
        }
    }
}
