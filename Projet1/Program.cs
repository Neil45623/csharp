using System;

namespace Projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            Canvas canvas = new Canvas();
            Serpent serpent = new Serpent();
            Nourriture nourriture = new Nourriture();

            Console.WriteLine(" \t\t\t\t PRESS ENTER");
            Console.Read();

            while (!finished)
            {
                try
                {
                    canvas.drawCanvas();
                    serpent.Input();
                    nourriture.drawNourriture();
                    serpent.drawSerpent();
                    serpent.mouvementSerpent();
                    serpent.serpentMange(nourriture.nourritureLocation(), nourriture);
                    serpent.mourrir();
                }
                catch(SerpentException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}