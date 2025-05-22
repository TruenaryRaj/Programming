/*  This program demonstrates encapsulation by creating a Student class that encapsulates the properties and methods related to a student. 
    The student class contains the details of the student with the field name, grades, and subject. where grades and subject are defined as list
    i.e student can have multiple subjects and respective grades. 

    As the object of Student class is created with the name of the student, it will pass the name to AddStudent method in which the user will
    have to enter the subject and their respective grades of the student, and add to AddGrade method.
    As soon as the loop of subject and grades ends the calculate average is called to calculate the average of the grades and display it.
    
 */
public class Student
{
    public string name { get; }
    private Dictionary<string, double> SubjectGrades;

    public Student(string name)
    {
        this.name = name;
        this.SubjectGrades = new Dictionary<string, double>();
        AddStudent(name);
    }

    private void AddGrade(string subjectName, double grade)
    {
        if (string.IsNullOrEmpty(subjectName) || grade < 0)
        {
            Console.WriteLine("Subject name cannot be empty or grade cannot be negative ");
        }
        SubjectGrades[subjectName] = grade;
    }

    private void AddStudent(string name)
    {
        Console.WriteLine($"Welcome {name}");
        Console.WriteLine("Enter total number of subject:");
        int totalSubject = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the subject name and grade");

        for (int i = 0; i < totalSubject; i++)
        {
            Console.WriteLine($"Subject {i + 1}:");
            string subjectName = Console.ReadLine();
            Console.WriteLine($"Grade for {subjectName}:");
            double grade = Convert.ToDouble(Console.ReadLine());
            AddGrade(subjectName, grade);
        }

        CalculateAverage();
    }
 
    private void CalculateAverage()
    {
        double total = 0;
        foreach (int grade in SubjectGrades.Values)
        {
            total += grade;
        }
        Console.WriteLine($"Total average of {name} is {total / SubjectGrades.Count}");
    }
}

public class Program
{
    static void Main()
    {

        Student student1 = new Student("Ram");

        // to hold the console window even after the program ends
        Console.ReadLine();
    }
}