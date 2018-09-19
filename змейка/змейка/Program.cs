using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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

            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        Slit.D = dis.L;
                    else if (key.Key == ConsoleKey.RightArrow)
                        Slit.D = dis.R;
                    else if (key.Key == ConsoleKey.UpArrow)
                        Slit.D = dis.U;
                    else if (key.Key == ConsoleKey.DownArrow)
                        Slit.D = dis.D;
                }


                Thread.Sleep(100);
                Slit.Move();
            }

            Console.ReadLine();

        }

       


    }
}
