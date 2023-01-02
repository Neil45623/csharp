using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BasesAlgo
    {
        public BasesAlgo() { }
        public void Case()
        {
            Console.WriteLine("1/ Determiner le plus grand des 2 nombres");
            Console.WriteLine("2/ Pass ou fail");
            Console.WriteLine("3/ Nombre aléatoire");
            Console.WriteLine("4/ Table de multiplication");
            Console.WriteLine("4/ Produit de deux nombres");
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
            } else
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

        }
    }
}
