using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hello.library;

namespace MyProgrammsAfonin
{
    internal class Program
    {
        static void Main(string[] args)
        {



            ForHello();
            Menu.MainMenu();



            Console.ReadLine();


        }




        static void ForHello()
        {
            string name = "Афонин Александр Игоревич";
            string usingFor = "Домашнее задание ко 2 уроку";
            Class1.HelloInfo(name, usingFor);
            
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();




        }

        


    }
}
