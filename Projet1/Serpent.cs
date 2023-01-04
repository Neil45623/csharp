using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    public class Serpent
    {
        List<Position> serpentPosition;

        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'z';
        char dir = 'u';

        public int x { get; set; }
        public int y { get; set; }


        public Serpent()
        {
            x = 20;
            y = 20;

            serpentPosition = new List<Position>();
            serpentPosition.Add(new Position(x, y));    
        }

        public void drawSerpent()
        {
            foreach(Position pos in serpentPosition)
            {
                Console.SetCursorPosition(pos.x, pos.y);
                Console.Write("▇");
            }


        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                key = keyInfo.KeyChar;
            }
        }

        private void direction()
        {
            if(key == 'z' && dir != 'd')
            {
                dir = 'u';
            }else if(key == 's' && dir != 'u')
            {
                dir = 'd';
            }else if(key == 'd' && dir != 'l')
            {
                dir = 'r';
            }
            else if (key == 'a' && dir != 'r')
            {
                dir = 'r';
            }
        }

        public void mouvementSerpent()
        {
            if(dir == 'u')
            {
                y--;
            }else if(dir == 'd')
            {
                y++;
            }
            else if (dir == 'r')
            {
                x++;
            }
            else if (dir == 'l')
            {
                x--;
            }
        }
    }
}
