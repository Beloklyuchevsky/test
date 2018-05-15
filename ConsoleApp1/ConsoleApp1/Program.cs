using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диаметр окружности: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Было введено число - " + d);
            if (d > 0)
            {
                d = d * Math.PI;
                Console.WriteLine("Длина окружности =" + d);
                d = Math.Pow(d * 0.5, 2) * Math.PI;
                Console.WriteLine("Площадь окружности =" + d);
            }
            else Console.WriteLine("Диаметр не может быть отрицательным!");
        }




    }
}
