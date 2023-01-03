using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using TP2;

namespace Formation 
{
    public class Formation
{
    // liste d'étudiants de la formation
    public List<Etudiant?> etudiants { get; set; }

    // constructeur de la classe
    public Formation()
    {
        etudiants = new List<Etudiant?>();
    }

    // méthode qui calcule la moyenne d'âge des étudiants de la formation
    public double MoyenneAge()
    {
        var somme = etudiants.Aggregate<Etudiant?, double>(0, (current, etudiant) => current + etudiant.age);

        return somme / etudiants.Count;
    }

    // méthode de recherche qui retourne l'objet Etudiant correspondant au nom donné
    // ou null s'il n'est pas trouvé dans la liste
    public Etudiant? TrouverEtudiant(string nom)
    {
        return etudiants.FirstOrDefault(etudiant => etudiant?.nom == nom);
    }

    // surcharge de la méthode de recherche qui retourne l'objet Etudiant correspondant au nom et au prénom donnés
    // ou null s'il n'est pas trouvé dans la liste
    public Etudiant? TrouverEtudiant(string nom, string prenom)
    {
        return etudiants.FirstOrDefault(etudiant => etudiant?.nom == nom && etudiant.prenom == prenom);
    }
}