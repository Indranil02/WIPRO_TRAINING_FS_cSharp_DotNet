using System;

namespace NewsAgencyApp
{
    // Custom EventArgs to carry the news data to the subscribers
    public class NewsEventArgs : EventArgs
    {
        public string Topic { get; set; }
        public string Content { get; set; }

        public NewsEventArgs(string topic, string content)
        {
            Topic = topic;
            Content = content;
        }
    }

    // Define the Publisher
    public class NewsAgency
    {
        public string AgencyName { get; set; }

        // The 'Event' acts as the broadcast medium
        public event EventHandler<NewsEventArgs> NewsPublished;

        //Notification Mechanism
        public void Publish(string topic, string content)
        {
            Console.WriteLine($"\n>>> {AgencyName} is publishing news on {topic}...");
            
            // Check if there are any subscribers before notifying
            NewsPublished?.Invoke(this, new NewsEventArgs(topic, content));
        }
    }

    // Define the Subscriber
    public class Reader
    {
        public string Name { get; set; }

        public Reader(string name) => Name = name;

        // This method must match the EventHandler signature
        public void OnNewsReceived(object sender, NewsEventArgs e)
        {
            Console.WriteLine($"   [{Name}'s Feed] {e.Topic.ToUpper()}: {e.Content}");
        }
    }

    //Demonstration
    class Program
    {
        static void Main(string[] args)
        {
            // Create the Publisher
            NewsAgency dailyBugle = new NewsAgency { AgencyName = "Zee News" };

            // Create Subscribers
            Reader peter = new Reader("Indra");
            Reader mary = new Reader("Nil");

            //Subscription Mechanism
            dailyBugle.NewsPublished += peter.OnNewsReceived;
            dailyBugle.NewsPublished += mary.OnNewsReceived;

            // First Publication
            dailyBugle.Publish("Politics", "New MLA elected.");

            // Unsubscribing
            Console.WriteLine("\n=== Indra cancels his subscription ===");
            dailyBugle.NewsPublished -= peter.OnNewsReceived;

            // Second Publication
            dailyBugle.Publish("Sports", "India wins the championship!");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
