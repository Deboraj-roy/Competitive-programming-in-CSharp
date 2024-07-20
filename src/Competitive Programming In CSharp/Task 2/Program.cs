/*Task 2
Write a class named Calculator.The class should have the following functions and variable(s)–
class Calculator
{
    double myValue;
    public:
void setValue(double);
    void square();
    void qube();
}
a.At first assign a value into the variable myValue and call all the other functions so that respective results
will be output.
b. Without calling the setValue() call square() or qube() once, that prints some garbage values. Solve that
problem anyhow.*/


// See https://aka.ms/new-console-template for more information
using Task_2;

Console.WriteLine("Enter a Double Value");
double v = double.Parse(Console.ReadLine());
Calculator calculator = new Calculator();
calculator.setValue(v);
calculator.square(); 
calculator.qube();

Console.WriteLine("*****************************************************************************");
 
Calculator calculator2 = new Calculator(); 
calculator2.square();
calculator2.qube();
Console.WriteLine("End");