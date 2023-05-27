using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string i = "";
            double a, b, c = 0;
            int n;
            while (i != "N" && i != "n")
            {
                Console.WriteLine("Введите первое число:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nВведите второе число:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nВыберите операцию:\n1. Сложить\n2. Вычесть\n3. Умножить\n4. Разделить");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (n == 1) { c = a + b; i = " + "; }
                if (n == 2) { c = a - b; i = " - "; }
                if (n == 3) { c = a * b; i = " * "; }
                if (n == 4) if (b == 0) Console.WriteLine("Ошибка"); else { c = a / b; i = " / "; }
                Console.WriteLine("Результат:\n" + a + i + b + " = " + c + "\n\nПовторить (Y/N)?");
                i = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
