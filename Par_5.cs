using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_5
    {
        string text = "Пример текста для проверки кода";
        public void Start()
        {
            Console.WriteLine($"Текст набран {(IsRussianText(text) ? "" : "не ")}на русском языке");
        }
        bool IsRussianText(string text)
        {
            StringBuilder russianLetters = new StringBuilder("абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
            foreach (char c in text)
                if (!russianLetters.ToString().Contains(c))
                    return false;
            return true;
        }
    }
}

