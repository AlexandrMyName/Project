using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koordinat
{
    /*Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
     * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
     * используя спецификатор формата .2f (с двумя знаками после запятой);*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "расстояние между точками с координатами x1, y1 и x2,y2";
            Console.WriteLine("Здравствуйте!  Эта программа  подсчитывает расстояние между точками с координатами x1  ,  y1 и x2  ,  y2");
            Console.WriteLine();
            Console.WriteLine("Введите координату X1");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y1");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату X2");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату Y2");
            double y2 = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            r = Math.Round(r,2);
            Console.Clear();
            Console.Write($"расстояние между точками с координатами {x1}, {y1} и {x2},{y2}  :  ");
            Console.Write(r);
            Console.ReadKey();
        }
    }
}
