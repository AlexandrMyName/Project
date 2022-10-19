using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXMass
{
    
    // Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "INDEX";
            Console.WriteLine("Здравствуйте! Эта программа подсчитывает индекс массы");
            Console.WriteLine();
            Console.WriteLine("Пожалуйста, введите ваш рост");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Пожалуйста, введите ваш вес");
            double m = Convert.ToDouble(Console.ReadLine());
            double i;
            i = m/(h*h);
            i += i * 10000;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"Ваш индекс массы тела составляет: {i}");
            Console.WriteLine();
            if (i >= 18.5 && i <= 25)
            {
                Console.WriteLine("У вас ИМТ(Индекс массы тела) в норме!!!");
            }
            else if (i >= 25.5 && i <= 30)
            {
                Console.WriteLine("К сожалению , у  вас избыточный вес! Поправляйтесь");

            }
            else if (i >= 30 )
            {
                Console.WriteLine("К сожалению , у  вас ожирение!");

            }
            else if (i <= 18)
            {
                Console.WriteLine("К сожалению , у  вас недобор !");

            }
            Console.ReadKey();
        }
    }
}
