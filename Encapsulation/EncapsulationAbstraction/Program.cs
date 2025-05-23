/* this code demonstrate the concept of encapsulation and abstraction
   where we have a base class Book with an abstract method SearchBook
*/


public abstract class  Library
{
    protected static Dictionary<string, string> books = new Dictionary<string, string>();
    public void SearchBook(string title)
    {
        Console.WriteLine("Searching for book: " + title);
        Console.WriteLine(
             books.ContainsKey(title)
                 ? $"Book found: {title} by {books[title]}"
                 : "Book not found."
         );
    }
}

public class  Librarian : Library
{
    public void AddBook(string title, string author)
    {
        books[title] = author;
    }

    public void RemoveBook(string title)
    {
        if (books.ContainsKey(title))
        {
            books.Remove(title);
            Console.WriteLine($"Book '{title}' removed.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found.");
        }
    }

    public void RequestBook(string title)
    {
        SearchBook(title);
    }


}

public class Student : Library
{

}


public class Program
{
    static void Main()
    {
        Librarian library = new Librarian();
       
        library.AddBook("ABC", "Ram");
        library.AddBook("DEF", "Hari");


        Student student = new Student();
        student.SearchBook("ABC");
    }
}