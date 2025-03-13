namespace Lab3.Objects
{
    internal class LibraryCard
    {
        public string CardNumber { get; }
        public Member Owner { get; set; }
        public DateTime IssueDate { get; private set; }

        public LibraryCard() { }
        public LibraryCard(string cardNumber, Member owner)
        {
            CardNumber = cardNumber;
            Owner = owner;
            IssueDate = DateTime.Now;
        }

        public void RenewCard()
        {
            IssueDate = DateTime.Now; 
            Console.WriteLine($"Library card {CardNumber} renewed. New Issue Date: {IssueDate}");
        }
    }
}
