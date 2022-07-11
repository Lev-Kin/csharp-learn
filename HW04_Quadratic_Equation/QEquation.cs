using System;
 
namespace ProjectC_sharp
{
    class QEquation
    {
        double a, b, c;
        string result;
 
        public QEquation()
        {
            a = 1;
            b = 0;
            c = 0;
            result = null;
        }
        public QEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double A
        {
            set
            {
                a = value;
            }
        }
        public double B
        {
            set
            {
                b = value;
            }
        }
        public double C
        {
            set
            {
                c = value;
            }
        }
 
        public double Discriminant
        {
            get
            {
                return (b * b - 4 * a * c);
            }
        }
 
        public override string ToString()
        {
            if (b == 0 && c == 0)
            {
                result = "1";
                return $"x^2 = {result}";
            }
            else
                return ($"{a}x^2 + ({b}) * x + ({c}) = 0");
        }
 
        public string Radical()
        {
            if (Discriminant > 0)
            {
                double x1 = (double)(-1 * b + Math.Sqrt(Discriminant)) / (2 * a);
                double x2 = (double)(-1 * b - Math.Sqrt(Discriminant)) / (2 * a);
                Console.WriteLine("x1 = {0:f2}; x2 = {1:f2}", x1, x2);
 
                return result = x1.ToString() + x2.ToString();
            }
            else if (Discriminant == 0)
            {
                double x = (double)(-1 * b) / (2 * a);
                Console.WriteLine("x = {0:f2}", x);
                return result = x.ToString();
            }
            else
                Console.WriteLine("Корней нет");
 
            return "";
        }
 
        public static bool Сompare(QEquation obj, QEquation obj1)
        {
            if (obj.result == obj1.result)
                return true;
            else
                return false; 
        }
    }
}

