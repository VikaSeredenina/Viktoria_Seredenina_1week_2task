using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Введите количество прошедших месяцев");
                int m = Int32.Parse(Console.ReadLine());
                
                if (m < 0)
                {
                    Console.WriteLine("Не может быть отрицательным! ");
                   
                } 
                else
                {
                    int localDate = Int32.Parse(DateTime.Now.ToString("MM"));

                    while (m >= 12)
                    {
                        m -= 12;
                    }

                    int date = localDate - m;



                    switch (date)
                    {
                        case 1: Console.WriteLine("Январь"); break;
                        case 2: Console.WriteLine("Февраль"); break;
                        case 3: Console.WriteLine("Март"); break;
                        case 4: Console.WriteLine("Апрель"); break;
                        case 5: Console.WriteLine("Май"); break;
                        case 6: Console.WriteLine("Июнь"); break;
                        case 7: Console.WriteLine("Июль"); break;
                        case 8: Console.WriteLine("Август"); break;
                        case 9: Console.WriteLine("Сентябрь"); break;
                        case 10: Console.WriteLine("Октябрь"); break;
                        case 11: Console.WriteLine("Ноябрь"); break;
                        case 12: Console.WriteLine("Декабрь"); break;
                        default:
                            Console.WriteLine("ОШИБКА!"); break;
                    }
                }
            }
            catch
            {
                
            }
        }
    }
}



