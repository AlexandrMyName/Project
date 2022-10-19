using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    //    Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    public  delegate double MyDelegate(double a, double x);

    internal class Delegation
    {
        
         public static double OneFunction( double a, double x){

            return a*(Math.Pow(x,2));
                
                
          }

         public static double TwoFunction(double a, double x){

            return a * (Math.Sin(x));

          }
        
        public static void ResultOne(MyDelegate myDelegateone, double a, double x){

            myDelegateone(a, x);
            Console.WriteLine($"a* x^2  =  { Convert.ToDouble(myDelegateone(a, x))}");
        }
        public static void ResultTwo(MyDelegate myDelegatetwo, double a, double x) { 

            myDelegatetwo(a, x);
            Console.WriteLine($"a* sin(x)  =   {Convert.ToDouble(myDelegatetwo(a, x))}");
        }
    }
}
