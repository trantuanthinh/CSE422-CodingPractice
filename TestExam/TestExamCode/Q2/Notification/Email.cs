using TestExamCode.Q2.Interfaces;

namespace TestExamCode.Q2.Notification
{
    internal class Email : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
