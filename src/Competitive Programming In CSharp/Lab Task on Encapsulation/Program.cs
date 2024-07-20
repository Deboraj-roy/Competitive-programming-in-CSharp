// See https://aka.ms/new-console-template for more information
using Lab_Task_on_Encapsulation;

Console.WriteLine("Hello, World!");
Rectangle rectangle = new Rectangle();
//Rectangle[] rectangle1 = new Rectangle[6];
//List<Rectangle> rectangle2 = new List<Rectangle>();

if(rectangle.initialize!=true)
{
    Console.WriteLine("Hight: ");
    var hight = int.Parse(Console.ReadLine());
    Console.WriteLine("Width: ");
    var Width = int.Parse(Console.ReadLine());
    rectangle.setDimension(hight, Width);
}
rectangle.showArea();
