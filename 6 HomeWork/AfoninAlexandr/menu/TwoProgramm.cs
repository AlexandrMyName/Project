using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    //нахождение минимума (чисел) из функции
    public delegate bool MyMin(int i,int min);
    internal class TwoProgramm
    {
        // min - минимальная граница которая отсекает больше мин. значения
        static public bool MinValues(int i, int min)// числа которые больше мин. значения - отсеиваются
        {
            return i < min;
        }
        static public bool MaxValues(int i, int max)// числа которые меньше мин. значения - отсеиваются
        {
            return i > max;
        }
        static public bool DrobValues(int i, int min)// из минимальных  чисел отсеиваются чётные числа 
        {
            return (i < min) && i % 2!=0;

        }
        static public bool NonDrobValues(int i, int min)// из минимальных  чисел отсеиваются нечётные числа 
        {
            return (i < min) && i % 2 == 0;
        }

        static public List<int> Values(MyMin mymin,int min, int [] list)
        {
            List<int> newListMins = new List<int>();
            for(int i = 0; i < list.Length; i++)
            {
                if (mymin(list[i], min))
                {
                    newListMins.Add(list[i]);

                }

            }
            return newListMins;

        }




        static public void MenuForFunction(List<MyMin> list) 
        {
            Console.Clear();
            Console.Title = "Deligations";
            int[] array = new int[20];
            Random rand = new Random();

            for(int i = 0; i < array.Length; i++) {
                array[i] = rand.Next(1,157);
            }
            Console.WriteLine("Представлен массив из 20 эллементов, заполненный рандомными числами");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("Выберите метод сортировки:  ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("1: числа которые больше мин. значения - отсеиваются");
            Console.WriteLine("2: числа которые меньше мин. значения - отсеиваются");
            Console.WriteLine("3: из минимальных  чисел отсеиваются чётные числа");
            Console.WriteLine("4: из минимальных  чисел отсеиваются нечётные числа");
            Console.WriteLine("0: ГЛАВНОЕ МЕНЮ");
            Console.WriteLine("-------------------------------------------------------------------");

            bool nonInt = false;

            while (nonInt == false)
            {
                
                int vibor = 0;
                nonInt =  int.TryParse(Console.ReadLine(), out vibor);
                List<int> newList = new List<int>();
                if(vibor == 0)
                {

                    Program.Menu();
                    break;

                }
                else if(vibor == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Представлен массив из 20 эллементов, заполненный рандомными числами");
                    Console.WriteLine();
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + "   ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------");
               
                    Console.WriteLine("Введите число, выше которого числа будут отсеяны");
                   int min =  Convert.ToInt32(Console.ReadLine());
                    newList =  Values(list[0], min, array);







                    Console.WriteLine("Числа отсортированны!");
                    for (int i = 0; i < newList.Count; i++)
                    {
                        Console.Write(newList[i] + "   ");
                    }
                    Console.ReadKey();
                    Program.Menu();


                }
                else if(vibor == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Представлен массив из 20 эллементов, заполненный рандомными числами");
                    Console.WriteLine();
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + "   ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------");
                    
                    Console.WriteLine("Введите число, меньше которого числа будут отсеяны вместе с чётными числами");
                    int min = Convert.ToInt32(Console.ReadLine());
                    newList = Values(list[1], min, array);







                    Console.WriteLine("Числа отсортированны!");
                    for (int i = 0; i < newList.Count; i++)
                    {
                        Console.Write(newList[i] + "   ");
                    }
                    Console.ReadKey();
                    Program.Menu();

                }
                else if(vibor == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Представлен массив из 20 эллементов, заполненный рандомными числами");
                    Console.WriteLine();
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + "   ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------");
                   
                    Console.WriteLine("Введите число, выше которого числа будут отсеяны вместе с не чётными числами");
                    int min = Convert.ToInt32(Console.ReadLine());
                    newList = Values(list[2], min, array);









                    Console.WriteLine("Числа отсортированны!");
                    for (int i = 0; i < newList.Count; i++)
                    {
                        Console.Write(newList[i]+ "   ");
                    }
                    Console.ReadKey();
                    Program.Menu();
                }
                else if (vibor == 4)
                    Console.Clear();
                {
                    Console.WriteLine("Представлен массив из 20 эллементов, заполненный рандомными числами");
                    Console.WriteLine();
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write(array[i] + "   ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------");
                  
                    Console.WriteLine("Введите число, выше которого числа будут отсеяны, вместе с чётными числами");
                    int min = Convert.ToInt32(Console.ReadLine());
                    newList = Values(list[3], min, array);





                    Console.WriteLine("Числа отсортированны!");
                    for (int i = 0; i < newList.Count; i++)
                    {
                        Console.Write(newList[i] + "   ");
                    }
                    Console.ReadKey();
                    Program.Menu();
                }



            }








        }

        static public  void WorkWithFunction()
        {
            List<MyMin> list = new List<MyMin>();
            list.Add(MinValues);
            list.Add(MaxValues);
            list.Add(DrobValues);
            list.Add(NonDrobValues);

            MenuForFunction(list);
        }





    }
}
