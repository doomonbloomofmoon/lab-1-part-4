using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_8
    {
        string text = "Мой номер: 8963401. Номер моего друга: 6743904.";
        public void Start()
        {
            Console.WriteLine($"Текст:\n{text}\n");
            List<string> phoneNumbers = ExtractPhoneNumbers(text);
            Console.WriteLine("Найденные телефонные номера:");
            foreach (string phoneNumber in phoneNumbers)
                Console.WriteLine(phoneNumber);
        }
        static List<string> ExtractPhoneNumbers(string text)
        {
            List<string> phoneNumbers = new List<string>();
            StringBuilder currentNumber = new StringBuilder();
            bool isInsideNumber = false;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    isInsideNumber = true;
                    currentNumber.Append(c);
                }
                else if (isInsideNumber)
                {
                    if (currentNumber.Length == 7)
                        phoneNumbers.Add(currentNumber.ToString());
                    currentNumber.Clear();
                    isInsideNumber = false;
                }
            }
            if (isInsideNumber && currentNumber.Length == 7)
                phoneNumbers.Add(currentNumber.ToString());
            return phoneNumbers;
        }
    }
}


