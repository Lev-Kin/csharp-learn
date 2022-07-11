using System;

namespace LevanovExamCSharp
{
    class Table
    {
        public static void Show(Collection<Sportsman> obj)
        {
            Console.WriteLine("╔══════════════╦═══════╦═══════════════╦════════════════╗");
            Console.WriteLine("║     Name     ║  Age  ║     Sport     ║   Best result  ║");
            foreach (var o in obj)
            {
                Console.WriteLine("╠══════════════╬═══════╬═══════════════╬════════════════╣");
                Console.WriteLine("║ {0, -12} ║ {1, -5} ║ {2, -13} ║ {3, -14} ║",
                    o.Name, o.Age, o.Kind, o.BestResult());
            }
            Console.WriteLine("╚══════════════╩═══════╩═══════════════╩════════════════╝");
        }
    }
}
