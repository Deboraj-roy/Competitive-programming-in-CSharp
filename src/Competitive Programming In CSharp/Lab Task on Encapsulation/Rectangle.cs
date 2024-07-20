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
            if (initialize)
            { 
                Console.WriteLine($"Area: {height * width}");
            }
            else
            {
                Console.WriteLine("Hight: ");
                var hight = int.Parse(Console.ReadLine());
                Console.WriteLine("Width: ");
                var Width = int.Parse(Console.ReadLine());
                setDimension(hight, Width);
                showArea();
            }
        }
        public int getArea()
        {
            if (initialize)
            { 
                return height * width;
            }
            else
            {
                Console.WriteLine("Hight: ");
                var hight = int.Parse(Console.ReadLine());
                Console.WriteLine("Width: ");
                var Width = int.Parse(Console.ReadLine());
                setDimension(hight, Width);
                return getArea();
            }
            
        }
    }
}
