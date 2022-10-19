using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            Exist();

       
        }


        static void Exist()
        {
            


            string[] array = new string[4];

            if(File.Exists("LogPass.txt"))// streamReader.ReadToEnd()
            {
                StreamReader streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "LogPass.txt");
                if(!streamReader.EndOfStream)
                {

                    for (int i = 0; i < 4; i++)
                    { array[i] = streamReader.ReadLine(); }


                }
                
                streamReader.Close();

                if (array[3] == "1")
                {

                    Profile.AutorizationLogin(ref array);


                }
                else { CheckLogin.InputLogin();  }

            }
            else
            {
                CheckLogin.InputLogin();
               
            }



        }











    }
}
