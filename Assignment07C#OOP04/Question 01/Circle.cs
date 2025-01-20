using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07C_OOP04.Question_01
{
    public  class Circle : ICircle
    {
        public double Radius { get; set; }

        public Circle( double radius)
        {
            Radius = radius;
        }
        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius : {Radius},  Area: {Area}");
        }
    }
}
