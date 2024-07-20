/*Task 5
Define a class called Student that contains six parameters; id, name, quiz1, quiz2 and quiz3. Using
appropriate functions, find the average of the quizes for each student. Print the id, name and the average
marks of all the students. There must be at least 4 students.*/

using Task_5;

Student student = new Student(1, "Rahim", 5, 8, 10);
student.printStudentData();


Console.Write("Number of students?: ");
var number = int.Parse(Console.ReadLine());
Student[] students = new Student[number];
for (int i = 0; i < students.Length; i++)
{
    Console.Write("ID: ");
    var id = int.Parse(Console.ReadLine());

    Console.Write("Name: ");
    var Name = Console.ReadLine();
    Console.Write("Q1: ");
    var Q1 = int.Parse(Console.ReadLine());
    Console.Write("Q2: ");
    var Q2 = int.Parse(Console.ReadLine());
    Console.Write("Q3: ");
    var Q3 = int.Parse(Console.ReadLine());

    students[i] = new Student(id, Name, Q1, Q2, Q3);
}

double aveStudentsNumber = 0;
//foreach (var student in students)
for (int i = 0; i < students.Length; i++)
{
    aveStudentsNumber = aveStudentsNumber + students[i].averageQuizes();
    students[i].printStudentData();
}
aveStudentsNumber = (aveStudentsNumber / students.Length);
Console.WriteLine("\nThe average\r\nmarks of all the students: " + aveStudentsNumber);