using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Question
    {
        public bool TrueFalse { get; set; }
        public string Text { get; set; }


        public Question(bool trueFalse, string text)
        {
            TrueFalse = trueFalse;
            Text = text;
        }
        public Question() { }
    }
}
