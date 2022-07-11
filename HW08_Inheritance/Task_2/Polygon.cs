using System;

namespace ProjectCSharp
{
    abstract class Polygon : IComparable
    {
        abstract public int S();

        protected string name;
        protected int[] Dot;
        protected int Count { get; set; }

        protected Polygon(string name, int[] dot)
        {
            this.name = name;
            Dot = dot;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Dot.Length; ++i)
            {
                str += Dot[i];
                if (i != Dot.Length - 1)
                {
                    str += ',';
                }
            }
            return $"\t║{name,16}║{str,14}║{S(),12}";
        }

        public int CompareTo(Polygon obj)
        {
            return (S() - obj.S());
        }

        public int CompareTo(object obj)
        {
            if (obj is Polygon polygon)
                return S() - polygon.S();
            else
                throw new Exception("Невозможно сравнить два объекта.");
        }
    }
}
