/*  This program demonstrates encapsulation by creating a Student class that encapsulates the properties and methods related to a student. 
    The student class contains the details of the student with the field name, grades, and subject. where grades and subject are defined as list
    i.e student can have multiple subjects and respective grades. 
    In the main method we create a list of student type so that it would hold multiple student objects as everytime new student object is created.
 * */
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


    public void AddGrade(string subjectName, double grade)
    {
        if (string.IsNullOrEmpty(subjectName) || grade < 0)
        {
            Console.WriteLine("Subject name cannot be empty or grade cannot be negative ");
        }
        SubjectGrades[subjectName] = grade;
    }

    public void AddStudent(string name)
    {
        Console.WriteLine($"Welcome{name}");
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
    //method to calculate the average of the grades
    public void CalculateAverage()
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

        Student student1 = new Student("John");


        // to hold the console window even after the program ends
        Console.ReadLine();
    }
}