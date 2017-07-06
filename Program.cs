using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a; // длина
            double b;// ширина
            double c;// длина диагонали 
            double d;// высота 
            double V;// объем
            Console.Write("Введите длину стороны: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину стороны: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину диагонали грани: ");
            c = Convert.ToDouble(Console.ReadLine());
            d = Math.Pow((Math.Pow(c, 2) - Math.Pow(a, 2)), 0.5);
            V = a * b * d;

            Console.WriteLine("Объем параллелепипеда равен: {0}", V);
            Console.ReadKey();
        }
    }

}
