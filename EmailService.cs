using System;
using System.Collections.Generic;
using System.Text;

namespace OrderNotificationSystem_Day6PracticeAssignment.Services
{
        public class EmailService
        {
            // Method signature must match the OrderPlacedHandler delegate 
            public void SendEmail(Order order)
            {
                Console.WriteLine($"Email sent to {order.CustomerName}"); 
        }
        }
    
}
