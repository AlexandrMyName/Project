using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 //   (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
   // программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.



namespace MyProgrammsAfonin
{
    internal class ForthProgramm
    {
        public static void Programm()
        {
            Console.Clear();
            Console.Title = "PASSWORD CHECK";
            bool dataCheck = false;
            int countInput = 3;
            do
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("Программа проверки данных");
                Console.WriteLine("===============================================");
                Console.WriteLine("Введите логин");
                Console.WriteLine();
                string loginCheck = Console.ReadLine();
                Console.WriteLine("===============================================");
                Console.WriteLine("Введите пароль");
                string passwordCheck = Console.ReadLine();
                Console.WriteLine("===============================================");


                 dataCheck = CheckPassword(loginCheck, passwordCheck);
                Console.Clear();
                if (dataCheck == false)
                {
                    Console.Clear();
                    Console.WriteLine("Верефикация провалена!");
                    Console.WriteLine($"У вас осталось попыток: {countInput}");
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadKey();
                }
                else if(dataCheck == true)
                {
                    Console.Clear();
                    Console.WriteLine("Верефикация пройдена!");
                   
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadKey();
                    break;
                }
                countInput--;

            }
            while (countInput >= 0 || dataCheck == true);



           


            Exit.ExitMenu();

        }
        private static bool CheckPassword(string login, string pasword)
        {
            Console.Title = "PROGRAMM - CHECK PASSWORD";
            string loginTrue = "root";
            string passwordTrue = "GeekBrains";
            bool dataCheck = false;
            

            if (login == loginTrue && pasword == passwordTrue)
            {

                dataCheck = true;



            }
            else
            {
                dataCheck = false;
            }


            return dataCheck;
        }
    }
}
