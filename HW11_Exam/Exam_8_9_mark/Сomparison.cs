using System.Collections.Generic;

namespace LevanovExamCSharp
{
    class Сomparison : IComparer<Sportsman>
    {
        public int Compare(Sportsman a, Sportsman b) => a.Age.CompareTo(b.Age);
    }
}

