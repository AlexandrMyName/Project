using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Profile
    {


        public static void MyProfil()
        {
            Console.Clear();
            Console.Title = "My profile";
            Console.WriteLine("Вы успешно авторизовались!");
            





            Console.ReadKey();








        }


        public static void AutorizationLogin(ref string[] array)
        {
            Console.Title = "PROFIL:    AUTORIZATION";
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                     ОКНО АВТОРИЗАЦИИ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Введите логин:");
            string login = Console.ReadLine();

            if (login == array[1])
            {

                AutorizationPassword(ref array);

            }
            else
            {
                Console.Title = "ERROR";
                Console.WriteLine("Логин не найден!");
                Console.WriteLine("ОШИБКА!");

                Console.ReadKey();
                
            }


        }
        public static void AutorizationPassword(ref string[] array)
        {
            Console.WriteLine();
            Console.Write("Введите пароль: ");


            string password = "";
            char simbolPassword = ' ';
            bool trueFormat = false;


            do
            {
                simbolPassword = (char)Console.ReadKey().KeyChar;



                if (simbolPassword != ' ' && simbolPassword != '\n' && simbolPassword != '\t' && simbolPassword != '\r' && simbolPassword.GetHashCode() != 524296)
                {
                    password += simbolPassword;
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 0);
                    Console.Write("*");
                }

                else if (simbolPassword.GetHashCode() == 524296)
                {
                    break;
                }




            }
            while (simbolPassword != ' ' && simbolPassword != '\n' && simbolPassword != '\t' && simbolPassword != '\r');


            if(password == array[2])
            {

                MyProfil();

            }
            else
            {
                Console.Title = "ERROR";
                Console.WriteLine("Авторизация провалена");
                Console.WriteLine("Доступ запрещён!");

                Console.ReadKey();

            }

        }
    }
}