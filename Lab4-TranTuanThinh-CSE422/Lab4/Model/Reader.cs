using Lab4.IModel;

namespace Lab4.Model
{
    internal class Reader : IReader
    {
        public int ReaderId { get; set; }
        public string Name { get; set; }
        public List<IBook> BorrowedBooks { get; set; }

        public Reader(int readerId, string name)
        {
            ReaderId = readerId;
            Name = name;
            BorrowedBooks = new List<IBook>();
        }
    }
}
