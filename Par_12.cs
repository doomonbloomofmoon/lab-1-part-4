using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_12
    {
        string text = "Строит, рушит, кроит и рвет, тихнет, кипит и пенится...";
        public void Start()
        {
            Console.WriteLine($"Ввод:\n{text}\n");
            Console.WriteLine("Вывод:");
            string[] words = text.Split(' ');
            foreach (string word in words)
                Console.WriteLine(word);
        }
    }
}

