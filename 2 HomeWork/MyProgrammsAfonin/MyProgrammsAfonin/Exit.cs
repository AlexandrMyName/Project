using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgrammsAfonin
{
    internal class Exit
    {
        public static void ExitMenu()
        {

            while (true)
            {
                Console.WriteLine($"Для выхода в главное меню, нажмите 0");
               
                string menu = Console.ReadLine();
                if (menu == "0")
                {
                    Menu.MainMenu();
                    break;
                }
               
                else
                {
                    Console.Clear();

                }
            }


        }
    }
}
