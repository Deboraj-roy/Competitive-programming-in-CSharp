using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_5;
/*
Task 5
Define a class called Student that contains six parameters; id, name, quiz1, quiz2 and quiz3. Using
appropriate functions, find the average of the quizes for each student. Print the id, name and the average
marks of all the students. There must be at least 4 student*/
namespace Task_5
{
    public class Student
    {
        int Id;
        string Name;
        int quiz1;
        int quiz2;
        int quiz3;
        public Student()
        {
            
        }
        public Student(int id, string nam, int q1, int q2, int q3)
        {
            Id = id;
            Name = nam;
            quiz1 = q1;
            quiz2 = q2;
            quiz3 = q3;
        }
        public int averageQuizes()
        {
            return ((quiz1+quiz2+quiz3)/3);
        }

        public void printStudentData()
        {
            Console.WriteLine("ID: " + Id + "\nName: " + Name + "\nAverage of the quizes: " + averageQuizes());
            Console.WriteLine("*******************");
        }
    }
}
