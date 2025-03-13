using Lab4.IModel;

namespace Lab4.Model
{
    internal class BookRepository : IBookRepository
    {
        private List<IBook> _books = new List<IBook>();

        public void AddBook(IBook book)
        {
            _books.Add(book);
        }

        public List<IBook> SearchBooks(string query)
        {
            return _books.Where(b => b.Title.Contains(query) || b.Category.Contains(query)).ToList();
        }

        public IBook GetBookById(int bookId)
        {
            return _books.FirstOrDefault(b => b.BookId == bookId);
        }

        public void UpdateBookStock(IBook book, int quantity)
        {
            var existingBook = GetBookById(book.BookId);
            if (existingBook != null)
            {
                existingBook.Quantity += quantity;
            }
        }
    }
}
