/*This program demonstrate the uses of static class and static members. We have static class StudentCounter
 * in which the counter variable is static and keeps track of the number of Student objects created.
 * The Student class is an example of a class that uses the static StudentCounter to increment the count as the 
 * student object is created. So we can see that static class doesnot need any object creation to access its members.
 * */
public class Program
{
    static void Main()
    {
        Student student1 = new Student("Ram", 20);
        Student student2 = new Student("Shyam", 22);
        Student student3 = new Student("Sita", 19);

        StudentCounter.DisplayCounter();
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        StudentCounter.Increment();
    }
}

public static class StudentCounter
{
    public static int counter = 0;

    public static void Increment()
    {
        counter++;
    }
    public static void DisplayCounter()
    {
        Console.WriteLine($"Total Students: {counter}");
    }
}