using Lab4.Model;
using Lab4.IModel;
using System;
using System.Collections.Generic;

namespace Lab4.MainMenu
{
    internal static class MainMenu
    {
        // Repositories and managers
        private static IBookRepository _bookRepository;
        private static IReaderRepository _readerRepository;
        private static BookManager _bookManager;
        private static ReportGenerator _reportGenerator;

        // Static constructor to initialize the repositories and managers
        static MainMenu()
        {
            _bookRepository = new BookRepository();
            _readerRepository = new ReaderRepository();
            _bookManager = new BookManager(_bookRepository);
            _reportGenerator = new ReportGenerator(_readerRepository);
        }

        public static void ShowMenu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Library System ===");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Lend Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Generate Report");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        SearchBook();
                        break;
                    case "3":
                        LendBook();
                        break;
                    case "4":
                        ReturnBook();
                        break;
                    case "5":
                        GenerateReport();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void AddBook()
        {
            Console.Clear();
            Console.WriteLine("=== Add New Book ===");
            Console.Write("Enter Book ID: ");
            int bookId = int.Parse(Console.ReadLine());
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            IBook book = new Book(bookId, title, author, category, quantity);
            _bookManager.AddBook(book);

            Console.WriteLine("Book added successfully! Press any key to return to the main menu.");
            Console.ReadKey();
        }

        private static void SearchBook()
        {
            Console.Clear();
            Console.WriteLine("=== Search Book ===");
            Console.Write("Enter Title or Category: ");
            string searchTerm = Console.ReadLine();

            var books = _bookManager.SearchBooks(searchTerm);

            if (books.Count > 0)
            {
                Console.WriteLine("Books found:");
                foreach (var book in books)
                {
                    Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Category: {book.Category}, Quantity: {book.Quantity}");
                }
            }
            else
            {
                Console.WriteLine("No books found matching the search term.");
            }

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        private static void LendBook()
        {
            Console.Clear();
            Console.WriteLine("=== Lend Book ===");
            Console.Write("Enter Reader ID: ");
            int readerId = int.Parse(Console.ReadLine());

            IReader reader = _readerRepository.GetReaderById(readerId);

            if (reader == null)
            {
                Console.WriteLine("Reader not found. Please add a reader first.");
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter Book ID to lend: ");
            int bookId = int.Parse(Console.ReadLine());

            IBook book = _bookRepository.GetBookById(bookId);

            if (book == null || book.Quantity <= 0)
            {
                Console.WriteLine("Book is not available or does not exist.");
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
                return;
            }

            bool success = _bookManager.LendBook(book, reader);
            if (success)
            {
                Console.WriteLine("Book lent successfully!");
            }
            else
            {
                Console.WriteLine("Unable to lend book. The reader has already borrowed 3 books.");
            }

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        private static void ReturnBook()
        {
            Console.Clear();
            Console.WriteLine("=== Return Book ===");
            Console.Write("Enter Reader ID: ");
            int readerId = int.Parse(Console.ReadLine());

            IReader reader = _readerRepository.GetReaderById(readerId);

            if (reader == null)
            {
                Console.WriteLine("Reader not found. Please add a reader first.");
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
                return;
            }

            Console.Write("Enter Book ID to return: ");
            int bookId = int.Parse(Console.ReadLine());

            IBook book = _bookRepository.GetBookById(bookId);

            if (book == null)
            {
                Console.WriteLine("Book does not exist.");
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
                return;
            }

            _bookManager.ReturnBook(book, reader);
            Console.WriteLine("Book returned successfully!");

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }

        private static void GenerateReport()
        {
            Console.Clear();
            Console.WriteLine("=== Generate Report ===");
            Console.Write("Enter Reader ID: ");
            int readerId = int.Parse(Console.ReadLine());

            _reportGenerator.GenerateReport(readerId);

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
        }
    }
}
