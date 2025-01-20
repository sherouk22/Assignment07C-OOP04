using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07C_OOP04.Question_01
{
    public class Rectanglee : IRectangle
    {

       public  double Width { get; set; }
       public double Heigth { get; set; }

        public Rectanglee(double width, double height)
        {
           Width = width;
           Heigth = height;
        }
        public double Area { get => Width * Heigth; }
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($" Width: {Width}, Height: {Heigth}  Area: {Area}");
        }
    }
}
