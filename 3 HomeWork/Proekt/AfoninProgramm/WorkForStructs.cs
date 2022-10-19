using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfoninProgramm
{
    internal class WorkForStructs
    {


        public static char HelloForProgrammOne()
        {
        Console.Clear();
            Console.WriteLine("Программа работы со структурой/ работа над комплексными числами(бинарный операнд)");
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
            Console.Title = "Complex/ struct";
            Console.WriteLine("____________________");
            Console.WriteLine($"Вы выбрали операцию:  {myChar}");
            Console.WriteLine("____________________");
            Structs.Complex complex1;
            Structs.Complex complex2;
            Structs.Complex resultSumm = new Structs.Complex();

            complex1.re = 0;
            complex1.im = 0;
            complex2.re = 0;
            complex2.im = 0;

            //
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
                if(myChar == '+')
                resultSumm = Structs.Complex.Summ(complex1.re, complex2.re, complex1.im, complex2.im);
                else if (myChar == '-')
                    resultSumm = Structs.Complex.Min(complex1.re, complex2.re, complex1.im, complex2.im);
                else if (myChar == '*')
                    resultSumm = Structs.Complex.Umn(complex1.re, complex2.re, complex1.im, complex2.im);
                else if (myChar == '/')
                    resultSumm = Structs.Complex.Del(complex1.re, complex2.re, complex1.im, complex2.im);
               

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
                    WorkForStructs.Work();

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
