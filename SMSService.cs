using System;
using System.Collections.Generic;
using System.Text;

namespace OrderNotificationSystem_Day6PracticeAssignment.Services
{
    public class SMSService
    {
        // Attached via multicast delegate in Program.cs 
        public void SendSMS(Order order)
        {
            Console.WriteLine($"SMS sent to {order.CustomerName}"); 
        }
    }
}
