//Step 1 : Create a method for linear search and binary search
//Step 2 : Take input from user for array and element to be searched    
//Step 3 : Call the method for linear search and binary search and pass the array and element to be searched as parameters
//Steo 4 : Display the result of linear search and binary search
//Step 5: We can show time complexity of linear search and binary search in milliseconds.

//Linear Search Method
//public static int LinearSearch(int[] arr, int element)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == element)
        {
            return i; // Return the index of the found element
        }
    }
    return -1; // Return -1 if the element is not found
}

Console.WriteLine("Enter the size of the array:");
int size = int.Parse(Console.ReadLine());//taking input for size of array
int[] arr = new int[size];//creating an array of given size
Console.WriteLine("Enter the elements of the array:");  
for (int i = 0; i < size; i++)
{
    arr[i] = int.Parse(Console.ReadLine());//taking input for elements of array
}
Console.WriteLine("Enter the element to be searched:");
int element = int.Parse(Console.ReadLine());//taking input for element to be searched
Console.WriteLine("Linear Search Result:");

int linearSearchResult = LinearSearch(arr, element);
//calling the linear search method and storing the result in a variable
if (linearSearchResult != -1)//this condition is used to check if the element is found in the array or not.
                             //If the element is found, it will return the index of the element in the array,
                             //otherwise it will return -1.

//Step 1 : Create a method for binary search that takes a sorted array and an element to be searched as parameters
//Step 2 : Initialize two pointers, one at the beginning of the array and another at the end of the array
//Step 3 : While the left pointer is less than or equal to the right pointer, do the following:
//Step 4 : Calculate the mid index of the array
//Step 5 : If the element at the mid index is equal to the element to be searched, return the mid index
//Step 6 : If the element at the mid index is less than the element to be searched, move the left pointer to mid + 1
//Step 7 : If the element at the mid index is greater than the element to be searched, move the right pointer to mid - 1
//Note: The array must be sorted in ascending order for binary search to work correctly.
//If the element is not found in the array, return -1.

// Method to perform binary search on a sorted array
 //public static int Search(int[] arr, int target)
 {
     int left = 0;
     int right = arr.Length - 1;//pointing to the last index of the array
     while (left <= right)
     {
         int mid = left + (right - left) / 2;// Calculate the mid index to avoid overflow
         if (arr[mid] == target)
         {
             return mid; // Element found at index mid
         }
         else if (arr[mid] < target)
         {
             left = mid + 1; // Move the left pointer to mid + 1
         }
         else
         {
             right = mid - 1; // Move the right pointer to mid - 1
         }
     }
     return -1; // Element not found in the array
 }


 //With the help of indexing we can access the elements of an array or a collection using their index.
//Steps for implemting indexing in C#:
//Step 1: Define a class that will represent the collection you want to index.
//Step 2: Implement the indexer in the class. An indexer is defined using the 'this' keyword followed by square brackets [].
//Step 3: Inside the indexer, you can define the logic to get or set the value based on the index provided.
//Step 4: Create an instance of the class and use the indexer to access or modify the elements of the collection.


//using above propoerty with objects of the class:

    //In the Main method, we can create instances of the Person and Employee classes and use their properties to set and get values.
    //Object of Person class
    //Person person = new Person();
    //person.Age = 25; // Setting the age using the property
    //Console.WriteLine($"Person's Age: {person.Age}"); // Getting the age using the property

    //Object of Employee class
    //Employee employee = new Employee();
    //employee.Salary = 25000; // Setting the salary using the property
    //Console.WriteLine($"Employee's Salary: {employee.Salary}"); // Getting the salary using the property

    //Major diff between property and fucntion is that property is used to represent the attributes of an object,
    //while function is used to represent the behavior of an object.
    //Property is accessed like a field, while a function is called like a method.

        //Properties are typically used to encapsulate data and provide controlled access to it,
    //while functions are used to perform actions or calculations based on the data.

    class Employee
  {
      private decimal _salary; // This is a private field that will hold the salary of the employee.
      public decimal Salary
      {
          get { return _salary; } // The 'get' accessor allows us to retrieve the value of '_salary'.
          set // The 'set' accessor allows us to set the value of '_salary' while ensuring that it cannot be less than the minimum wage.
          {
              if (value < 18000) // Assuming 15000 is the minimum wage.
              {
                  throw new ArgumentException("Salary cannot be less than the minimum wage.");
              }
              _salary = value;
          }
      }
  }

  class Person
  {
      private int _age;// This is a private field that will hold the age of the person.
      public int Age
      {
          get { return _age; } // The 'get' accessor allows us to retrieve the value of '_age'.
          set // The 'set' accessor allows us to set the value of '_age' while ensuring that it cannot be negative.
          {
              if (value < 0)
              {
                  throw new ArgumentException("Age cannot be negative.");
              }
              _age = value;
          }
      }
  }

  //INdexers v/s property in C#
//1. Purpose: Properties are used to represent the attributes of an object,
//while indexers are used to represent a collection of objects that can be accessed using an index.
//2. Syntax: Properties are defined using the 'get' and 'set' accessors,
//while indexers are defined using the 'this' keyword followed by square brackets [].
//3. Access: Properties are accessed like fields, while indexers are accessed using an index.
//4. Use Cases: Properties are typically used to encapsulate data and provide controlled access to it,
//while indexers are used to create custom collections that can be accessed using an index, similar to arrays or lists.

//IN an ecommerce application, we have a class called 'Product' that represents a product in the inventory.
//Each product has a name, price, and quantity. We want to create a collection of products and allow users to
//access and modify the products using both properties and indexers.

//User story 1: As a user, I want to be able to access the name, price, and quantity of a product using properties so that I can easily retrieve and display this information.
//User story 2: As a user, I want to be able to access and modify products in the collection using indexers so that I can easily manage the inventory.
//User story 3: As a user, I want to ensure that the price of a product cannot be set to a negative value and the quantity cannot be set to a negative number using properties so that I can maintain data integrity.

//limitation of indexers is that they can only have one parameter,
//which is the index, while properties can have multiple parameters (in the case of indexer properties).

//problem statement based on Indexers and Property:
//IN an ecommerce application, we have a class called 'Product' that represents a product in the inventory.
//Each product has a name, price, and quantity. We want to create a collection of products and allow users to
//access and modify the products using both properties and indexers.

//User story 4: As a user, I want to ensure that when I access a product using an indexer, it returns the correct product based on the index so that I can efficiently manage the inventory.
//User story 5: As a user, I want to ensure that when I modify a product using an indexer, it updates the correct product in the collection so that I can maintain accurate inventory records.