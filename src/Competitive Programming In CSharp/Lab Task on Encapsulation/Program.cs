// See https://aka.ms/new-console-template for more information

/*Task 1
class Rectangle
{
    int width, height;
    public:
void setDimension(int x, int y)
    {
        width = x; height = y;
    }
    void showArea() { cout << width * height; }
    int getArea() { return width * height; }};
a.Define all the member functions of the Rectangle class.
b.After defining the member functions, use the Rectangle class by creating multiple objects of this type.
c. Set the dimension of each of the rectangle objects using setDimension() function.
d.Output the area of each rectangle using the function void showArea() and int getArea() both.
e. Without calling the setDimension() call showArea() once, that prints some garbage values. Solve that problem
anyhow.*/




using Lab_Task_on_Encapsulation;

Console.WriteLine("Hello, World!");
Rectangle rectangle = new Rectangle();
//Rectangle[] rectangle = new Rectangle [5];

//rectangle.showArea();
//var result = rectangle.getArea();
Console.WriteLine("Result: "+ rectangle.getArea());


/*List<Rectangle> rectangle1 = new List<Rectangle>();
  
for (int i = 0; i < 5; i++)
{
    Rectangle rt = new Rectangle();

    //if (rectangle[i].initialize != true)
    //{
    Console.WriteLine("Hight: ");
    var hight = int.Parse(Console.ReadLine());
    Console.WriteLine("Width: ");
    var Width = int.Parse(Console.ReadLine());
    rt.setDimension(hight, Width);
    //}
    rt.showArea();

    rectangle1.Add(rt);
}*/

//int array 7
int[][] a = { [4,3,45], [435,35,345] };
Console.WriteLine("input");

//for(var i = 0;i<a.Length; i++)
//{
//    a[i] = int.Parse(Console.ReadLine());
//}

//foreach (var i in a)
//{
//    Console.WriteLine($"Value:{i}");
//}
