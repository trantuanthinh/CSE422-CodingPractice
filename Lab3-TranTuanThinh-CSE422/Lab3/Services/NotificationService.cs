using Lab3.Objects;

namespace Lab3.Services
{
    internal class NotificationService
    {
        public void OnBookBorrowedHandler(Book book, Member member)
        {
            Console.WriteLine($"OnBookBorrowedHandler:\n -- Book:{book.ISBN}\n -- Member: {member.Name}");
        }
        public void SendEmailNotification(Book book, Member member)
        {
            Console.WriteLine($"Notification:\n -- Book:{book.ISBN}\n -- Member: {member.Name}");
        }

        public virtual void SendNotification(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }

        public virtual void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Notification to {recipient}: {message}");
        }
        public virtual void SendNotification(string message, List<string> recipients)
        {
            foreach (var recipient in recipients)
            {
                Console.WriteLine($"Notification to {recipient}: {message}");
            }
        }
    }
}
