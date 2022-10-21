using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project
{
    public class Engine
    {
        private string fileName;
        private List<Question> list;

        public Engine(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        public int Count { get { return list.Count; } }

        public Question this[int index] { get { return list[index]; } }

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(trueFalse, text));
        }
        public void Remove(int index)
        {
            if(index>=0 && index < list.Count)
            {
                list.RemoveAt(index);
            }
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlSerializer.Deserialize(fileStream);
            fileStream.Close();
        }
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fileStream, list);
            fileStream.Close();
        }
    }
}
