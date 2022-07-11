using System;
using System.Linq;

namespace LevanovExamCSharp
{
    [Serializable]

    public class Swimmer : Sportsman
    {
        public double[] Swim { get; set; }

        public override double BestResult()
        {
            return Swim.Min();
        }

        public Swimmer() { }
        public Swimmer(string surname, int age) : base(surname, age, "Пловец") { }
        public double AverageResult(params int[] swim) => Swim.Where((r, i) => swim.Contains(i)).Average();
    }
}
