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

            while (!finished)
            {
                canvas.drawCanvas();
                serpent.drawSerpent(); 
                Console.Read();
            }

        }
    }
}