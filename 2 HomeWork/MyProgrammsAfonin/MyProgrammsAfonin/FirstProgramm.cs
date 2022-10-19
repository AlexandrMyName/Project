using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgrammsAfonin
{
    internal class FirstProgramm
    {
        public static void Programm()
        {
            InPutData();
            Exit.ExitMenu();
           

        }
        private static void InPutData()
        {

            double OneInt =   100000000000;
            double TwoInt =   100000000000;
            double ThreeInt = 100000000000;
            string One;
            string Two;
            string Three;
            Console.Title = "PROGRAMM ONE";
            Console.Clear();
            Console.WriteLine("Метод возвращающий минимальное значение из трёх чисел");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Введите первое число");
            One = Console.ReadLine();
            double.TryParse(One, out OneInt);
            Console.WriteLine("Введите второе число");
            Two = Console.ReadLine();
            double.TryParse(Two, out TwoInt);
            Console.WriteLine("Введите третье число");
            Three = Console.ReadLine();
            double.TryParse(Three, out ThreeInt);


            double minValue = OutPutData(OneInt, TwoInt, ThreeInt);
            Console.WriteLine("=====================================================");
            if(minValue != 908.12213)
            {
                Console.WriteLine($"Минимальное число: {minValue}");
            }
            else
            {
                Console.WriteLine($"Числа равны!");

            }
           
            

        }
        private static double OutPutData(double one, double two, double three)
        {

            double minValue = 0;

            if(one <= two && one<= three)
            {
                minValue = one;


            }
            else if(two<=one && two<= three)
            {
                minValue = two;


            }
            else if (three <= one && three <= two)
            {
                minValue = three;

            }
         
            else
            {

                minValue = 908.12213;
            }

            return minValue;
        }


    }
}
