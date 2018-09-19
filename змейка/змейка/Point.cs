using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, dis D)
           {
               if (D == dis.R)
               {
                   x += offset;
               }
               else if (D == dis.U)
               {
                   y -= offset;
               }
               else if (D == dis.L)
               {
                   x -= offset;
               }
               else 
               {
                   y += offset;
               }
           }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }
}
