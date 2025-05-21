






public class Student
{
    private string name;  //creating a private field to store name
    private List<int> grades; //creating a private list to store grades
    private  List<string> subject;


   public Student(string name)
    {
        this.name = name;//constructor to initialize the name
        this.grades = new List<int>();
        this.subject = new List<string>(); //initializing the list of grades
    }

    public string Name
    {
        get { return name; }
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

    //method to add a subject to the list
    public void AddSubject(string subjectName)
    {
        if (string.IsNullOrEmpty(subjectName))
        {
            Console.WriteLine("Subject name cannot be empty");
        }
        subject.Add(subjectName);
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

    public IReadOnlyList<string> GetSubject()
    {
        return subject;
    }
}

public class Program
{
    static void Main()
    {
        List<Student> StudentObject = new List<Student>(); //creating an instance of the Student class

        Console.WriteLine("Enter number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        for (int j = 0; j < numberOfStudents; j++)
        {

            Console.WriteLine($"Enter detail for student{j + 1}");
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Student student = new Student(name);//adding the student name to the list
            StudentObject.Add(student);

            Console.WriteLine("Enter total number of subject:");
            int totalSubject = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalSubject; i++)
            {
                Console.WriteLine("Enter subject name:");
                string subjectName = Console.ReadLine();
                StudentObject[j].AddSubject(subjectName);
            }

            var subject = StudentObject[j].GetSubject(); //calling method to get the subject list

            Console.WriteLine("Enter Grades for each subject:");
            for (int i = 0; i < totalSubject; i++)
            {
                Console.WriteLine($"Enter grade for {subject[i]}");
                int grade = Convert.ToInt32(Console.ReadLine());
                StudentObject[j].AddGrade(grade);
            }



            double average = StudentObject[j].CalculateAverage();  //calling method to calculate average
            Console.WriteLine($"Average grade of {StudentObject[j].Name} is from {totalSubject} is {average}");

            var displayGrades = StudentObject[j].GetGrade();    //calling method to get the grade list

            Console.WriteLine("Each Subject with it's grade:");
            for (int i = 0; i < totalSubject; i++)
            {
                Console.WriteLine($"{subject[i]}: {displayGrades[i]}");
            }

        }

        Console.ReadLine();
    }
}