using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfoninProgramm
{


    

    internal class Program
    {

       


        public static void Main()
        {
            Menu();

        }

        static void Menu()
        {
        Console.Clear();
            Console.Title = "MENU";
            Console.WriteLine("Афонин Александр Игоревич");
            Console.WriteLine("___________________________");
            Console.WriteLine("Домашнее задание к 3 уроку");
            Console.WriteLine("___________________________");
            Console.WriteLine();

            Console.WriteLine("Для выбора программы, ведите число:");
            Console.WriteLine();

            Console.WriteLine("1: работа со структурой Complex ");
            Console.WriteLine("2: работа с классом Complex");
            Console.WriteLine("3: сумма всех нечётных положительных чисел");
            Console.WriteLine("0: Выход");

            while (true)
            {
                string vibor = Console.ReadLine();
                if(vibor == "1")
                {

                    WorkForStructs.Work();
                }
                else if (vibor == "2")
                {
                    WorkForClass.Work();

                }
                else if (vibor == "3")
                {
                    ThirdProgramm.Programm();

                }
                else if(vibor == "0")
                {
                    break;
                }

            }

        }
    }
}
