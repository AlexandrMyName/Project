using ArrayLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class WorkForArray
    {
        static public void Work()
        {
            #region "Инициализация массива"
            int arrayLength;
            int input = -1;
            int count = 0;
            MenuForArray1();
            int.TryParse(Console.ReadLine(), out arrayLength);
            ArrayClass myArrayOne = new ArrayClass(arrayLength);
           
            #endregion

            #region "Основная программа"
            MenuForArray2();

            do
            {
                int shag;
                bool inputBool = int.TryParse(Console.ReadLine(), out input);
                if (inputBool && input == 1)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Укажите шаг заполнения массива рандомными числами");


                        bool shagBool = int.TryParse(Console.ReadLine(), out shag);
                        if (shagBool && shag <= arrayLength)
                        {
                            ArrayClass myArrayTwo = new ArrayClass(arrayLength, shag + 1);


                            PrintResult(shag, arrayLength);
                            for (int i = 0; i < arrayLength; i++)
                            {
                                Console.WriteLine("Число = " + myArrayTwo[i] + " [индекс = " + i + "]");
                            }
                            PrintResult(shag, arrayLength);


                            Console.WriteLine("Нажмите любую клавишу, для выхода в главное меню");
                            Console.ReadKey();

                            Program.Main();





                        }
                        else
                        {
                            Console.WriteLine("Неккоректный ввод, повторите");
                            
                        }
                    }


                }
                else if (inputBool && input == 2)
                {
                    Console.Clear();
                    PrintHello(arrayLength);

                    
                    bool parseBool = false;
                    string stop = "";
                   
                    
                        for(int i = 0; i < arrayLength; i++)
                        {
                            int value=0;
                            parseBool = false;

                        if(stop == "STOP")
                        {
                            break;
                        }

                            while (!parseBool)
                            {
                           
                                parseBool = int.TryParse(Console.ReadLine(), out value);
                                if (!parseBool)
                                {
                                    Console.WriteLine("Неверный ввод, повторите попытку");
                                }
                                
                            }
                            myArrayOne[i] = value;

                           Console.WriteLine("Нажмите ENTER для следующего ввода или для остановки введите STOP ");
                            stop = Console.ReadLine();
                        Console.WriteLine("Введите следующее число");
                            count++;
                        }

                        TwoProgrammEnd(count, arrayLength);
                    Operations(myArrayOne, arrayLength);



                }
                else
                {
                    Console.WriteLine("Неккоректный ввод, повторите");
                   
                }

            }
            while (input != 0);
        }
            #endregion

            #region методы вывода
        static void MenuForArray1()
        {
            Console.Clear();
            Console.Title = "ARRAY";
            Console.WriteLine("___________________________");
            Console.WriteLine("Вы выбрали 'Работа с массивом'");
            Console.WriteLine("___________________________");
            Console.WriteLine("Вы можете создать массив");
            Console.WriteLine("Какую задать длинну массива? ");
            Console.WriteLine("");
            Console.WriteLine("");
            
        }

        static void MenuForArray2()
        {
            Console.Clear();
            Console.WriteLine("___________________________");
            Console.WriteLine("Выберите доступные операции над вашим массивом");
            Console.WriteLine("___________________________");
            Console.WriteLine("");
            Console.WriteLine("___________________________");
            Console.WriteLine("1:Задать рандомные числа (от 0 до 250) ");
            Console.WriteLine("Вы можете указать шаг заполнения! ");
            Console.WriteLine("Заполнение произойдет от начала массива");
            Console.WriteLine("___________________________");
            Console.WriteLine("2:Задать конкретные данные");
            Console.WriteLine("задавайте только целые числа");
            Console.WriteLine("___________________________");
            Console.WriteLine("");

        }

        static void PrintResult(int shag, int arrayLength)
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"|   Массив сформирован!    |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"шаг - {shag} || кол-во эл. - {arrayLength}");
            Console.WriteLine();
            Console.WriteLine("_______________________________________________");
            Console.WriteLine();


        }

        static void PrintHello(int arrayLength)
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"|   Вводите числа!    |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($" кол-во эл. массива - {arrayLength}");
            Console.WriteLine();
            Console.WriteLine("Для остановки, введите слово STOP, после ввода цифры");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine();


        }

        static void TwoProgrammEnd(int count, int arrayLength)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"|     Вы заполнили: {count}   |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($" кол-во эл. массива - {arrayLength}");
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу, для выбора следующей операции");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine();

            
        }
        //печать информации о дальнейших операциях, над массивом
        static void printForOperations()
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Окно выбора операций        |");
            Console.WriteLine("----------------------------");

            Console.WriteLine("");
            Console.WriteLine("1: Просмотр данных в массиве");
            Console.WriteLine("2: Поиск максимального числа    (MaxCount)");
            Console.WriteLine("3: Сумма всех данных в массиве  (SUM) ");
            Console.WriteLine("4: Инвертация знаков  (Inverse)");
            Console.WriteLine("5: Умножение каждого эллемента  (Multi)");
            Console.WriteLine("0: Выход на главное меню");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");

        }

        static void PrintArray(ArrayClass myArrayOne, int arrayLength)
        {
            Console.Clear();
          
            Console.WriteLine("------------------------------------");
            Console.WriteLine($" кол-во эл. массива - {arrayLength}|");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            for(int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(myArrayOne[i]);
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }

        static void PrintForMaxCount(int max)
        {

            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine($" максимальный эл. массива - {max}  |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();



        }
        static void PrintForSum(int sum)
        {
             
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine(" сумма всех эл. массива - "+ sum +" |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();



        }

        static void PrintNewArray(int [] array, int arrayLength)
        {
            Console.Clear();

            Console.WriteLine("------------------------------------");
            Console.WriteLine($" кол-во эл. массива - {arrayLength}|");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }


        #endregion







        //операции со свойствами, методами и конструкторами

        static public void Operations(ArrayClass myArrayOne, int arrayLength)
        {
            int operationInt = -1;
            bool operationInputBool = false;
            printForOperations();
            while(operationInputBool != true)
            {

                operationInputBool = int.TryParse(Console.ReadLine(), out operationInt);
                if (operationInputBool == false)
                {
                    Console.WriteLine("Неккоректный ввод, повторите!");
                }
            }
            
            if(operationInt == 1)
            {

                PrintArray(myArrayOne, arrayLength);
                Operations(myArrayOne, arrayLength);

            }
            else if (operationInt == 2)
            {
                int max;
                max = myArrayOne.MaxCount;
               
               PrintForMaxCount(max);
                Operations(myArrayOne, arrayLength);
            }
            else if (operationInt == 3)
            {
                int sum;
                sum = myArrayOne.Sum;

                PrintForSum(sum);
                Operations(myArrayOne, arrayLength);
                
                
            }
            else if (operationInt == 4)
            {
              
                int [] newArray = myArrayOne.Inverse();

                PrintNewArray(newArray,arrayLength);
                Operations(myArrayOne, arrayLength);

            }
            else if (operationInt == 5)
            {
                Console.Clear();
                Console.WriteLine("На сколько умножить каждый эллемент массива?");
                bool multiBool = false;
                int multi=0;
                while (!multiBool)
                {
                    multiBool = int.TryParse(Console.ReadLine(), out multi);
                    
                }
                 
               
                myArrayOne.Multi(multi);
                PrintArray(myArrayOne, arrayLength);
                Operations(myArrayOne, arrayLength);

            }
            else if (operationInt == 0)
            {
                Program.Main();
            }



        }
    }
}
