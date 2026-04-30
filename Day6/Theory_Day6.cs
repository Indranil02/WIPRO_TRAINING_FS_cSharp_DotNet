


//Problem statement based on use of delgates in C#:
//1. Create a delegate type called "MathOperation" that takes two integers as parameters and
//returns an integer as output.
//2. Implement three methods that match the signature of the "MathOperation" delegate:
//   a. Add: This method should return the sum of the two integers.
//   b. Subtract: This method should return the difference of the two integers.
//   c. Multiply: This method should return the product of the two integers.
//3. Create an instance of the "MathOperation" delegate and assign it the "Add" method.
//4. Invoke the delegate with two integers and display the result.
//5. Change the delegate assignment to the "Subtract" method and invoke it again with the same integers, displaying the result.

//Creating an instance of the "MathOperation" delegate and assigning it the "Add" method.
//MathOperation operation = Add;
//Console.WriteLine("Delegate ref is created and currently it is pointing to Add()");
//invoking the delegate with two integers and displaying the result.
//int result = operation(10, 5);
//Console.WriteLine("Since Delegate is pointing to Add() so the result of Addition is "+result);

//Changing the delegate assignment to the "Subtract" method and invoking it again with the same integers, displaying the result.
//operation = Subtract;
//Console.WriteLine("Now the delegate ref is changed and currently it is pointing to Subtract()");
//result = operation(10, 5);
//Console.WriteLine("Since Delegate is pointing to Subtract() so the result of Subtraction is " + result);

//delegate int MathOperation(int a, int b);
 //define a delegate type called "MathOperation" that takes two integers as parameters and returns an integer as output.
 //outside the main method of the class and before the main method of the class
 //public class delgateDemo
 //{
     //here we will implemnt methods that match the signature of the delegate
     //Here we are defining methods as static because we are going to call these methods without creating an instance of the class.



//Multicasting delegate are used in following sceanrios::
//1. When you want to execute multiple methods in response to a single event, such as a button click or a timer tick.
//2. When you want to implement the observer pattern, where multiple observers need to be notified of changes in a subject.
//3. When you want to implement a publish-subscribe model, where multiple subscribers can register to receive notifications from a publisher.
//ex for publisher subsriber model can be in a sceanrio where you have a news publisher that publishes news articles, and multiple subscribers that want to receive notifications when a new article is published.
//You can use a multicast delegate to allow the publisher to notify all subscribers at once when a new article is published.
//


//In the above code we have created a delegate type called "MathOperation" that takes two integers as parameters and returns an integer as output.

//here we can have publish-subscriber model where MathOperation delegate can be used as a publisher and we can have multiple subscribers that want to receive notifications when a new math operation is performed.



//Step 1: Define a delegate type that specifies the signature of the method that the delegate can reference. (We have already defined the MathOperation delegate)
//Step 2: Create a class that will act as the publisher and define an event that uses the delegate type.
//(We can create a class called "MathPublisher" that has an event called "OnMathOperationPerformed" of type MathOperation)
//Step 3: Create a class that will act as the subscriber and define a method that matches the signature of the delegate. (We can create a class called "MathSubscriber" that has a method called "HandleMathOperation" that takes two integers as parameters and returns an integer as output)

//IN a publisher subcriber model, the publisher is responsible for sending messages or events to subscribers.
        //The publisher does not need to know who the subscribers are or how they will handle the messages.
        //The subscribers can choose to subscribe to specific types of messages or events that they are interested in.

        //Problemstatement based on real world use case :
 //Consider a news agency that publishes news articles on various topics such as sports, politics, and entertainment.
 //The news agency acts as the publisher, while the readers who subscribe to the news articles are the subscribers.
 //The news agency can publish articles on different topics, and the readers can choose to subscribe to the topics they are interested in.

 //Step bystep implementation of publisher subscriber model in C#:
//Step 1: Define the Publisher class ex : NewsAgency
//Step 2: Define the Subscriber class ex : Reader
//Step 3: Implement the subscription mechanism in the Publisher class ex : Subscribe method
//Step 4: Implement the notification mechanism in the Publisher class ex : Publish method
//Step 5: Create instances of the Publisher and Subscriber classes and demonstrate the functionality


//https://github.com/ParthShuklaa/Demo_Publisher_SubscriberModel
