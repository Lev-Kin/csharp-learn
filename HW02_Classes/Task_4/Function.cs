using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp1
{
    class Function
    {
        private double a;
        private double b;
 
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
 
        public double F(double x)
        {
            return (1 + Math.Pow(Math.Cos(x + a), 2)) /
                        Math.Abs(Math.Pow(x,  3) - 2 * Math.Pow(b, 2));
        }
 
        static public void Input(out double begin, out double end, out double step)
        {
            do
            {
                Console.Write("Нaчальное значение x = ");
                begin = double.Parse(Console.ReadLine());
                Console.Write("Конечное  значение x = ");
                end = double.Parse(Console.ReadLine());
                Console.Write("     Шаг изменения x = ");
                step = double.Parse(Console.ReadLine());
            } while (step < 0);
        }
 
        override public string ToString()
        {
            return $"f(x) = 1 + cos^2(x + {a}) / | x^3 - {2 * Math.Pow(b, 2)} |";
        }
 
        public void TabulationFunction(double begin, double end, double step)
        {
            Table table = new Table(ToString(), "x", 10, "f(x)", 15);
            table.Up();
            for (
                double x = begin;
                     begin < end ? x <= end : x >= end;
                x += begin < end ? step : -step
                )
                table.Middle(x, F(x));
            table.Down();
        }
    }
}
