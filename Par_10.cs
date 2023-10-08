using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_10
    {
        string text = "Сегодня мне написали с подозрительной почты itsnotdangerfile@srt.com";
        public void Start()
        {
            Console.WriteLine($"Исходный текст:\n{text}\n");
            Console.WriteLine("Найденные e-mail адреса:");
            List<string> emailAddresses = ExtractEmailAddresses(text);
            foreach (string email in emailAddresses)
                Console.WriteLine(email);
        }
        public static List<string> ExtractEmailAddresses(string text)
        {
            List<string> emailAddresses = new List<string>();
            string[] words = text.Split(' ');
            foreach (string word in words)
                if (word.Contains("@") && word.Contains("."))
                    emailAddresses.Add(word);
            return emailAddresses;
        }
    }
}


