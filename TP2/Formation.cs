using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace Formation
{
    class Etudiant
    {
        public string Nom { get; set; }
        public int Age { get; set; }
    }

    class Formation
    {
        public List<Etudiant> Etudiants { get; set; }

        public Formation()
        {
            Etudiants = new List<Etudiant>();
        }

        public double CalculerMoyenneAge()
        {
            int totalAge = 0;
            foreach (Etudiant etudiant in Etudiants)
            {
                totalAge += etudiant.Age;
            }
            return (double)totalAge / Etudiants.Count;
        }
    }
}
