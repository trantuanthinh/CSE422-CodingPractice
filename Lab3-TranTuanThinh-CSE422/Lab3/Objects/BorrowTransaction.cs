using Lab3.Abtractions;

namespace Lab3.Objects
{
    internal class BorrowTransaction : Transaction
    {
        public Book BookBorrowed { get; set; }
        public BorrowTransaction() { }
        public BorrowTransaction(string transactionId, DateTime transactionDate, Member member, Book bookBorrowed)
        {
            TransactionID = transactionId;
            TransactionDate = transactionDate;
            Member = member;
            BookBorrowed = bookBorrowed;
        }

        public override void Execute()
        {
            if (BookBorrowed.CopiesAvailable > 0)
            {
                BookBorrowed.CopiesAvailable--;
                Console.WriteLine($"Book '{BookBorrowed.Title}' borrowed by {Member.Name}.");
            }
            else
            {
                Console.WriteLine($"Book '{BookBorrowed.Title}' is not available for borrowing.");
            }
        }
    }
}
