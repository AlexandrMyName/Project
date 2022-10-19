using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Internal;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PasswordAndLoginCheckLib;


namespace HomeWork
{


   
    internal class CheckLogin
    {


        public static int account = 0;

        //точка входа - InputLogin, автоматически перейдет в - InputPassword
        #region "СОЗДАНИЕ ЛОГИНА" 
        public static void InputLogin()
        {
            Console.Clear();
            Console.Title = "InputLogin";
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("                                     Создание локального профиля                        ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("Введите логин:");
                    Console.WriteLine("Логин должен состоять из 10 символов Латинского алфавита или цифр, первый символ - буква");
            string login;
            bool trueFormat = false;

            do
            {
                login = Console.ReadLine();

                if (CheckIsCorrect.Login(login))
                {
                    trueFormat = true;


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("                                     Создание локального профиля                        ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("                             ФОРМАТ НЕ ВЕРНЫЙ !   ПОВТОРИТЕ ВВОД                        ");
                    Console.WriteLine("Логин должен состоять из 10 символов Латинского алфавита или цифр, первый символ - буква");
                    Console.WriteLine("----------------------------------------------------------------------------------------");


                }

            }
            while (trueFormat == false);

            Random idRandom = new Random();
           int id = idRandom.Next(1000,6000);

            InputPassword(ref login, ref id);
        }
        #endregion


        #region "СОЗДАНИЕ ПАРОЛЯ"
        public static void InputPassword(ref string login,ref int id )
        {
            Console.Clear();
            Console.Title = "InputLogin";
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($" ЛОГИН:{login}                                      ID: {id}                           ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Введите пароль:");
            Console.WriteLine("Пароль должен состоять из 8 - 25 символов Латинского алфавита или цифр");
            string password = "";
            char simbolPassword = ' ';
            bool trueFormat = false;

            while (trueFormat == false)
            {





                do
                {
                    simbolPassword = (char)Console.ReadKey().KeyChar;



                    if (simbolPassword != ' ' && simbolPassword != '\n' && simbolPassword != '\t' && simbolPassword != '\r'&& simbolPassword.GetHashCode() != 524296)
                    {
                        password += simbolPassword;
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop - 0);
                        Console.Write("*");
                    }

                    else if( simbolPassword.GetHashCode() == 524296)
                    {
                        break;
                    }




                }
                while (simbolPassword != ' ' && simbolPassword != '\n' && simbolPassword != '\t' && simbolPassword != '\r');


                if (CheckIsCorrect.Password(password))
                {
                    trueFormat = true;


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("                                     Создание локального профиля                        ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("                             ФОРМАТ НЕ ВЕРНЫЙ !   ПОВТОРИТЕ ВВОД                        ");
                    Console.WriteLine("Пароль должен состоять из 8 - 25 символов Латинского алфавита или цифр          ");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    password = "";
                    simbolPassword = ' ';

                }


            }


            GetToFile(ref login, ref id, ref password);

           


        }
        #endregion


        private static void GetToFile( ref string login, ref int id, ref string password)
        {

            StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "LogPass.txt");

                if (File.Exists("LogPass.txt"))
            {
                CheckLogin.account++;
                streamWriter.WriteLine(id);
                streamWriter.WriteLine(login);
                // добавить метод шифрования!!!
                streamWriter.WriteLine(password);
                streamWriter.WriteLine(account);
            }
                

                streamWriter.Close();


           

            PrintOK(ref login,ref id);
        }

        private static void PrintOK(ref string login, ref int id)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("                               Профиль успешно сформирован!                             ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("Закрытие окна создания профиля, нажмите ENTER                                           ");
            Console.WriteLine("Для последующего входа в учетную запись, введите логин и пароль                         ");
            Console.WriteLine("----------------------------------------------------------------------------------------");

            Console.ReadKey();


        }
    }
}
