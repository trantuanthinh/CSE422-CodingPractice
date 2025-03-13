namespace Lab3.Objects
{
    internal class Library
    {
        public string LibraryName { get; set; }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }
        public event Action<Book, Member> OnBookBorrowed;
        public void AddBook(Book book) => Books.Add(book);
        public void AddMember(Member member) => Members.Add(member);
        public Library()
        {
            LibraryName = "Default Library";
            Books = [];
            Members = [];
        }
        public Library(string libraryName, List<Book> books, List<Member> members)
        {
            LibraryName = libraryName;
            Books = books;
            Members = members;
        }
        public Library(Library existingLibrary)
        {
            LibraryName = existingLibrary.LibraryName;
            Books = new List<Book>(existingLibrary.Books);
            Members = new List<Member>(existingLibrary.Members);
        }
        public void DisplayLibraryInfo()
        {
            Console.WriteLine($"Library Name: {LibraryName}");
            Console.WriteLine($"Number of Books: {Books.Count}");
            Console.WriteLine($"Number of Members: {Members.Count}");
        }
        public void BorrowBook(Book book, Member member)
        {
            Console.WriteLine($"{member.Name} is borrowing '{book.Title}'.");
            OnBookBorrowed?.Invoke(book, member);
        }
    }
}
