using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLib;

namespace Menu
{
    internal class Program
    {
        #region Главная точка входа
        static public void Main()
        {
            Menu();

            


        }

        #endregion


        #region Main MENU
        static void Menu()
        {
            Console.Clear();
            Console.Title = "MENU";
            Console.WriteLine("Афонин Александр Игоревич");
            Console.WriteLine("___________________________");
            Console.WriteLine("Домашнее задание к 4 уроку");
            Console.WriteLine("___________________________");
            Console.WriteLine();

            Console.WriteLine("Для выбора программы, ведите число:");
            Console.WriteLine();

            Console.WriteLine("1: работа массивом ");
            Console.WriteLine("2: работа с паролями");
       
            Console.WriteLine("0: Выход");

            while (true)
            {
                string vibor = Console.ReadLine();
                if (vibor == "1")
                {

                    WorkForArray.Work();
                }
                
                else if (vibor == "2")
                {
                   Password.Programm();

                }
                else if (vibor == "0")
                {
                    break;
                }

            }


        }
        #endregion
    }
}
