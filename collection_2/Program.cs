//№ 1

class Document
{
    public int Id { get; set; }
    public string Title { get; set; }

    public Document(int id, string title)
    {
        Id = id;
        Title = title;
    }

    public override string ToString() => $"Document ID: {Id}, Title: {Title}";
}

class DocumentStack
{
    private Stack<Document> documents = new Stack<Document>();

    public void AddDocument(Document document) => documents.Push(document);

    public void RemoveTopDocument()
    {
        if (documents.Count > 0)
        {
            var removedDocument = documents.Pop();
            Console.WriteLine($"Removed: {removedDocument}");
        }
        else
            Console.WriteLine("The stack is empty.");
    }

    public void ViewTopDocument()
    {
        if (documents.Count > 0)
            Console.WriteLine($"Top Document: {documents.Peek()}");
        else
            Console.WriteLine("The stack is empty.");
    }
}

partial class Program
{
    static void Main()
    {
        DocumentStack docStack = new DocumentStack();

        docStack.AddDocument(new Document(1, "Document A"));
        docStack.AddDocument(new Document(2, "Document B"));
        docStack.AddDocument(new Document(3, "Document C"));

        docStack.ViewTopDocument();

        docStack.RemoveTopDocument();

        docStack.ViewTopDocument();
    }
}


//№2

class Order
{
    public int OrderId { get; set; }
    public string Description { get; set; }

    public Order(int orderId, string description)
    {
        OrderId = orderId;
        Description = description;
    }

    public override string ToString() => $"Order ID: {OrderId}, Description: {Description}";
}

class OrderQueue
{
    private Queue<Order> orders = new Queue<Order>();

    public void AddOrder(Order order) => orders.Enqueue(order);

    public void RemoveOldestOrder()
    {
        if (orders.Count > 0)
        {
            var removedOrder = orders.Dequeue();
            Console.WriteLine($"Removed: {removedOrder}");
        }
        else
            Console.WriteLine("The queue is empty.");
    }

    public void ViewOldestOrder()
    {
        if (orders.Count > 0)
            Console.WriteLine($"Oldest Order: {orders.Peek()}");
        else
            Console.WriteLine("The queue is empty.");
    }
}

partial class Program
{
    static void Main_1()
    {
        OrderQueue orderQueue = new OrderQueue();

        orderQueue.AddOrder(new Order(1, "Burger"));
        orderQueue.AddOrder(new Order(2, "Pizza"));
        orderQueue.AddOrder(new Order(3, "Salad"));

        orderQueue.ViewOldestOrder();

        orderQueue.RemoveOldestOrder();

        orderQueue.ViewOldestOrder();
    }
}


//ЗАВДАННЯ 3

class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(int bookId, string title, string author)
    {
        BookId = bookId;
        Title = title;
        Author = author;
    }

    public override string ToString() => $"Book ID: {BookId}, Title: {Title}, Author: {Author}";
}

class BookStore
{
    private Dictionary<int, Book> bookCatalog = new Dictionary<int, Book>();

    public void AddBook(Book book)
    {
        if (!bookCatalog.ContainsKey(book.BookId))
        {
            bookCatalog.Add(book.BookId, book);
            Console.WriteLine($"Added: {book}");
        }
        else
            Console.WriteLine("Book with this ID already exists.");
    }

    public void RemoveBook(int bookId)
    {
        if (bookCatalog.Remove(bookId))
            Console.WriteLine($"Removed book with ID: {bookId}");
        else
            Console.WriteLine("Book not found.");
    }

    public void GetBookInfo(int bookId)
    {
        if (bookCatalog.TryGetValue(bookId, out var book))
            Console.WriteLine(book);
        else
            Console.WriteLine("Book not found.");
    }
}

partial class Program
{
    static void Main_3()
    {
        BookStore store = new BookStore();
store.AddBook(new Book(1, "C# Programming", "John Doe"));
        store.AddBook(new Book(2, "Introduction to Algorithms", "Thomas H. Cormen"));
        store.AddBook(new Book(3, "Clean Code", "Robert C. Martin"));

        store.GetBookInfo(2);

        store.RemoveBook(1);

        store.GetBookInfo(1);
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
