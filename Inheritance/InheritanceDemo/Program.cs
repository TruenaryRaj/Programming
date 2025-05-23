using System;

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
