/*This program is all about a simple example of inheritance. This program demonstrates how to create a base class 'Employee'
 * and their derived classes 'FullTimeEmployee' and 'PartTimeEmployee' and how to use them as when needed.
 * Employee class is the base class which contains common properties like (Name, Id, Department) and methods to display employee information.
 * Where as the derived classes fulltime and parttime have their own specific properties and methods to calculate the salary of the employee.
 * As we can see the DisplayInfo method is available in all the classes and it is overridden in the derived classes to include specific information(run time).
 * As we can see the the object of both Fulltime and PartTime classes are created with the instance of the base class Employee. so while calling it would call 
 * the base class method but it is overridden by the derived class.
 */

public class Employee
{
    protected string Name { get; set; }
    protected int Id { get; set; }
    protected string Department { get; set; }

    public Employee(string name, int id, string department)
    {
        Name = name;
        Id = id;
        Department = department;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Department: {Department}");
    }
}
public class FullTimeEmployee : Employee
{
    private double Salary { get; set; }

    public FullTimeEmployee(string name, int id, string department, double salary)
        : base(name, id, department)
    {
        Salary = salary;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Monthly Salary: ${Salary:F2}");
    }
}
public class PartTimeEmployee : Employee
{
    private double HourlyRate { get; set; }
    private int HoursWorked { get; set; }

    public PartTimeEmployee(string name, int id, string department, double hourlyRate, int hoursWorked)
        : base(name, id, department)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }
    public double CalculatePay()
    {
        return HourlyRate * HoursWorked;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Hourly Rate: ${HourlyRate:F2}");
        Console.WriteLine($"Hours Worked: {HoursWorked}");
        Console.WriteLine($"Total Pay: ${CalculatePay():F2}");
    }
}
public class Program
{
    static void Main()
    {
        FullTimeEmployee ftEmp = new FullTimeEmployee("Ram", 101, "IT", 5500);
        PartTimeEmployee ptEmp = new PartTimeEmployee("Hari", 202, "Marketing", 25, 80);

        Console.WriteLine("Full-Time Employee Info:");
        ftEmp.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Part-Time Employee Info:");
        ptEmp.DisplayInfo();
    }
}
