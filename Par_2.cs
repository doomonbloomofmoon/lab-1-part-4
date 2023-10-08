using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_2
    {
        string text = "<html><body><form><h1>Hello HTML</h1></form></body></html>";
        public void Start()
        {
            Console.WriteLine($"Исходный текст:\n{text}\n");
            bool isHtml = IsHtmlCode(text);
            Console.WriteLine($"Результат: текст {(isHtml ? "содержит" : "не содержит")} в себе HTML код.");
        }
        static bool IsHtmlCode(string text)
        {
            string[] htmlTags = { "<html>", "<form>", "<h1>" };
            foreach (string tag in htmlTags)
                if (!text.Contains(tag))
                    return false;
            return true;
        }
    }
}

