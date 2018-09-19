using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace змейка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);

            HLine UL = new HLine(0, 78, 0, '+');
            HLine DL = new HLine(0, 78, 24, '+');
            VLine LL = new VLine(0, 24, 0, '+');
            VLine RL = new VLine(0, 24, 78, '+');

            UL.Drow();
            DL.Drow();
            LL.Drow();
            RL.Drow();


            Point p = new Point(4,5,'*');
            Slit Slit = new Slit(p, 4, dis.R);
            
            Slit.Drow();
           

            Console.ReadLine();

        }

       


    }
}
