using Lab5.Interfaces;

namespace Lab5.Model
{
    internal class User : INotification
    {
        public string Name { get; set; }
        public User(string name) { Name = name; }

        public void Notify(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }
    }
}
