using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class HLine
    {
        List<Point> plist;

        public HLine(int xl, int xr, int y, char sym)
    {
      plist = new List<Point>();

        for(int x = xl; x <= xr; x++)
               {
               Point p = new Point (x, y, sym);
                  plist.Add(p );
               }
    }


        public void Drow()
        {
            
            foreach(Point p in plist)
                p.Draw();
        }

    }
}
