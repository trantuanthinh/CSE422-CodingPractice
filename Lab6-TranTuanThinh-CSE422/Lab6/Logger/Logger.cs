namespace Lab6.Logger
{
    internal class Logger
    {
        public void Log(string message, params object[] args)
        {
            Console.WriteLine(FormatLogMessage(message, args));
        }

        private string FormatLogMessage(string message, object[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                message = message.Replace($"{{{i}}}", args[i]?.ToString());
            }
            return message;
        }
    }
}
