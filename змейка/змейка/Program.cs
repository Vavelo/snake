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
            Console.SetBufferSize(100, 200);

            Walls walls = new Walls(100, 200);
            walls.Draw();

            // Отрисовка точек			
            Point p = new Point(4, 5, '*');
            Slit snake = new Slit(p, 4, dis.R);
            snake.Draw();

            FC foodCreator = new FC(80, 25, '$');
            Point food = foodCreator.CF();
            food.Draw();
            food.Draw();
            food.Draw();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CF();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HK(key.Key);
                }
            }
        }

    }
}
