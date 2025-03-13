using Lab5.Interfaces;

namespace Lab5.Model
{
    internal class Library
    {
        List<INotification> notifications = new List<INotification>();
        public void AddObserver(INotification notification) => notifications.Add(notification);
        public void RemoveObserver(INotification notification) => notifications.Remove(notification);
        public void Notify(string message)
        {
            foreach (var notification in notifications)
            {
                notification.Notify(message);
            }
        }
    }
}
