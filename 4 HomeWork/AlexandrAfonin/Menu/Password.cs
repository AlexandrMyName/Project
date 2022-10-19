using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Password
    {

        public static void Programm()////////
        {
            Console.Clear();
            Console.Title = "PASSWORD CHECK";
            bool dataCheck = false;

            string[] newArray = Account.PasswordLoad(AppDomain.CurrentDomain.BaseDirectory + "Text.txt");
            string myPassword = Account.Password(newArray);
            string myLogin = Account.Login(newArray);
           

                Console.WriteLine("===============================================");
                Console.WriteLine("Программа проверки данных");
                Console.WriteLine("===============================================");
                Console.WriteLine("Логин и пароль будут загружены  с текстового файла и проверены");
                Console.WriteLine();

                Console.WriteLine("===============================================");
                Console.WriteLine("Нажмите любую клавишу");

                Console.WriteLine("===============================================");

                Console.ReadKey();
                dataCheck = CheckPassword(myLogin, myPassword);

                Console.Clear();
                if (dataCheck == false)
                {
                    Console.Clear();
                    Console.WriteLine("Верефикация провалена!");
                    Console.WriteLine("Данные не удалось считать!");

                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadKey();
                Program.Main();
            }
                else if (dataCheck == true)
                {
                    Console.Clear();
                    Console.WriteLine("Верефикация пройдена!");
                    Console.WriteLine("Данные успешно считаны!");
                    Console.WriteLine("Нажмите любую клавишу");
                    Console.ReadKey();
                Program.Main();
                  
                }


            }







            


        static private  bool  CheckPassword(string login, string pasword)////////
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

    public struct Account
    {
       

       

        public static string [] PasswordLoad(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader streamReader = new StreamReader(filename);
                string[] buffer = new string[500];
                int count = 0;



                while (!streamReader.EndOfStream)
                {

                    buffer[count] = streamReader.ReadLine();
                    count++;

                }

                string[] newArray = new string[count];

                for(int i = 0; i < newArray.Length; i++)
                {

                    newArray[i] = buffer[i];

                }



               streamReader.Close();

                return newArray;


            }
            else
            {
               throw new FileNotFoundException();

            }

        }
        public static string Password(string[] array)
        {

            string password = "";
            for(int i = 0; i < array.Length; i++)
            {

                if(array[i]== "GeekBrains")
                {

                password = array[i];

                    break;

                }


            }

            return password;

        }


        public static string Login(string[] array)
        {

            string login = "";
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == "root")
                {

                    login = array[i];

                    break;

                }


            }

            return login;

        }


    }
}

