using System;
namespace OOP3
{
    public class MailLoggerService : ILoggerService
    {
        public MailLoggerService()
        {
        }

        public void Log()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }
}
