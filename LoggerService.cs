using System;
using System.Collections.Generic;
using System.Text;

namespace OrderNotificationSystem_Day6PracticeAssignment.Services
{
    public class LoggerService
    {
        // Independent subscriber module
        public void LogOrder(Order order)
        {
           Console.WriteLine("Order logged successfully"); 
        }
    }
}
