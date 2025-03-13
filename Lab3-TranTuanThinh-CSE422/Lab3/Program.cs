using Lab3.Abtractions;
using Lab3.Objects;
using Lab3.Services;

var member1 = new Member("M001", "Alice Johnson", "alice.johnson@example.com");
var member2 = new Member("M002", "Bob Smith", "bob.smith@example.com");

var book1 = new Book
{
    ISBN = "1234567890",
    Title = "C# Programming",
    Author = "John Doe",
    Year = 2020,
    CopiesAvailable = 2
};

var book2 = new Book
{
    ISBN = "0987654321",
    Title = "Introduction to Algorithms",
    Author = "Thomas Cormen",
    Year = 2019,
    CopiesAvailable = 1
};

var transactions = new List<Transaction>
        {
            new BorrowTransaction("T001", DateTime.Now, member1, book1),
            new BorrowTransaction("T002", DateTime.Now, member2, book2),
            new ReturnTransaction("T003", DateTime.Now, member1, book1),
            new BorrowTransaction("T004", DateTime.Now, member2, book1),
        };

Console.WriteLine("Executing Transactions:");
foreach (var transaction in transactions)
{
    transaction.Execute();
}

var book1Class = new BookClass ( "123456", "C# Programming", "John Doe" );
var book2Class = new BookClass ( "123456", "C# Programming", "John Doe" );

var book1Record = new BookRecord("123456", "C# Programming", "John Doe");
var book2Record = new BookRecord("123456", "C# Programming", "John Doe");

Console.WriteLine("BookClass Comparison (==): " + (book1Class == book2Class)); 
Console.WriteLine("BookRecord Comparison (==): " + (book1Record == book2Record));

var bookRecordWithModified = book1Record with { Author = "Jane Smith" };

Console.WriteLine("Modified BookRecord Author: " + bookRecordWithModified.Author);


var library = new Library();

var notificationService = new NotificationService();

library.OnBookBorrowed += notificationService.OnBookBorrowedHandler;
library.OnBookBorrowed += notificationService.SendEmailNotification;

var book = new Book { ISBN = "123456", Title = "C# Programming", Author = "John Doe" };
var member = new Member("M001", "Alice Johnson", "alice.johnson@example.com");

library.AddBook(book);
library.AddMember(member);

library.BorrowBook(book, member);
Console.WriteLine("-- Done --");