using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfoninProgramm
{
    public  class Class 
    {
        #region "ПОЛЯ КЛАССА"
        public int re;
        public int im;
        #endregion


        #region "СВОЙСТВА ПОЛЕЙ ПЕРЕМЕННЫХ" (возможен анализ)
        public int Re
        {
            get { return re; }
            set { re = value; }
        }
        public int Im
        {
            get { return im; }
            set { im = value; }
        }
        #endregion


        #region "КОНСТРУКТОРЫ" (при выделении памяти для нового объекта)
        public Class(int re, int im)
            {
            this.re = re;
            this.im = im;

            }
        public Class()
        {

        }
        #endregion


        #region "ПРЕДОПРЕДЕЛЕНИЕ МЕТОДА" (ToString)
        public override string ToString()
            {
                return $"Комплексное число =  {re} +  {im}";
            }
        #endregion



        #region "ГЛАВНЫЕ МЕТОДЫ ОПЕРАЦИЙ"
        //сумма
        static public Class Summ(int re1, int re2, int im1, int im2)
            {
                Class resultSumm = new Class(re1 + re2, im1 + im2);

                return resultSumm;
            }
            //отрицание
            static public Class Min(int re1, int re2, int im1, int im2)
            {
            Class resultSumm = new Class(re1 - re2, im1 - im2);

                return resultSumm;
            }
            //деление
            static public Class Del(int re1, int re2, int im1, int im2)
            {
            Class resultSumm = new Class(re1 / re2, im1 / im2);

                return resultSumm;
            }
            //умножение
            static public Class Umn(int re1, int re2, int im1, int im2)
            {
            Class resultSumm = new Class(re1 * re2, im1 * im2);

                return resultSumm;
            }

        #endregion



    }
}
