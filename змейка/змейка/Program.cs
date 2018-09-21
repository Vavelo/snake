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
            Console.SetBufferSize(80, 25);

            HLine UL = new HLine(0, 78, 0, '+');
            HLine DL = new HLine(0, 78, 24, '+');
            VLine LL = new VLine(0, 24, 0, '+');
            VLine RL = new VLine(0, 24, 78, '+');

            UL.Draw();
            DL.Draw();
            LL.Draw();
            RL.Draw();


            Point p = new Point(4, 5, '*');
            Slit Slit = new Slit(p, 4, dis.R);

            Slit.Draw();

            FC fc = new FC(80, 25, '$');
            Point food = fc.CF();
            food.Draw();


            while (true)
            {
                if (Slit.Eat(food))
                {
                    food = fc.CF();
                    food.Draw();
                }
                else
                {
                    Slit.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Slit.HK(key.Key);

                }

            }



        }




    }
}

