/*  
 This program demonstrate an exmample of encapsulation as we can see that the class student has private data members and to access them we
have to use the public methods of the class. 

dictionary is being use to store the name of the student and list of their respective grade, one student can have multiple grades.
Once the instance of the student class is created, we can add the student name and their grades using the AddStudent method and once 
the grade are added, it calls the average calculation method and displays the average of all grades.
 */


public class Student
{
    private Dictionary<string, List<int>> SubjectGrades;

    public Student()
    {
        SubjectGrades = new Dictionary<string, List<int>>();
    }

    public void AddStudent(string name)
    {
        Console.WriteLine("Level 11 or 12:");
        int Level = Convert.ToInt32(Console.ReadLine());
        List<int> grade;
        
        if (Level == 11)
        {
                Console.WriteLine("Enter the subjects and grades in the format: Math,  DSA, C ");

                string input =Console.ReadLine();
                grade = input.Split(',').Select(s => int.Parse(s.Trim())).ToList();
                SubjectGrades[name] = grade;
        }else
        {
                Console.WriteLine("Enter the subjects and grades in the format: Python,  Java, C# ");

                string input = Console.ReadLine();
                grade = input.Split(',').Select(s => int.Parse(s.Trim())).ToList();
                SubjectGrades[name] = grade;
        }
        CalculateAverage(name);
    }
 
    private void CalculateAverage(string name)
    {
         List<int> list = SubjectGrades[name];
         Console.WriteLine($"Average of {name} is {list.Average():f2}");
    }
}

public class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.AddStudent("Ram");
        // to hold the console window even after the program ends
        Console.ReadLine();
    }
}