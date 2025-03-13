namespace Lab4.IModel
{
    public interface IReader
    {
        int ReaderId { get; set; }
        string Name { get; set; }
        List<IBook> BorrowedBooks { get; set; }
    }
}
