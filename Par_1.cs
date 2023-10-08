using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_1
    {
        string text = "Что Слава? — Яркая заплата\nНа ветхом рубище певца.\nНам нужно злата, злата, злата:\nКопите злато до конца!";
        public void Start()
        {
            Console.WriteLine($"Исходный текст:\n{text}\n");
            string word = "злата";
            StringBuilder sb = new StringBuilder(text);
            int count = 0;
            int i = -1;
            while ((i = sb.ToString().IndexOf(word, i + 1, StringComparison.OrdinalIgnoreCase)) != -1)
                count++;
            Console.WriteLine($"Искомое слово \'{word}\' появилось в тексте {count} раз.");
        }
    }
}

