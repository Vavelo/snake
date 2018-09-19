using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class FC
    {
        int MH;
        int MW;
        char sym;

        Random R = new Random();

        public FC(int MW, int MH, char sym)
        {
            this.MW = MW;
            this.MH = MH;
            this.sym = sym;

        }

        public Point CF()
        {
            int x = R.Next(2, MW - 2);
            int y = R.Next(2, MH - 2);
            return new Point(x, y, sym);

        }


    }
}
