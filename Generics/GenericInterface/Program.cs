/* This program demonstrate the use of interface with the generic class. 
   The interface IReportable defines a method Report, which is implemented by 
   the classes Student and Product. The generic class ReportGenerator<T> 
   accepts any type T that implements IReportable, allowing it to generate 
   reports for different types of objects. 
 */
public interface IReportable
{
    void Report();
}
public class ReportGenerator<T> where T : IReportable
{
    private List<T> _reports = new List<T>();
    public void AddItem(T report)
    {
        _reports.Add(report);
    }
    public void PrintReport()
    {
        foreach (var report in _reports)
        {
            report.Report();
        }
    }
    public void Report(T value)
    {
        System.Console.WriteLine($"Reporting: {value}");
    }
}
public class Student : IReportable
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public void Report()
    {
        System.Console.WriteLine($"Name: {Name}, Grade:{Grade}");
    }
}
public class Product : IReportable
{
    public string Name { get; set; }
    public int Price { get; set; }
    public void Report()
    {
        System.Console.WriteLine($"Name:{Name}, Grade:{Price}");
    }
}

public class Program
{
    static void Main()
    {
        var studentReport = new ReportGenerator<Student>();
        studentReport.AddItem(new Student { Name = "Ram", Grade = 90 });
        studentReport.PrintReport();

        var productReport = new ReportGenerator<Product>();
        productReport.AddItem(new Product { Name = "Thakali", Price = 1200 });
        productReport.PrintReport();
    }
}
