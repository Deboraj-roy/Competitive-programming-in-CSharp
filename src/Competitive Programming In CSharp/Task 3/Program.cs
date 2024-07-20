// See https://aka.ms/new-console-template for more information
/*Task 3
Write a class called Circle, that will have only one variable named radius. A function named setRadius will set the
radius of the circle. The class should have two other functions, one should output the circumference and the another
should output the area of that circle.
Hints :
Area = PI * r2
Circumference = 2 * PI * r
*/

using Task_3;

Circle circle = new Circle(); 
circle.getArea();
circle.getCircumference();

Console.WriteLine("********************************************************************");
Circle circle2 = new Circle();
Console.Write("Enter Radius: ");
var r = double.Parse(Console.ReadLine());
circle2.setRadius(r);
circle2.getArea();
circle2.getCircumference();

