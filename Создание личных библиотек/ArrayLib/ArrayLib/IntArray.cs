using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLib
{
    public class IntArray
    {
        #region "Поля"


        private int[] intArray;

        private int[] loadFromFileInt;

        private int sum;
        private int max;
        private int min;

        #endregion


        #region "Свойства"
        public int this[int index] // свойство индексации
        {
            get { return intArray[index]; }

            set { intArray[index] = value; }
           
        }

        public int Sum //сумма всех эллементов массива
        {
            get
            {
                sum = 0;

                for(int i = 0; i < intArray.Length; i++)
                {
                    sum += intArray[i];

                }

                return sum; 
            
            }
        }
        public int Max // максимальное число массива
        {
            get
            {
                 max = 0;

                for(int i = 0; i < intArray.Length; i++)
                {
                    if(intArray[i] > max)
                    {
                        max = intArray[i];
                    }
                }
                return max;
            }
        }
        public int Min // минимальное число массива
        {
            get
            {
                 min = Max;

                for (int i = 0; i < intArray.Length; i++)
                {
                    if (intArray[i] < min)
                    {
                        min = intArray[i];
                    }
                }
                return min;
            }
        }
        #endregion


        #region "Конструкторы"

        public IntArray(int length) //  создание массива
        {
            intArray = new int[length];

        }

        public IntArray(int length,int min, int max) // создание массива и заполнение случайными числами
        {
            Random r = new Random();
            intArray = new int[length];

            for (int i = 0; i < intArray.Length; i++)
            { intArray[i] = r.Next(min, max); }
            
        }

        #endregion


        

    }
}
