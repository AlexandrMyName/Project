using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANKETA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ваша анкета";
            Input();
        }


        static void Input()
        {
            string title = "Пожалуйста, заполните анкету";
            string name = "Введите ваше имя";
            string surName = "Введите вашу фамилию";
            string MiddleName = "Введите ваше отчество";
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine(name);
            name = Console.ReadLine();
            Console.WriteLine(surName);
            surName = Console.ReadLine();
            Console.WriteLine(MiddleName);
            MiddleName = Console.ReadLine();
            Console.WriteLine("Введите ваш возвраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш рост");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш вес");
            double waight = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($" Ваше имя:{name} || Ваша фамилия:  {surName} || Ваше отчество:  {MiddleName} ||  " + "возвраст: {0} ||  рост: {1} ||  вес: {2}", age, height, waight);
            Console.WriteLine();
            Console.WriteLine("Вы успешно заполнили анкету!");
            Console.WriteLine("Для выхода нажмите любую клавишу!");
            Console.ReadKey();
        }
    }
}
