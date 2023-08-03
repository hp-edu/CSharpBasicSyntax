IntegerArrary integerArrary = new IntegerArrary(3);
integerArrary.Add(10);
integerArrary.Add(30);
integerArrary.Add(1000);
System.Console.WriteLine(integerArrary.GetByIndex(2));

GenericArrary<int> genericArrary = new GenericArrary<int>(3);
genericArrary.Add(10);
genericArrary.Add(30);
genericArrary.Add(1000);
System.Console.WriteLine(genericArrary.GetByIndex(2));

GenericArrary<string> genericArrary2 = new GenericArrary<string>(3);
genericArrary2.Add("abc");
genericArrary2.Add("defg");
genericArrary2.Add("ggggg");
System.Console.WriteLine(genericArrary2.GetByIndex(2));

GenericArrary<Book> genericArrary3 = new GenericArrary<Book>(3);
Book book1 = new Book()
{
    Name = "Book 1",
    Title = "Title 1",
};
Book book2 = new Book()
{
    Name = "Book 1",
    Title = "Title 1",
};
Book book3 = new Book()
{
    Name = "Book 3",
    Title = "Title 3",
};


genericArrary3.Add(book1);
genericArrary3.Add(book2);
genericArrary3.Add(book3);
System.Console.WriteLine(genericArrary3.GetByIndex(2));



public class GenericArrary<T>
{
    private T[] values;
    private int counter = 0;
    public GenericArrary(int size)
    {
        values = new T[size];
    }
    public void Add(T value)
    {
        values[counter++] = value;
    }
    public T GetByIndex(int index)
    {
        return values[index];
    }
}

public class Book
{
    public string Name { get; set; }
    public string Title { get; set; }
}



public class IntegerArrary
{
    private int[] values;
    private int counter = 0;
    public IntegerArrary(int size)
    {
        values = new int[size];
    }
    public void Add(int value)
    {
        values[counter++] = value;
    }
    public int GetByIndex(int index)
    {
        return values[index];
    }
}

public class StringArrary
{
    private string[] values;
    private int counter = 0;
    public StringArrary(int size)
    {
        values = new string[size];
    }
    public void Add(string value)
    {
        values[counter++] = value;
    }
    public string GetByIndex(int index)
    {
        return values[index];
    }
}