using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("=== Задние 2 ===\n");
            Console.WriteLine("--- 1 ---");
            DescribeSubject wire = new DescribeSubject("Провод", new DescribeМаterial("сталь", 7850), 0.03);
            Console.WriteLine("--- 2 ---");
            Console.WriteLine(wire.ToString());
            Console.WriteLine("--- 3 ---");
            wire.SetMaterial(new DescribeМаterial("медь", 8500));
            Console.WriteLine(wire.ToString());
            Console.ReadKey();
        }
    }
}
