using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class VLine : FR
    {
        public VLine(int yUp, int yDown, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
