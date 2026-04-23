using OrderNotificationSystem_Day6PracticeAssignment;
using OrderNotificationSystem_Day6PracticeAssignment.Services;

class Program
{
    static void Main(string[] args)
    {
        // 1. Initialize Publisher and Subscribers
        OrderProcessor processor = new OrderProcessor();
        EmailService emailService = new EmailService();
        SMSService smsService = new SMSService();
        LoggerService loggerService = new LoggerService();

        // 2. Multicast Delegate: Subscribe modules dynamically 
        processor.OnOrderPlaced += emailService.SendEmail;
        processor.OnOrderPlaced += smsService.SendSMS;
        processor.OnOrderPlaced += loggerService.LogOrder;

        // 3. Create a sample order
        Order newOrder = new Order(101, "Indranil Bhattacharjee", 1500.00);

        // 4. Trigger the process 
        processor.ProcessOrder(newOrder);

        // 5. Bonus: Unsubscribe functionality
                    // processor.OnOrderPlaced -= smsService.SendSMS;

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}