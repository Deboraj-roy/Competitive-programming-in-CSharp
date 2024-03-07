/*
 * Certainly! Below is a simple C# program that checks if a given year is a leap year. A year is considered a leap year if it is divisible by 4 but not by 100, unless it is also divisible by 400. This means that years like 2000 and 2020 are leap years, but 1900 and 2100 are not.
*/

Console.Write("Enter a year to check if it's a leap year or not: ");
int year = int.Parse(Console.ReadLine());

if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is not a leap year.");
}