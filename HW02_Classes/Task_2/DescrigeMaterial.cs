using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp1
{
    class DescribeМаterial
    {
        private string name;
        private double density;
 
        public DescribeМаterial() { }
        public DescribeМаterial(string name, double density)
        {
            this.name = name;
            this.density = density;
        }
 
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public double GetDensity()
        {
            return density;
        }
        public void SetDensity(double density)
        {
            this.density = density;
        }
 
        public override string ToString()
        {
            return string.Format("{0};{1}", name, density);
        }
    }
}
