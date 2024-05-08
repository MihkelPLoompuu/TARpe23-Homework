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
        public double Diameter12;
        public double Radiusend;
        public double Radius12;
        public double MM;
        public double NN;
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
            Console.WriteLine($"radius is : {B} cm");
            Radiusend = B;
            return Radiusend;
        }
        public double Circumeference()
        {
            double C = 2 * 3.14 * Radiusend;
            MM = C;
            return MM;
        }
        public void Radius1(double A) 
        {
            double B = A/2;
            Console.WriteLine($"Radius is :{B}");
            Radius12 = B;
        }
        public void Diameter1() 
        {
            int A = (int)(Radius12 * 2);
            Console.WriteLine($"Diameter is :{A}");
            Diameter12 = A;
        }
        public Circle() 
        {
            diameter();
            radius();            
            Circumeference();
            Console.WriteLine($"Diameter is : {Diameter} cm , radius is : {Radiusend} cm and Circumeference" +
                $"is {MM} cm");
        } 
        public Circle(double A) 
        {
            Radius1(4);
            Diameter1();
            double C = 2 * 3.14 * Radius12;
            Console.WriteLine($"Diameter is : {Diameter12} cm , radius is : {Radius12} cm and Circumeference" +
                $"is {C} cm");
        }
    }
}
