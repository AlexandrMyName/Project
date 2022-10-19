using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfoninProgramm
{
    public class ThirdProgramm
    {
        public static void Programm()
        {
            Input();

            



        }
        private static void Input()
        {
            Console.Title = "PROGRAMM THREE";
            Console.Clear();
            Console.WriteLine("Метод подсчитывающий сумму всех четных положительных чисел");
            Console.WriteLine("============================================================");
            Console.WriteLine("Программа перейдет в режим подсчёта, если будет введён 0 !");
            Console.WriteLine("============================================================");
            Console.WriteLine("Инициализация ввода:");

            List<double> list = new List<double>();
            double outputValue = 0;
            int countTwo = 0;
            bool zerobool = false;
            while (zerobool == false)
            {
                double test = double.Parse(Console.ReadLine());
                if (test == 0)
                {

                    zerobool = true;

                }
                else
                {

                    list.Add(test);

                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0 && list[i] >= 0)
                {
                    outputValue += list[i];
                    countTwo++;
                }


            }
            Console.Clear();
            Console.WriteLine($"==================================================================================");
            Console.WriteLine($"Количество введённых эллементов : {list.Count} | Из них четных чисел: {countTwo}  ");
            Console.WriteLine($"Сумма чётных чисел: {outputValue}  ");

           
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Хотите продолжить или повторить?");
            Console.WriteLine("1: Повтор программы");
            Console.WriteLine("0: Главное меню");
            string vibor2 = Console.ReadLine();
            while (true)
            {
                if (vibor2 == "1")
                {
                    ThirdProgramm.Programm();

                }
                else if (vibor2 == "0")
                {
                    Program.Main();
                    break;
                }
                else
                {
                    Console.WriteLine("0 - Главное меню, 1 - Повтор");
                }
            }

        } 
    }
}
