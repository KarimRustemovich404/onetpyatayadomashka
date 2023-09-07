using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace онет_пятая_домашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение а:");
            var A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b:");
            var B = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение c:");
            var C = double.Parse(Console.ReadLine());

            double x1, x2;

            var D = B * B - 4 * A * C;
            if (D < 0)
            { Console.WriteLine("Уравнение не имеет решений"); }

            else
                if (D == 0)
                x1 = -B / (2 * A);
                x2 = -B / (2 * A);
            else
                x1 = -B + Math.Sqrt(D) / (2 * A);
                x2 = -B - Math.Sqrt(D) / (2 * A);

            Console.WriteLine($"x1={x1}; x2={x2}");
        }
    }
}
