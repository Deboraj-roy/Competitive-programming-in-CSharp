using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Calculator
    {
        double myValue;
        bool initialize = false;
        public void setValue(double value)
        { myValue = value; initialize = true; }
        public void square() 
        {
            //Console.WriteLine("Square: " + myValue * myValue);

            if (initialize)
            {
                Console.WriteLine("Square: " + myValue * myValue);
            }
            else
            {
                solution();
                square();
            }
        }
        public void qube()
        {
            //Console.WriteLine("Qube: " + myValue * myValue * myValue);

            if (initialize)
            {
                Console.WriteLine("Qube: " + myValue * myValue * myValue);
            }
            else
            {
                solution();
                qube();
            }

        }

        void solution()
        {
            Console.WriteLine("Enter a Double Value");
            var value = double.Parse(Console.ReadLine());
            setValue(value);
        }

    }
}
