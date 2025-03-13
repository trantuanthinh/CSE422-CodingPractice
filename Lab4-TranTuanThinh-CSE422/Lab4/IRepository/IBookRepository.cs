namespace Lab4.IModel
{
    public interface IBookRepository
    {
        void AddBook(IBook book);
        List<IBook> SearchBooks(string query);
        IBook GetBookById(int bookId);
        void UpdateBookStock(IBook book, int quantity);
    }
}
