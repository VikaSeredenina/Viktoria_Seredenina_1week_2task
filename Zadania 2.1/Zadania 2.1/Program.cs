using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("x=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Неккоректные данные \nx=");
                    continue;
                }
                else break;
            }
            Console.Write("y=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Неккоректные данные \ny=");
                    continue;
                }
                else break;
            }

            if (y< 12 && y > Math.Abs(x))
                Console.WriteLine("Да");
            else if (y>12 || y < Math.Abs(x))
                Console.WriteLine("Нет");
            else Console.WriteLine("На границе");

        }
    }
}
