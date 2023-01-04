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
                Console.Write("▐");
            }


        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
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
            else if (key == 'q' && dir != 'r')
            {
                dir = 'l';
            }
        }

        public void mouvementSerpent()
        {
            direction();
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
            
            serpentPosition.Add(new Position(x, y));
            serpentPosition.RemoveAt(0);
            Thread.Sleep(100);

        }

        public void serpentMange(Position Nourriture, Nourriture F)
        {
            Position serpent = serpentPosition[serpentPosition.Count - 1];

            if(serpent.x == Nourriture.x && serpent.y == Nourriture.y)
            {
                serpentPosition.Add(new Position(x, y));
                F.nourritureNexPos();
            }
        }

        public void mourrir()
        {
            Position serpent = serpentPosition[serpentPosition.Count - 1];

            for(int i = 0; i < serpentPosition.Count -2; i++)
            {
                Position sb = serpentPosition[i]; 

                if(serpent.x == sb.x && serpent.y == sb.y)
                {
                    throw new SerpentException("Tu as perdu");
                }
            }
        }

        public mur(Canvas canvas)
        {
            Position serpent = serpentPosition[serpentPosition.Count - 1];
            if (serpent.x >= canvas.Widht || serpent.x <= 0; serpent.y >= canvas.Height || serpent.y <=0)
            {
                throw new SerpentException("Tu as perdu");
            }
        }
    }
}
