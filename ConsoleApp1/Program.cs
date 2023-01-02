using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Tablix
//    {
//        public static void Main(string[] args)
//        {
            /*
            int[,] Tableau = new int[1, 2];
            int[,,] TableauB = new int[5, 2, 3];

            foreach (var i in Tableau)
            {
                Console.WriteLine(i);
                //Affichage du Tableau
            }
            foreach (var i in TableauB)
            {
                Console.WriteLine(i);
                //Affichage du TableauB
            }

            // Console.WriteLine(Tableau);
            // Console.WriteLine(TableauB);
            
            int[][] Tableau3 = new int[3][];
            Tableau3[0] = new int[] { 45, 2 };
            Tableau3[1] = new int[] { 34, 34, 4, 67 };

            foreach (var i in Tableau3[0])
            {
                Console.WriteLine(i);
                //Affichage du Tableau3[0]
            }
            foreach (var i in Tableau3[1])
            {
                Console.WriteLine(i);
                //Affichage du Tableau3[1]
//            }
//            */
            
//        }
//    }
//}

/*
enum JourSemaine
{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
}
class Program
{
    public static void Main()
    {
        JourSemaine Aujourdhui = JourSemaine.Lundi;
        JourSemaine AujourdhuiB = 0;
        

        Console.WriteLine(Aujourdhui);
        Console.WriteLine(AujourdhuiB);

        JourSemaine WeekEnd = JourSemaine.Samedi | JourSemaine.Dimanche;

        Console.WriteLine(WeekEnd);

        -------------------------------------------------------------------
        int[] Tableau;
        Tableau = new int[10];
        
        int[,] Tableau = new int[1, 2];
        int[,,] Tableau = new int[5, 2, 3];

        int[][] Tableau = new int[3][];
        Tableau[0] = new int[] { 45, 2 };
        Tableau[1] = new int[] { 34, 34, 4, 67 };
        
        }
    }
*/

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Exo Case = new();
            Case.Case();
        }
    }
}