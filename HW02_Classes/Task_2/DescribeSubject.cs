using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp1
{
    class DescribeSubject
    {
        private DescribeМаterial material;
        private string name;
        private double volume;
 
        public DescribeSubject() { }
        public DescribeSubject(string name, DescribeМаterial material, double volume)
        {
            this.name = name;
            this.material = material;
            this.volume = volume;
        }
 
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
 
        public DescribeМаterial GetMaterial()
        {
            return material;
        }
        public void SetMaterial(DescribeМаterial material)
        {
            this.material = material;
        }
 
        public double GetVolune()
        {
            return volume;
        }
        public void SetVolune(double volume)
        {
            this.volume = volume;
        }
 
        public double GetMass()
        {
            return material.GetDensity() * volume;
        }
 
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3}",name, material, volume, GetMass());
 
        }
    }
}
