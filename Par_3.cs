using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_3
    {
        string text = "This is an example English text";
        public void Start()
        {
            Console.WriteLine($"Текст набран {(IsEnglishText(text) ? "" : "не ")}на английском языке");
        }
        bool IsEnglishText(string text)
        {
            StringBuilder englishLetters = new StringBuilder("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
            foreach (char c in text)
                if (!englishLetters.ToString().Contains(c))
                    return false;
            return true;
        }
    }
}

