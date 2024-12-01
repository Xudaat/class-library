using System;
using LibrarySystem;
using List;

 public class Program
{
    static void Main()
    {
        Library library = new Library();

        Book book1 = new Book("War and Peace", "Leo Tolstoy", 1225);
        Book book2 = new Book("Pride and Prejudice", "Jane Austen", 432);
        Book book3 = new Book("War and Peace - Part II", "Leo Tolstoy", 500);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("All books:");
        foreach (var book in library.SearchBooks(""))
        {
            Console.WriteLine($"{book.Code}: {book.Name} by {book.AuthorName}, {book.PageCount} pages");
        }

        Console.WriteLine("\nSearch books by name 'War and Peace':");
        var warAndPeaceBooks = library.FindAllBooksByName("War and Peace");
        foreach (var book in warAndPeaceBooks)
        {
            Console.WriteLine($"{book.Code}: {book.Name}");
        }

        Console.WriteLine("\nRemove all books by name 'War and Peace'");
        library.RemoveAllBooksByName("War and Peace");

        Console.WriteLine("\nRemaining books:");
        foreach (var book in library.SearchBooks(""))
        {
            Console.WriteLine($"{book.Code}: {book.Name} by {book.AuthorName}");
        }
    }
}
