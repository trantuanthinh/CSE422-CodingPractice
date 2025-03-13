using Lab4.IModel;
using Lab4.MainMenu;
using Lab4.Model;

IBookRepository bookRepository = new BookRepository();
IReaderRepository readerRepository = new ReaderRepository();

BookManager bookManager = new BookManager(bookRepository);
ReportGenerator reportGenerator = new ReportGenerator(readerRepository);

bookManager.AddBook(new Book(1, "A", "A1", "A11", 5));
bookManager.AddBook(new Book(2, "B", "B1", "B11", 10));

IReader reader = new Reader(1, "John Doe");
readerRepository.AddReader(reader);

var bookToLend = bookRepository.GetBookById(1);
if (bookToLend != null)
{
    bookManager.LendBook(bookToLend, reader);
}

bookManager.ReturnBook(bookToLend, reader);

reportGenerator.GenerateReport(1);

MainMenu.ShowMenu();