using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_7
    {
        string text = "Информатика это наука. Информатика помогает решить множество проблем.";
        string findWord = "Информатика";
        public void Start()
        {
            Console.WriteLine($"Введенный текст:\n{text}\n");
            int count = 0;
            string[] sentences = text.Split(new char[] { '.', '!', '?' });
            foreach (string sentence in sentences)
                if (!string.IsNullOrWhiteSpace(sentence) && sentence.TrimStart().StartsWith(findWord))
                    count++;
            Console.WriteLine($"Количество предложений, начинающихся со слова \'{findWord}\': {count}");
        }
    }
}

