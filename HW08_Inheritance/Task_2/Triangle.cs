using System;

namespace ProjectCSharp
{
    class Triangle : Polygon
    {
        public Triangle(params int[] side) : base("Tреугольник", side) { }

        public int Side1
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

        public int Side2
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

        public int Side3
        {
            get
            {
                return Dot[2];
            }
            set
            {
                Dot[2] = value;
            }
        }

        public int P()
        {
            return Dot[0] + Dot[1] + Dot[2];
        }

        public override int S()
        {
            return (int)Math.Sqrt((P() / 2) * ((P() / 2) - Dot[0]) * ((P() / 2) - Dot[1]) * ((P() / 2) - Dot[2]));
        }

        public override string ToString()
        {
            return base.ToString() + $"║{P(),10}║";
        }
    }
}


