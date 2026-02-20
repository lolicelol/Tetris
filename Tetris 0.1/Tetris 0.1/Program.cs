using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Point p1 = new Point();
            p1.x = 2;
            p1.y = 3;
            p1.c = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 3;
            p2.y = 3;
            p2.c = '&';
            p2.Draw();

            Console.ReadLine();

        }

        static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

    }
}
