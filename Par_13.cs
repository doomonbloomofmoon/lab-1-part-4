using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_13
    {
        string text = "Багровый и белый отброшен и скомкан,\nв зеленый бросали горстями дукаты,\nа черным ладоням сбежавшихся окон\nраздали горящие желтые карты.";
        public void Start()
        {
            int consonantCount = 0;
            string consonants = "бвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ";
            var words = new Collection<char>();
            foreach (char c in text)
                if (consonants.Contains(c))
                    if (!words.Contains(c))
                    {
                        consonantCount++;
                        words.Add(c);
                    }
            Console.WriteLine($"Ввод:\n{text}\n");
            Console.WriteLine("Буквы:");
            foreach (var word in words)
                Console.Write(word.ToString() + " ");
            Console.WriteLine($"\nВсего букв: {consonantCount}");
        }
    }
}

