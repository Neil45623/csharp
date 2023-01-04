using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    public class Serpent
    {

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';

        public int x { get; set; }
        public int y { get; set; }


        public Serpent()
        {
            x = 20;
            y = 20;
        }

        public void drawSerpent()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("▇");

        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                key = keyInfo.KeyChar;
            }
        }
    }
}
