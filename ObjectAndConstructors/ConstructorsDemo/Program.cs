/* This program simply demonstrate the use of constructors in a class.
   It includes a default constructor and a parameterized constructor.
   The program creates object of the class using both constructors and displays their values.
 */
public class ConstructorsDemo
{
    public int Value { get; set; }
    public ConstructorsDemo()
    {
        Value = 0;
    }
    public ConstructorsDemo(int initialValue)
    {
        Value = initialValue;
    }
    public void DisplayValue()
    {
        System.Console.WriteLine($"Value: {Value}");
    }

}

public class Program
{
    static void Main()
    {
        ConstructorsDemo defaultInstance = new ConstructorsDemo();  
        defaultInstance.DisplayValue(); 

        ConstructorsDemo parameterizedInstance = new ConstructorsDemo(42);
        parameterizedInstance.DisplayValue();

    }
}