/*  This program demonstrates encapsulation by creating a Student class that encapsulates the properties and methods related to a student. 
    The student class contains the details of the student with the field name, grades, and subject. where grades and subject are defined as list
    i.e student can have multiple subjects and respective grades. 
    In the main method we create a list of student type so that it would hold multiple student objects as everytime new student object is created.
 * */
public class Student
{
    private string name;  //creating a private field to store name
    private Dictionary<string, double> SubjectGrades; //creating a private field to store grades

    //Constructor to initialize the name and create empty lists for grades and subject each time a new object is created
    public Student(string name)
    {
        this.name = name;
        this.SubjectGrades = new Dictionary<string, double>();
    }

    //public getter for subject and grades to access the private field
    public Dictionary<string, double> Grades
    {
        get { return SubjectGrades; }
    }
    //public getter Name to access the private field name
    public string Name                                  
    {
        get { return name; }
    }

    public void AddGrade(string subjectName, double grade)//method to add the grade and subject name to their respective list
    {
        if (string.IsNullOrEmpty(subjectName) || grade<0)
        {
            Console.WriteLine("Subject name cannot be empty or grade cannot be negative ");
        }
        SubjectGrades[subjectName] = grade;
    }

    //method to calculate the average of the grades
    public double CalculateAverage()
    {
         double total = 0;
        foreach (int grade in SubjectGrades.Values)
        {
            total += grade;
        }
        return total / SubjectGrades.Count;
    }
}

public class Program
{
    static void Main()
    {
        List<Student> StudentObject = new List<Student>();//creates a list of the Student type which holds multiple student objects
       
        Console.WriteLine("Enter number of students:");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());//taking the number of students from the user to run the loop accordingly
        //running the loop as per the no of students and entering the student name and grade to the list
        for (int j = 0; j < numberOfStudents; j++)
        {
            Console.WriteLine($"Enter detail for student{j + 1}");//as the loop starts from the index 0 so making it 1
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();// taking the name of the student from the user
            Student student = new Student(name);//Creates a new instance of the Student class
            StudentObject.Add(student);//adds the student object to the list of students

            //taking the number of subject from the user to run the loop accordingly
            Console.WriteLine("Enter total number of subject:");
            int totalSubject = Convert.ToInt32(Console.ReadLine());

            //running the loop as per the no of subject and entering the subject name and grade to the list 
            for (int i=0; i<totalSubject; i++)
            {
                Console.WriteLine("Enter subject name:");
                string subjectName = Console.ReadLine();
                Console.WriteLine($"Enter grade for {subjectName}:");
                double grade = Convert.ToDouble(Console.ReadLine());
                StudentObject[j].AddGrade(subjectName, grade);//adding the subject name to the list
            }

            var displayGrades = StudentObject[j].Grades;//calling method to get the grade list

            Console.WriteLine("Each Subject with it's grade:");
            foreach(var item in displayGrades)
            {
                Console.WriteLine($"Subject: {item.Key}, Grade: {item.Value}");//displaying the subject name and grade
            }

            double average = StudentObject[j].CalculateAverage();//calling method to calculate average
            Console.WriteLine($"Average grade of {StudentObject[j].Name} from {totalSubject} subject is {average}");
        }

        Console.ReadLine();// to hold the console window even after the program ends
    }
}