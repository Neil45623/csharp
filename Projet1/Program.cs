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

            Console.WriteLine(" \t\t\t\t PRESS ENTER");
            Console.Read();

            while (!finished)
            {
                canvas.drawCanvas();
                serpent.Input();
                serpent.drawSerpent();
                serpent.mouvementSerpent();
            }

        }
    }
}