
namespace ProjectCSharp
{
    class Rectangle : Polygon
    {
        public Rectangle(params int[] side) : base("Прямоугольник", side) { }

        public int Width
        {
            get
            {
                return Dot[0];
            }
            set
            {
                Dot[0] = value;
            }
        }
        public int Heigth
        {
            get
            {
                return Dot[1];
            }
            set
            {
                Dot[1] = value;
            }
        }

        public int P()
        {
            return (Dot[0] + Dot[1]) * 2;
        }

        public override int S()
        {
            return Width * Heigth;
        }

        public override string ToString()
        {
            return base.ToString() + $"║{P(),10}║";
        }
    }
}

