using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_on_Encapsulation
{
    public class Rectangle
    {
        int height, width;
        public setDimension(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        void showArea()
        {
            Console.WriteLine($"Area: {height * width}");
        }
        int getArea() { return height * width; }
    }
}
