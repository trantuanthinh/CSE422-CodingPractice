using TestExamCode.Q2.Interfaces;

namespace TestExamCode.Q2
{
    internal class NotificationSender
    {
        private List<INotification> _notifications;
        public NotificationSender(List<INotification> notifications)
        {
            _notifications = notifications;
        }

        public void Notify(string message)
        {
            foreach (var notification in _notifications)
            {
                notification.SendNotification(message);
            }
        }
    }
}
