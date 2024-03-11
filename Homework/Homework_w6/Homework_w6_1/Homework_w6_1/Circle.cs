using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_w6_1
{
    internal class Circle
    {
        public double Radius;
        public double Diameter;
        public double Radiusend;
        public double MM;
        private double diameter()
        {
            try
            {
                Console.Write("Enter diameter : ");
                double A = Convert.ToInt32(Console.ReadLine());
                Diameter = A;
                return Diameter;                
            }
            catch 
            {
              Console.WriteLine("Valus are not set");
            }
            return Diameter;
        }
        private double radius()
        {
            Radius = Diameter;
            double B = Radius / 2;
            //Console.WriteLine($"radius is : {B} cm");
            Radiusend = B;
            return Radiusend;
        }
        public double Circumeference() 
        {
            double C = 2 * 3.14 * Radiusend;
            //Console.WriteLine(C);
            MM = C;
            return MM;
        } 
        public Circle() 
        {
            diameter();
            radius();
            Circumeference();
            Console.WriteLine($"Diameter is : {Diameter} cm , radius is : {Radiusend} cm and Circumeference" +
                $"is {MM} cm");
        } 
    }
}
