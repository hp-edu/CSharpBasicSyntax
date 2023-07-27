using System.Collections.Generic;

// Creating instances of the Book class
Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
Book book2 = new Book("1984", "George Orwell", 1949);

// Creating an instance of the Library class
Library library = new Library();

// Adding books to the library
library.AddBook(book1);
library.AddBook(book2);

// Printing all book details in the library
library.PrintAllBooks();

public class Book
{
    // Fields
    private string title;
    private string author;
    private int publicationYear;

    // Properties
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public int PublicationYear
    {
        get { return publicationYear; }
        set
        {
            if (value >= 1455)
                publicationYear = value;
            else
                throw new Exception("Publication year must be 1455 or later.");
        }
    }

    // Constructor
    public Book(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }

    // Method
    public void PrintDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine(string.Format("Publication Year: {0}", PublicationYear));
    }
}

public class Library
{
    // Field
    private List<Book> books;

    // Property
    public List<Book> Books
    {
        get { return books; }
    }

    // Constructor
    public Library()
    {
        books = new List<Book>();
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Method to print all book details in the library
    public void PrintAllBooks()
    {
        foreach (Book book in books)
        {
            book.PrintDetails();
            Console.WriteLine();
        }
    }
}

