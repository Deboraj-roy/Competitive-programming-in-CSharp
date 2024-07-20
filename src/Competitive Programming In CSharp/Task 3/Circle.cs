using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task_3
{
    public class Circle
    {
        double radius;
        bool set = false;
        public void setRadius(double r)
        { 
            radius = r; 
            set = true;
        }

        public void getArea()
        {
            if (set)
            {
                double Area = Math.PI * radius * radius;
                Console.WriteLine("Area: " + Area);
            }
            else
            {
                setRadius();
                getArea();
            }
        }
        public void getCircumference()
        {
            if (set)
            {
                double Circumference = 2 * Math.PI * radius;
                Console.WriteLine("Circumference: " +  Circumference);
            }
            else
            {
                setRadius();
                getCircumference();
            }
        } 

        void setRadius()
        {
            Console.Write("Enter Radius: ");
            var r = double.Parse(Console.ReadLine());
            //var e = double.Pi;
            setRadius(r);
        }

    }
}
