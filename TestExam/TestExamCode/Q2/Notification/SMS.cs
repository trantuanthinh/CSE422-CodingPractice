using TestExamCode.Q2.Interfaces;

namespace TestExamCode.Q2.Notification
{
    internal class SMS : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }
}
