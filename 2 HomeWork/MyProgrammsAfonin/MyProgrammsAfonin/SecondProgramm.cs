using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgrammsAfonin
{
    internal class SecondProgramm
    {
        public static void Programm()
        {
            Console.Clear();
            Console.Title = "PROGRAMM TWO";
            Console.WriteLine("Метод  подсчета количества цифр числа");
            Console.WriteLine("=====================================");
            Console.WriteLine("Введите  число");
            Console.WriteLine("Для корректного подсчета, используйте только цифры");
            string number = Console.ReadLine();
            Console.WriteLine("=====================================");
            Console.WriteLine($"Вы ввели : {number}");
            Console.WriteLine($"Количество цифр : {number.Length}");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            Exit.ExitMenu();

        }


        

    }
}
