/*  This code demonstrates the use of Generics in C#. The `Box<T>` class is a generic class that can hold any type of item.
 *  It has methods to set and get the item, as well as a method to display the type of the item. First the int type is used,
 *  secondly a string type, and finally a custom `Product` class is used and print it's current datatypeto demonstrate
 *  the flexibility of generics.
 */
public class Box<T>
{
    private T _item;

    public T GetItem()
    {
        return _item;
    }

    public void SetItem(T item)
    {
        _item = item;
    }
    public void DisplayItem()
    {
        Console.WriteLine($"The type of the item is: {typeof(T)}");
    }
}

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public override string ToString()
    {
        return $"{Name} - ${Price}";
    }
}

public class Program
{
    static void Main()
    {
        Box<int> box1 = new Box<int>();
        box1.SetItem(123);
        box1.DisplayItem();

        Box<string> box2 = new Box<string>();
        box2.SetItem("Hello Ram");
        box2.DisplayItem();

        Box<Product> box3 = new Box<Product>();
        Product product = new Product { Name = "Laptop", Price = 9999 };
        box3.SetItem(product);
        Console.WriteLine(box3.GetItem());
    }
}
