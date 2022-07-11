using System;

namespace LevanovExamCSharp
{
    [Serializable]

    public class Gymnast : Sportsman
    {
        public double Ring { get; set; }
        public double Bars { get; set; }
        public double Jump { get; set; }
        public Gymnast() { }
        public Gymnast(string surname, int age) : base(surname, age, "Гимнаст") { }

        public override double BestResult()
        {
            return Math.Max(Ring, Math.Max(Bars, Jump));
        }

        public static bool operator <(Gymnast a, Gymnast b) => a.Ring + a.Bars + a.Jump < b.Ring + b.Bars + b.Jump;
        public static bool operator >(Gymnast a, Gymnast b) => a.Ring + a.Bars + a.Jump > b.Ring + b.Bars + b.Jump;
    }
}
