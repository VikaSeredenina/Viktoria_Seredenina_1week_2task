using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nachalo = 7;
            int s = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    Console.Write(" " + nachalo);
                }
                s++;
                nachalo--;
                Console.WriteLine();
            }
        }
    }
}

