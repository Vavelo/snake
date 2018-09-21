using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class VLine : FR
    {
        public VLine(int yl, int yr, int x, char sym)
        {
            plist = new List<Point>();

            for (int y = yl; x <= yr; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
