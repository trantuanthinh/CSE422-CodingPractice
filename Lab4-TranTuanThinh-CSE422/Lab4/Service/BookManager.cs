using Lab4.IModel;

namespace Lab4.Model
{
    internal class BookManager
    {
        private IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(IBook book)
        {
            _bookRepository.AddBook(book);
        }

        public List<IBook> SearchBooks(string query)
        {
            return _bookRepository.SearchBooks(query);
        }

        public bool LendBook(IBook book, IReader reader)
        {
            if (book.Quantity > 0 && reader.BorrowedBooks.Count < 3)
            {
                reader.BorrowedBooks.Add(book);
                _bookRepository.UpdateBookStock(book, -1);
                return true;
            }
            return false;
        }

        public void ReturnBook(IBook book, IReader reader)
        {
            if (reader.BorrowedBooks.Contains(book))
            {
                reader.BorrowedBooks.Remove(book);
                _bookRepository.UpdateBookStock(book, 1);
            }
        }
    }
}
