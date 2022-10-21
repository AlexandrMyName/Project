using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DateTimeConsole
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
          DateTime author =   LoadFromXML(AppDomain.CurrentDomain.BaseDirectory + "file.xml");

            Console.WriteLine($"АВТОР: {author.Author}  |  УРОК:  {author.Lesson}");


            Console.ReadLine();
        }

       static public DateTime LoadFromXML(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DateTime));
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
           DateTime dateTime =  (DateTime)xmlSerializer.Deserialize(file);
            file.Close();
            return dateTime;
        }
        static public void SaveToXML(string fileName,DateTime dateTime)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DateTime));
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Write);
           xmlSerializer.Serialize(file,dateTime);
            file.Close();
            
        }


    }



    public struct DateTime
    {
        public string Author { get; set; }
        public int Lesson { get; set; }

    }
}
