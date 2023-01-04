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
                    Console.SetCursorPosition(90, 5);
                    Console.Write("Score : {0}", serpent.score);
                    serpent.Input();
                    nourriture.drawNourriture();
                    serpent.drawSerpent();
                    serpent.mouvementSerpent();
                    serpent.serpentMange(nourriture.nourritureLocation(), nourriture);
                    serpent.mourrir();
                    serpent.mur(canvas);
                }
                catch(SerpentException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Recommence (y/n)");
                    char c = char.Parse(Console.ReadLine());

                    switch (c)
                    {
                        case 'y':
                            serpent.x = 20;
                            serpent.y = 20;
                            serpent.score = 0;
                            serpent.serpentPosition.RemoveRange(0, serpent.serpentPosition.Count - 1);
                            break;
                        case 'n':
                            finished = true;
                            break;
                    }
                }
            }

        }
    }
}