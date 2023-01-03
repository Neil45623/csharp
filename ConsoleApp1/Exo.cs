using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exo
    {
        public Exo() { }
        public void Case()
        {
            Console.WriteLine("BASE ALGO \n");
            Console.WriteLine("1/ Determiner le plus grand des 2 nombres");
            Console.WriteLine("2/ Pass ou fail");
            Console.WriteLine("3/ Nombre aléatoire");
            Console.WriteLine("4/ Table de multiplication");
            Console.WriteLine("5/ Produit de deux nombres");
            Console.WriteLine("LOOPS ARRAY \n");
            Console.WriteLine("6/ Programme qui créé un tableau");
            Console.WriteLine("7/ programme qui demande à l'utilisateur d'entrer 10 nombres");
            Console.WriteLine("Enum \n");
            Console.WriteLine("8/ exo semaine");
            Console.WriteLine("9/ exo semaine");
            var choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    Exo1();
                    break;
                case 2:
                    Exo2();
                    break;
                case 3:
                    Exo3();
                    break;
                case 4:
                    Exo4();
                    break;
                case 5:
                    Exo5();
                    break;
                case 6:
                    Exo6();
                    break;
                case 7:
                    Exo7();
                    break;
                case 8:
                    Exo8();
                    break;
                case 9:
                    Exo9();
                    break;
            }
        }

        public void Exo1()
        {
            Console.WriteLine("Entrer un nombre");
            int PremierNombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer un second nombre");
            int SecondNombre = Convert.ToInt32(Console.ReadLine());

            if (PremierNombre > SecondNombre)
            {
                Console.WriteLine($"{PremierNombre} plus grand que {SecondNombre}");
            }
            else
            {
                Console.WriteLine($"{PremierNombre} plus petit que {SecondNombre}\n\n");
            }
            Case();
        }
        public void Exo2()
        {
            Console.WriteLine("Entrer votre note");
            int Note = Convert.ToInt32(Console.ReadLine());
            if (Note > 100)
            {
                Console.WriteLine("Tricheur c'est pas possible !");
            }
            else
            {
                if (Note >= 60)
                {
                    Console.WriteLine("PASS");
                }
                else
                {
                    Console.WriteLine("FAIL");
                }
            }
            Case();
        }
        public void Exo3()
        {
            Random aleatoire = new Random();
            int Nombrealeatoire = aleatoire.Next(101);

            Console.WriteLine("Entrer un nombre");
            var nombreentree = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (nombreentree != Nombrealeatoire)
                {
                    Console.WriteLine("Incorrect, try again.\n");
                    Console.WriteLine("Entrer un nombre\n");
                    nombreentree = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("Correct!\n");
                }
            }
            while (nombreentree != Nombrealeatoire);
            Console.WriteLine("Correct!\n");

            Case();

        }
        public void Exo4()
        {
            int j, n;
            Console.Write("Affichage de table de multiplication:\n");

            Console.Write("Ecrire le nombre : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= 12; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }

            Case();
        }
        public void Exo5()
        {
            Console.WriteLine("Entrer un nombre");
            var nombreentree1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrer un second nombre");
            var nombreentree2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (nombreentree1 * nombreentree2 > 1000) continue;
                Console.WriteLine("inférieur a 1000!\n");
                Console.WriteLine("Entrer un nombre");
                nombreentree1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrer un second nombre");
                nombreentree2 = Convert.ToInt32(Console.ReadLine());
            } while (nombreentree1 * nombreentree2 <= 1000);
            Console.WriteLine("Supérieur a 1000!\n");
            Case();
        }
        public void Exo6()
        {
            int[] array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var i in array)
            {
                Console.WriteLine(i);
                //Affichage du Tableau
            }


            Case();
        }

        public void Exo7()
        {

            Console.WriteLine("Entrer 10 nombres");
            int nombreentree1 = Convert.ToInt32(Console.ReadLine());
            int nombreentree2 = Convert.ToInt32(Console.ReadLine());
            int nombreentree3 = Convert.ToInt32(Console.ReadLine());
            int nombreentree4 = Convert.ToInt32(Console.ReadLine());
            int nombreentree5 = Convert.ToInt32(Console.ReadLine());
            int nombreentree6 = Convert.ToInt32(Console.ReadLine());
            int nombreentree7 = Convert.ToInt32(Console.ReadLine());
            int nombreentree8 = Convert.ToInt32(Console.ReadLine());
            int nombreentree9 = Convert.ToInt32(Console.ReadLine());
            int nombreentree10 = Convert.ToInt32(Console.ReadLine());
            int[] Tableau = new int[10] { nombreentree1, nombreentree2, nombreentree3, nombreentree4, nombreentree5, nombreentree6, nombreentree7, nombreentree8, nombreentree9, nombreentree10 };

            foreach (var i in Tableau)
            {
                Console.WriteLine(i);
                //Affichage du Tableau
            }
            Case();

        }
        enum JourSemaine
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        public void Exo8()
        {
            Console.WriteLine("Entrer un nombre entre 1 et 7");
            int nombreentree1 = Convert.ToInt32(Console.ReadLine());
            switch (nombreentree1)
            {
                case 1:
                    Console.WriteLine("Lundi");
                    break;
                case 2:
                    Console.WriteLine("Mardi");
                    break;
                case 3:
                    Console.WriteLine("Mercredi");
                    break;
                case 4:
                    Console.WriteLine("Jeudi");
                    break;
                case 5:
                    Console.WriteLine("Vendredi");
                    break;
                case 6:
                    Console.WriteLine("Samedi");
                    break;
                case 7:
                    Console.WriteLine("Dimanche");
                    break;
            }
            
        }
        public void Exo9()
        {
            const int Jour = 365;
            Console.WriteLine("Entrer votre age");
            int nombreentree1 = Convert.ToInt32(Console.ReadLine());

            int Jourvecu = nombreentree1 * Jour;
            Console.WriteLine($"Vous avez {Jourvecu}Jours");
        }
    }
}
