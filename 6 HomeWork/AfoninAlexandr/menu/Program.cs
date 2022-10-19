using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Menu();


           // WorkWithFunction()




        }
        public static void Menu()
        {
            Console.Clear();
            Console.Title = "MENU";
            Console.WriteLine("Афонин Александр Игоревич");
            Console.WriteLine("___________________________");
            Console.WriteLine("Домашнее задание к 6 уроку");
            Console.WriteLine("___________________________");
            Console.WriteLine();

            Console.WriteLine("Для выбора программы, ведите число:");
            Console.WriteLine();

            Console.WriteLine("1: результат арифметической операции:  a* x^2  " );
            Console.WriteLine("2: результат арифметической операции:  a* sin(x)");
            Console.WriteLine("3: программа нахождения минимума чисел        ");
            Console.WriteLine(" ");

            Console.WriteLine("0: Выход");

            while (true)
            {
                char vibor = Console.ReadKey().KeyChar;
                Console.Clear();
                if (vibor == '1')
                {
                    bool notA = false;
                    bool notB = false;
                    while (notA == false && notB == false)
                    {
                        
                        double a = 0;
                        double x = 0;
                        Console.Title = "Арифметические операции";
                        Console.WriteLine("Будет произведён подсчет из выражения:  a* x^2");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.Write("Введите число А :    ");
                        notA = double.TryParse(Console.ReadLine(), out a);
                        Console.Write("Введите число X :    ");
                        notB = double.TryParse(Console.ReadLine(), out x);
                        if (notA == false && notB == false)
                        {
                            Console.WriteLine("Неверный формат, попробуйте снова!");
                            Console.ReadKey();

                        }
                        else
                        {
                            MyDelegate myDelegateone = Delegation.OneFunction;
                            Delegation.ResultOne(myDelegateone, a, x);

                            Console.ReadKey();
                            Menu();
                        }

                    }
                }

                else if (vibor == '2')
                {
                    Console.Clear();
                    bool notA = false;
                    bool notB = false;
                    while (notA == false && notB == false)
                    {
                        
                        double a = 0;
                        double x = 0;
                        Console.Title = "Арифметические операции";
                        Console.WriteLine("Будет произведён подсчет из выражения:  a* sin(x)");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.Write("Введите число А :    ");
                        notA = double.TryParse(Console.ReadLine(), out a);
                        Console.Write("Введите число B :    ");
                        notB = double.TryParse(Console.ReadLine(), out x);
                        if (notA == false && notB == false)
                        {
                            Console.WriteLine("Неверный формат, попробуйте снова!");
                            Console.ReadKey();

                        }
                        else
                        {

                            MyDelegate myDelegatetwo = Delegation.TwoFunction;
                            Delegation.ResultOne(myDelegatetwo, a, x);

                            Console.ReadKey();
                            Menu();
                        }
                    }
                }
                else if (vibor == '3')
                {

                    TwoProgramm.WorkWithFunction();

                }
                else if (vibor == '0')
                {
                    break;
                }

            }

        }
    }
}
