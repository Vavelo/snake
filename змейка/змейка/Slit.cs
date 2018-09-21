using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class Slit : FR
    {
        public dis D;
        public Slit(Point tail, int length, dis _D)
        {
            D = _D;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, D);
                plist.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GNP();
            plist.Add(head);

            tail.Clear();
            head.Draw();

        }

        public Point GNP()
        {
            Point head = plist.Last();
            Point nextP = new Point(head);
            nextP.Move(1, D);
            return nextP;
        }

        public void HK(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                D = dis.L;
            else if (key == ConsoleKey.RightArrow)
                D = dis.R;
            else if (key == ConsoleKey.UpArrow)
                D = dis.U;
            else if (key == ConsoleKey.DownArrow)
                D = dis.D;
        
        }

        internal bool Eat(Point food)
        {
            Point head = GNP();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else 
                return false; 
 
        }
    }
}
