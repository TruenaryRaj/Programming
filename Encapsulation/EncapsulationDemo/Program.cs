/*  
 This program demonstrate an exmample of encapsulation as we can see that the class student has private data members and to access them we
have to use the public methods of the class. 

dictionary is being use to store the name of the student and list of their respective grade, one student can have multiple grades.
Once the instance of the student class is created, as we add the student name by the help of AddStudent method then we call the AddGrade method to add the 
repective level grade after the grade check and after that we call the CalculateAverage method to calculate the average of the grades.
 */

using System.Xml.Linq;

public class Student
{
    private Dictionary<string, List<Dictionary<string, int>>> SubjectGrades = new Dictionary<string, List<Dictionary<string, int>>>();/*
    {
        {
                string.Empty, new List<Dictionary<string, int>>()
                {
                    new Dictionary<string, int>() { { "C", 0 }, { "C#", 0 }, {"Java",0 } }
                }
            },
    };*/
    private void AddGrades( string name)
    {
        List<int> grade;
        Console.WriteLine($"Enter the grades for C, c#, java in this format");
        string input = Console.ReadLine();
        grade = input.Split(',').Select(s => int.Parse(s.Trim())).ToList();
      
        SubjectGrades[name] = new List<Dictionary<string, int>>()
        {
            new Dictionary<string, int>() { { "C", grade[0] }, { "C#", grade[1] }, {"Java",grade[2] } }
        };
    }
    public void AddStudent(string name)
    {
        Console.WriteLine($"Welcome {name}");
        
        AddGrades(name);

        CalculateAverage(name);
    }
 
    private void CalculateAverage(string name)
    {
        List<int> grades = SubjectGrades[name][0].Values.ToList();

        Console.WriteLine($"Average of {name} is {grades.Average() } ");

        foreach (var subject in SubjectGrades[name][0]) 
        {
            Console.WriteLine($"{subject.Key} ->{subject.Value}");
        }
    }
}

public class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.AddStudent("Ram");

        student1.AddStudent("Shyam");

        // to hold the console window even after the program ends
        Console.ReadLine();
    }
}