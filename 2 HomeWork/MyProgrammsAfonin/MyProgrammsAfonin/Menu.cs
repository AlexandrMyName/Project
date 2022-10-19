using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello.library;

namespace MyProgrammsAfonin
{
    internal class Menu
    {

       public static void MainMenu()
        {

            Console.Clear();
            PrintInfo();
            ForMenu();
           

        }

        public static void PrintInfo()
        {
            Console.Title = "Main menu";
            Console.WriteLine("_____________________");
            Console.WriteLine("Окно выбора программы");
            Console.WriteLine("---------------------");
            Console.WriteLine("Выберите программу, нажав:");
            Console.WriteLine("1: минимальное из трёх чисел");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("2: подсчёт количества цифр числа");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("3: сумма всех нечетных положительных чисел");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("4: метод проверки логина и пароля");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("5: индекс массы");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("6: 6 программа");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("0: ВЫХОД");
        }

        private static void ForMenu()
        {



            string inputDataNotInt = Console.ReadLine();

            int inputDataNotString = 7;
             int.TryParse(inputDataNotInt, out inputDataNotString);


            


            switch (inputDataNotString)
            {
                case 0:
                    
                    Console.WriteLine("Завершение работы приложения");
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadKey();
                    break;

                case 1:
                    FirstProgramm.Programm();
                    break;
                case 2:
                    SecondProgramm.Programm();
                    break;

                case 3:
                    ThirdProgramm.Programm();
                    break;

                case 4:
                    ForthProgramm.Programm();
                    break;


                case 5:
                    FifthProgramm.Programm();

                    break;

                case 6:

                    SixthProgramm.Programm();
                    break;
                case 7:
                    Console.Clear();
                    Console.Title = "ERROR";
                    Console.WriteLine("Ошибка!");
                    break;

                default:

                    Console.Clear();
                    Console.Title = "ERROR";
                    Console.WriteLine("Ошибка!");
                    
                    break;





            }



        }



    }
}
