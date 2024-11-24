using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void CalcCub (double h, out double s, out double v)
        {
            s = 6 * (h * h);
            v = h * h * h;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра");
            double h = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            CalcCub(h, out s, out v);
            Console.WriteLine("{0} {1}",s,v);
            Console.ReadKey();
        }
    }
}
