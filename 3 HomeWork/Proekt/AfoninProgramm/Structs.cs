using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfoninProgramm
{
    public class Structs
    {
        #region "ГЛАВНАЯ СТРУКТУРА"
        public struct Complex
        {
            #region "ПОЛЯ СТРУКТУРЫ"
            public int re;
            public int im;
            #endregion

            #region "ПРЕДОПРЕДЕЛЕНИЕ МЕТОДА" (ToString)
            public override string ToString()
            {
                return $"Комплексное число =  {re} +  {im}";
            }
            #endregion

            #region "ГЛАВНЫЕ МЕТОДЫ ОПЕРАЦИЙ"
            //сумма
            static public Complex Summ(int re1, int re2, int im1, int im2)
            {
                Complex resultSumm = new Complex();

                resultSumm.re = re1 + re2;
                resultSumm.im = im1 + im2;


                return resultSumm;
            }
            //отрицание
            static public Complex Min(int re1, int re2, int im1, int im2)
            {
                Complex resultSumm = new Complex();

                resultSumm.re = re1 - re2;
                resultSumm.im = im1 - im2;


                return resultSumm;
            }
            //деление
            static public Complex Del(int re1, int re2, int im1, int im2)
            {
                Complex resultSumm = new Complex();

                resultSumm.re = re1 / re2;
                resultSumm.im = im1 / im2;


                return resultSumm;
            }
            //умножение
            static public Complex Umn(int re1, int re2, int im1, int im2)
            {
                Complex resultSumm = new Complex();

                resultSumm.re = re1 * re2;
                resultSumm.im = im1 * im2;


                return resultSumm;
            }
            #endregion

            
        }
        #endregion

    }
}
