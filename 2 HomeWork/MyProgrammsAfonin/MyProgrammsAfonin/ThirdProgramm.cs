using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
namespace MyProgrammsAfonin
{
    internal class ThirdProgramm
    {
        public static void Programm()
        {
            Input();

            Exit.ExitMenu();



        }
        private static void Input()
        {
            Console.Title = "PROGRAMM THREE";
            Console.Clear();
            Console.WriteLine("Метод подсчитывающий сумму всех нечетных положительных чисел");
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
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] % 2 == 0 && list[i] >= 0)
                {
                    outputValue+=list[i];
                    countTwo++;
                }


            }
            Console.Clear();
            Console.WriteLine($"==================================================================================");
            Console.WriteLine($"Количество введённых эллементов : {list.Count} | Из них четных чисел: {countTwo}  " );
            Console.WriteLine($"Сумма чётных чисел: {outputValue}  ");
            


        }
    }
}
