using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_on_Encapsulation
{
    public class Rectangle
    {
        public int height, width;
        public bool initialize = false;
        public void setDimension(int height, int width)
        {
            this.height = height;
            this.width = width;
            initialize = true;
        }

        public void showArea()
        {
            Console.WriteLine($"Area: {height * width}");
        }
        public int getArea() { return height * width; }
    }
}
