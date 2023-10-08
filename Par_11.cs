using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_4
{
    internal class Par_11
    {
        string text = "Один человек написал трактат о 7 чудесах света. До нас дошла информация только о 6 чудесах";
        public void Start()
        {
            Console.WriteLine($"Введенный текст:\n{text}\n");
            double product = CalculateProduct(text);
            Console.WriteLine($"Произведение всех чисел: {product}");
        }
        double CalculateProduct(string text)
        {
            StringBuilder numberBuilder = new StringBuilder();
            double product = 1;
            foreach (char c in text)
            {
                if (Char.IsDigit(c) || c == '.')
                {
                    numberBuilder.Append(c);
                }
                else if (numberBuilder.Length > 0)
                {
                    double number;
                    if (double.TryParse(numberBuilder.ToString(), out number))
                        product *= number;
                    numberBuilder.Clear();
                }
            }
            if (numberBuilder.Length > 0)
            {
                double number;
                if (double.TryParse(numberBuilder.ToString(), out number))
                    product *= number;
            }
            return product;
        }
    }
}

