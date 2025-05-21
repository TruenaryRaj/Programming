
/* this program is a demo of encapsulation in which there is Student class with privcate fields and public methods to access and modify the data. 
   The class has a method to calculate the average of grades and a method to get the grades. 
   The program creates an instance of the Student class, adds grades, calculates the average, and displays the grades.
 
 */


public class Student
{
    private string name;  //creating a private field to store name
    private List<int> grades = new List<int>(); //creating a private list to store grades

    public string Name   //public property to access the private field name
    {
        get { return name; }
        set {

            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Name cannot be null or empty");
            }
            name = value;  //private name is assigned to the value received from the property
        }
    }


    //method to add a grade to the list
    public void AddGrade(int grade)
    {
        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Grade must be between 0 and 100"); 
        }
        grades.Add(grade);
    }

    //method to calculate the average of the grades
    public double CalculateAverage()
    {
         int total = 0;
        foreach (int grade in grades)
        {
            total += grade;
        }
        return total / grades.Count;
    }

    //method to get the grades 
    public IReadOnlyList<int> GetGrade()
    {
        return  grades;
    }
}

public class Program
{
    static void Main()
    {
        Student StudentObject = new Student(); //creating an instance of the Student class
        StudentObject.Name = "Ram";  // assigning the name to the student
        StudentObject.AddGrade(85);   // assigning the grades to the student
        StudentObject.AddGrade(90);
        StudentObject.AddGrade(78);
        double average = StudentObject.CalculateAverage();  //calling method to calculate average
        Console.WriteLine($"Average grade for {StudentObject.Name} is {average}");

        IReadOnlyList<int> displayGrades = StudentObject.GetGrade();    //calling method to get the grade list
        Console.WriteLine("Grades: " + string.Join(", ", displayGrades));

    }
}