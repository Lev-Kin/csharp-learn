using System;

namespace LevanovExamCSharp
{
    [Serializable]

    public abstract class Sportsman
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }
        public Sportsman() { }
        public Sportsman(string name, int age, string kind)
        {
            Name = name;
            Age = age;
            Kind = kind;
        }

        public abstract double BestResult();
    }
}
