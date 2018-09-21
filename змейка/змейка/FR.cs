using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class FR
    {
        protected List<Point> plist;


        public virtual void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }


        internal bool IsHit(FR figure)
        {
            foreach (var p in plist)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in plist)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}
