using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_4
    {
        string text = "Настало утро. Начинался очередной день.";
        public void Start()
        {
            StringBuilder result = new StringBuilder();
            foreach (char letter in text)
            {
                result.Append(letter);
                if (letter == 'о' || letter == 'О')
                    result.Append("Ок");
            }
            Console.WriteLine(result.ToString());
        }
    }
}

