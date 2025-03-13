using Lab3.Abtractions;

namespace Lab3.Objects
{
    internal class ReturnTransaction : Transaction
    {
        public Book BookReturned { get; set; }
        public ReturnTransaction() { }
        public ReturnTransaction(string transactionId, DateTime transactionDate, Member member, Book bookReturned)
        {
            TransactionID = transactionId;
            TransactionDate = transactionDate;
            Member = member;
            BookReturned = bookReturned;
        }

        public override void Execute()
        {
            BookReturned.CopiesAvailable++;
            Console.WriteLine($"Book '{BookReturned.Title}' returned by {Member.Name}.");
        }
    }
}
