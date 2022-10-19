using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLib
{
    public class ArrayClass
    {
        #region "ПОЛЯ" 
        private int[] myArray;
        private int[] myArrayInverse;//массив с инвертированными значениями
        
        
       
        
        #endregion


        #region "СВОЙСТВО ИНДЕКСАЦИИ"  

        //(ИНДЕКСАЦИЯ)
        public int this[int index]
        {

            get
            {
                return myArray[index];
            }
            set
            {
                myArray[index] = value;

            }

        }
        #endregion

        #region СВОЙСТВО SUM
        //сумма всех эллементов массива
        public int Sum
        {

           
          
            get
            {
                int sum = 0; //сумма всех эллементов массива
                for (int i = 0; i < myArray.Length; i++)
                {
                    sum = sum + myArray[i];
                }

                return sum;
            }
            
        }

        #endregion

        #region СВОЙСТВО MAXCOUNT
        //свойство возвращающее максимальное число из массива
        public int MaxCount  
        {
            get
            {
                int maxCount = 0; //максимальное число массива

                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] > maxCount)
                    {
                        maxCount = myArray[i];
                    }
                }

                return maxCount;

            }

        }



        #endregion



        #region "Конструктор для указания размера массива

        //конструктор для указания размера массива *length - длинна
        public ArrayClass(int length)
        {

            try
            {
                myArray = new int[length];
            }
            catch
            {
                throw new Exception("Число должно быть целым!");
            }

        }
        #endregion

        #region Конструктор рандомных чисел
        //конструктор для указания размера массива и заполняющий массив числами от начального значения с заданным шагом (от начала)
        // значения заполняются рандомными числами(от 0 до 250) *Shag - шаг
        public ArrayClass(int length, int Shag)
        {
            if (Shag < 0)
            {
                Shag = Shag * -1;
            }
            Random random = new Random();

            //Создание исключения
            try
            {
                myArray = new int[length];
            }
            catch
            {
                throw new Exception("Число должно быть целым!");
            }


            //заполнение массива объекта рандомными числами (от 0 до 250)
            if (Shag > myArray.Length)
            {
                Shag = myArray.Length;
            }
            for (int i = 0; i < Shag; i++)
            {
                myArray[i] = random.Next(0, 251);
            }
        }
      

        #endregion



        #region "МЕТОД INVERSE"

        //инвертировать знаки у уже созданного массива (результат этого метода - возвращение нового массива)
        public  int[] Inverse()
        {

        myArrayInverse = new int[myArray.Length];

        for(int i = 0; i < myArray.Length; i++)
            {
                myArrayInverse[i]  =  myArray[i] * -1 ;
            }

        return  myArrayInverse;

        }
        #endregion

        #region "МЕТОД MULTI"
        //метод Multi, умножающий каждый элемент массива на определённое число(multi)
        //(старый массив изменяется!)

        public void Multi(int multi)
        {
           
            for(int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = myArray[i] * multi;
            }
            
        }






        #endregion


    }
}
