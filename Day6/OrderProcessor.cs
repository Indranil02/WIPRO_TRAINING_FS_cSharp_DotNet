using System;
using System.Collections.Generic;
using System.Text;

namespace OrderNotificationSystem_Day6PracticeAssignment
{
    public class OrderProcessor
    {
        // Define delegate for order processing
        public delegate void OrderPlacedHandler(Order order);

        // Define the event based on the delegate
        public event OrderPlacedHandler OnOrderPlaced;

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Order Placed: {order.OrderId}");

            // Null-safe invocation for event-driven trigger
            OnOrderPlaced?.Invoke(order);
        }
    }
}
