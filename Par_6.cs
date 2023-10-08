using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_6
    {
        string text = "Язык C# был разработан в 1998–2001 годах группой инженеров компании Microsoft";
        public void Start()
        {
            Console.WriteLine($"Текст {(ContainsNumbers(text) ? "" : "не ")}содержит цифры");
        }
        bool ContainsNumbers(string text)
        {
            foreach (char c in text)
                if (char.IsDigit(c))
                    return true;
            return false;
        }
    }
}

