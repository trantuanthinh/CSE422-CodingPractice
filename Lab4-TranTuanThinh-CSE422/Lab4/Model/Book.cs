using Lab4.IModel;

namespace Lab4.Model
{
    internal class Book : IBook
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        public Book(int bookId, string title, string author, string category, int quantity)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Category = category;
            Quantity = quantity;
        }
    }
}
