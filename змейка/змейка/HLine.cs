using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class HLine : FR
    {
        

        public HLine(int xl, int xr, int y, char sym)
    {
      plist = new List<Point>();

        for(int x = xl; x <= xr; x++)
               {
               Point p = new Point (x, y, sym);
                  plist.Add( p );
               }
    }



    }
}
