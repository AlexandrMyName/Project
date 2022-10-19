using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyProgrammsAfonin
{
    internal class FifthProgramm
    {
        public static void Programm()
        {
            InputIndex();


            Console.WriteLine();
            Exit.ExitMenu();

        }



        private static void InputIndex()
        {
            Console.Title = "INDEX MASS";
            Console.Clear();
            Console.WriteLine("Подсчёт индекса массы");
            Console.WriteLine("=====================================================");
            double height;
            double weight;
            Console.WriteLine("Введите свой рост(м)");
           
            string heightString = Console.ReadLine();
            double.TryParse(heightString, out height);


            Console.WriteLine("Введите свой вес(кг)");
            string weightString = Console.ReadLine();
            double.TryParse(weightString, out weight);

            double index = weight/(height* height);
            index *= 10000;

            Console.WriteLine($"Ваш индекс массы составляет: {index}");
            double weightFull = index / (height * height) * 10000;
            if (index < 18.5)
            {

                Console.WriteLine("К сожалению, у вас недобор");
            }
            else if (index >= 18.5 && index <= 24.9)
            {

                Console.WriteLine("Индекс массы тела в норме!");

            }
            else if(index >= 25 && index<=30)
            {
                Console.WriteLine("К сожалению, у вас избыточная масса тела!");
                Console.WriteLine($"Вам нужно похудеть на: {weightFull} кг");


            }
            else if (index >= 30 && index <= 34.9)
            {
                Console.WriteLine("К сожалению, у вас 1 степень ожирения!");
               
                Console.WriteLine($"Вам нужно похудеть на: {weightFull} кг");

            }
            else if (index >= 35 && index <= 39.9)
            {
                Console.WriteLine("К сожалению, у вас 2 степень ожирения!");
                Console.WriteLine($"Вам нужно похудеть на: {weightFull} кг до 1 степени ожирения");


            }
            else if (index >= 40)
            {
                Console.WriteLine("К сожалению, у вас 3 степень ожирения!");
                Console.WriteLine($"Вам нужно похудеть на: {weightFull} кг до 2 степени ожирения");

            }

        }
        





    }
}
