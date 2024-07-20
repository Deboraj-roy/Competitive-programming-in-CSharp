/*using System.ComponentModel;

Task 4
Write a class called Box which contains three member variables; length, width and height. This class also contains
two constructors, one empty and another one is with parameter. You also have to write a function named
getArea() that calculates and returns the area of a box object. Write necessary code inside the main function to
test the class by creating an object.*/

using Task_4;

Box box = new Box();
Console.WriteLine("Area of Box: " + box.getArea());
Console.WriteLine("*************************************************");
Console.Write("Length:");
var length = double.Parse(Console.ReadLine());
Console.Write("Width:");
var width = double.Parse(Console.ReadLine());
Console.Write("Height:");
var height = double.Parse(Console.ReadLine());
Box box2 = new Box(length, width, height);
Console.WriteLine("Area of Box: " + box2.getArea());
