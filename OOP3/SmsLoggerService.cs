using System;
namespace OOP3
{
    public class SmsLoggerService : ILoggerService
    {
        public SmsLoggerService()
        {
        }

        public void Log()
        {
            Console.WriteLine("SMS yollandı");
        }
    }
}
