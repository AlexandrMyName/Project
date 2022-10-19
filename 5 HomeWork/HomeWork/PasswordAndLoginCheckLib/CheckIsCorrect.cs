using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordAndLoginCheckLib
{
    public class CheckIsCorrect
    {

        //результат метода Login - возвращение true или false, в зависимости от корректности ввода
        //Метод принимающий строку, которую необходимо проверить на корректность формата
        // правильный формат Логина:
        //# Логин должен состоять из 2-10 символов (латинский алфавит или числа)
        //# Первый символ должен быть буквой!

        #region "LOGIN"
        static public bool Login(string login)
        {

            bool isCorrect;
            Regex regex = new Regex("^[A-z]{1}[A-z0-9]{1,9}$");

            isCorrect = regex.IsMatch(login);


            return isCorrect;
        }
        #endregion



        //результат метода Password - возвращение true или false, в зависимости от корректности ввода
        //Метод принимающий строку, которую необходимо проверить на корректность формата
        // правильный формат Пароля:
        //# Пароль должен состоять из 8-25 символов (латинский алфавит или числа)


        #region "PASSWORD"
        static public bool Password(string password)
        {

            bool isCorrect;
            Regex regex = new Regex("^[A-z0-9]{8,25}$");

            isCorrect = regex.IsMatch(password);


            return isCorrect;
        }
        #endregion
    }
}
