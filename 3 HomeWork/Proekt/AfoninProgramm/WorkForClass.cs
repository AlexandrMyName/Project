using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfoninProgramm

{ 
    internal class WorkForClass
    {



        public static char HelloForProgrammOne()
        {
            Console.Clear();
            Console.WriteLine("Программа работы с классом/ работа над комплексными числами(бинарный операнд)");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Какую операцию вы хотите совершить? введите '+', '-', '*'или '/'   ");
            Console.WriteLine("_________________________________________________");

            char myChar = '+';
            bool myBool = char.TryParse(Console.ReadLine(), out myChar);

            while (true)
            {

                if (myBool == false)
                {
                    Console.WriteLine("Вы ввели неккоректный символ");
                    Console.WriteLine("Попробуйте ещё!");

                    myBool = char.TryParse(Console.ReadLine(), out myChar);


                }
                else if (myChar == '+' || myChar == '-' || myChar == '*' || myChar == '/')
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неккоректный символ");
                    Console.WriteLine("Попробуйте ещё!");

                    myBool = char.TryParse(Console.ReadLine(), out myChar);
                }

            }
            return myChar;
        }
        public static void Work()
        {

            char myChar = HelloForProgrammOne();
            Console.Clear();
            Console.Title = "Complex/ Class";
            Console.WriteLine("____________________");
            Console.WriteLine($"Вы выбрали операцию:  {myChar}");
            Console.WriteLine("____________________");
            Class complex1 = new Class(0,0);
            Class complex2 = new Class(0,0);
            Class resultSumm = new Class();

          
            
            Console.WriteLine("Введите  целое число первого комплексного числа");

            bool re1Bool = int.TryParse(Console.ReadLine(), out complex1.re);


            Console.WriteLine("Введите мнимое целое число первого комплексного числа");

            bool im1Bool = int.TryParse(Console.ReadLine(), out complex1.im);




            //
            Console.WriteLine("Введите  целое число второго комплексного числа");

            bool re2Bool = int.TryParse(Console.ReadLine(), out complex2.re);


            Console.WriteLine("Введите мнимое целое число второго комплексного числа");

            bool im2Bool = int.TryParse(Console.ReadLine(), out complex2.im);

            if (im1Bool == false || re1Bool == false || im2Bool == false || re2Bool == false)
            {
                Console.WriteLine("Вы ввели неккоректное число");

            }
            else
            {
                if (myChar == '+')
                    resultSumm = Class.Summ(complex1.Re, complex2.Re, complex1.Im, complex2.Im);
                else if (myChar == '-')
                    resultSumm = Class.Min(complex1.Re, complex2.Re, complex1.Im, complex2.Im);
                else if (myChar == '*')
                    resultSumm = Class.Umn(complex1.Re, complex2.Re, complex1.Im, complex2.Im);
                else if (myChar == '/')
                    resultSumm = Class.Del(complex1.Re, complex2.Re, complex1.Im, complex2.Im);


            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"результат: {resultSumm}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Хотите продолжить или повторить?");
            Console.WriteLine("1: Повтор программы");
            Console.WriteLine("0: Главное меню");
            string vibor2 = Console.ReadLine();

            while (true)
            {
                if (vibor2 == "1")
                {
                    WorkForClass.Work();

                }
                else if (vibor2 == "0")
                {
                    Program.Main();
                    break;
                }
                else
                {
                    Console.WriteLine("0 - Главное меню, 1 - Повтор");
                    break;
                }
            }

        }
    }
}
