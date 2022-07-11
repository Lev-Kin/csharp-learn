using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp1
{
    class Circle
    {
		private double r;
		public double X { get; private set; }
		public double Y { get; private set; }
 
		public Circle()
		{
			X = 0;
			Y = 0;
			R = 1;
		}
		public Circle(double x, double y, double r)
		{
			X = x;
			Y = y;
 
			// корректность введенных данных
			if (r <= 0) r = 1;
 
			R = r;
		}
 
        public double R
		{
			get => r;
			set => r = value < 0 ? 1 : value;
		}
		public double L
		{
			get => 2 * Math.PI * R;
		}
 
		public bool Fourth() => Math.Abs(X) > R && Math.Abs(Y) > R;
 
		// Метод для перемещения окружности по вертикали вниз или по горизонтали влево 
		// (в зависимости от значения соответствующего параметра) на заданную величину.
		public void Move(double m, int direction)
		{
			if(direction == 1)
				X += m;
			if(direction == 2)
				Y += m;
		}
 
		// Метод для увеличения радиуса окружности на заданную величину.
		public void Increase(double m)
		{
			R += m;
 
			// корректность введенных данных
			if (m <= 0) R = 1;
		}
 
		// Статический метод для проверки, пересекаются ли две окружности
		// (входные параметры – объекты класса, результат true или false).
		static public bool Intersecting(Circle circle1, Circle circle2)
		{
			return Math.Sqrt(Math.Pow(circle2.X - circle1.X, 2) +
				Math.Pow(circle2.Y - circle1.Y, 2))
				> circle1.R + circle2.R;
		}
	}
}

