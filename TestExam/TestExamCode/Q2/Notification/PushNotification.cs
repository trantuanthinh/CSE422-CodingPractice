using TestExamCode.Q2.Interfaces;

namespace TestExamCode.Q2.Notification
{
    internal class PushNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("PushNotification: " + message);
        }
    }
}
