using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    public class Nourriture
    {
        public Position nourriturePos = new Position();
        Random rdm = new Random();
        Canvas canvas = new Canvas();


        public Nourriture()
        {
            nourriturePos.x = rdm.Next(5, canvas.Widht);
            nourriturePos.y = rdm.Next(5, canvas.Height);
        }

        public void drawNourriture()
        {
            Console.SetCursorPosition(nourriturePos.x, nourriturePos.y);
            Console.Write("F");
        }

        public Position nourritureLocation()
        {
            return nourriturePos;
        }

        public void nourritureNexPos()
        {
            nourriturePos.x = rdm.Next(5, canvas.Widht);
            nourriturePos.y = rdm.Next(5, canvas.Height);
        }

    }
}
