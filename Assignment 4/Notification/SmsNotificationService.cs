using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4.Notification
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending Sms notification to {recipient}");
            Console.WriteLine("Message");
            Console.WriteLine(message);
            Console.WriteLine("Sms notification sent.");
        }
    }
}
