using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4;
/*
Task 4
Write a class called Box which contains three member variables; length, width and height. This class also contains
two constructors, one empty and another one is with parameter. You also have to write a function named
getArea() that calculates and returns the area of a box object. Write necessary code inside the main function to
test the class by creating an object.*/
namespace Task_4
{
    public class Box
    {
        double length, width, height;
        public Box()
        {
        }
        public Box(double a, double b, double c)
        {
            this.length = a;
            this.width = b;
            this.height = c;
        }
        public double getArea()
        {
            return 2*((length * width) + (width * height) + (height * length));
        }
    }
}
