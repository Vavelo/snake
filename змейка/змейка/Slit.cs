using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class Slit : FR
    {
        public Slit(Point tail, int length, dis D)
        {
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, D);
                plist.Add(p);
            }
        }
    }
}
