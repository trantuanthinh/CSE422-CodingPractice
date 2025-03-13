using Lab3.Interfaces;

namespace Lab3.Objects
{
    internal class Member : IPrintable, IMemberActions
    {
        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Member() { }
        public Member(string memberId, string name, string email)
        {
            MemberID = memberId;
            Name = name;
            Email = email;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }

        public virtual void BorrowBook(Book book)
        {
            if (book.CopiesAvailable > 0)
            {
                book.CopiesAvailable--;
                Console.WriteLine($"{Name} borrowed the book '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"No copies of '{book.Title}' are available to borrow.");
            }
        }

        public virtual void ReturnBook(Book book)
        {
            book.CopiesAvailable++;
            Console.WriteLine($"{Name} returned the book '{book.Title}'.");
        }
    }
}
