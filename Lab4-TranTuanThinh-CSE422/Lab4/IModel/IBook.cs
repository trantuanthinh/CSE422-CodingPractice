namespace Lab4.IModel
{
    public interface IBook
    {
        int BookId { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Category { get; set; }
        int Quantity { get; set; }
    }
}
