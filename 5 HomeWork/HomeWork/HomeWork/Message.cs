using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
//2.Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
namespace HomeWork
{
    internal class Message
    {

        //метод выводит только те слова сообщения, которые содержат не более 'count' букв.
        // и выводит на концоль

        public static void PrintWords(string message, int count)
        {
            string[] separators = {" "};
                string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Length <=  count )
                {
                    Console.WriteLine(words[i]);


                }



            }

        }
        //метод удаляет из сообщения все слова, которые заканчиваются на заданный 'simbole'.&& words[i][0].Equals( words[i][words[i].Length-1])
        // и выводит на концоль
        public static void DellWord(string message, char simbole)
        {

            string[] separators = { " " };
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][words[i].Length-1] == simbole)
                {
                    Console.WriteLine(words[i]);

                }



            }

        }
       // Метод возвращает  самое длинное слово сообщения.
        public static string MaxValue(string message)
        {

            int maxLength = 0;
            string maxWord = "";
            string[] separators = { " " };
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= maxLength)
                {
                    maxWord = words[i];

                }



            }
            return maxWord;
        }
        //Сформировать строку с помощью StringBuilder из самых длинных слов сообщения 'count(LENGTH)'.
        // и выводит на концоль

        public static void MaxValueStringBuilder(string message, int length)
        {
            StringBuilder stringBuilder = new StringBuilder(1000);

            string[] separators = { " ",     ",",    " :",      ";",    "!",    " ? ",      " . " };
            string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= length)
                {
                   stringBuilder.Append(words[i]);


                }



            }

            Console.WriteLine(stringBuilder.ToString());

        }



    }
}







