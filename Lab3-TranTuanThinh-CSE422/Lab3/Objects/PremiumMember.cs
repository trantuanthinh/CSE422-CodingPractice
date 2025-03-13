namespace Lab3.Objects
{
    internal class PremiumMember : Member
    {
        public DateTime MembershipExpiry { get; set; }
        public int MaxBooksAllowed { get; set; }
        public PremiumMember() { }
        public PremiumMember(string memberId, string name, string email, DateTime membershipExpiry, int maxBooksAllowed)
            : base(memberId, name, email)
        {
            MembershipExpiry = membershipExpiry;
            MaxBooksAllowed = maxBooksAllowed;
        }

        public override void BorrowBook(Book book)
        {
            if (MaxBooksAllowed > 0)
            {
                base.BorrowBook(book);
                MaxBooksAllowed--;
            }
            else
            {
                Console.WriteLine($"{Name} has reached the maximum limit of borrowed books.");
            }
        }

        public override void ReturnBook(Book book)
        {
            base.ReturnBook(book);
            MaxBooksAllowed++;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Membership Expiry: {MembershipExpiry.ToShortDateString()}");
            Console.WriteLine($"Max Books Allowed: {MaxBooksAllowed}");
        }
    }
}
