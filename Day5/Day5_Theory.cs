//C#Features in 7 and 8 versions
//1) Tuples and Out variables:
//2) Pattern Matching:
//3) Local Functions:
//4) Async Streams:
//5) Nullable Reference Types:
//C#Features in 9 and 10 versions
//1) Records:
//2) Init-only properties:
//3) Top-level statements:
//4) Target-typed new expressions:
//5) Pattern Matching Enhancements:


//Why Exception handling is important?
//So that we can control the flow of the program and avoid crashing of the program.
//It also helps us to log the error and debug the code.

//Step forimplementing Exception handling
//Step 1: Identify the code that may throw an exception. and include it in try block.
//Step 2: Catch the exception using catch block and handle it accordingly.
//Step 3: Finally block is optional and it will always execute regardless of whether an exception is thrown or not.
//It is used to clean up resources or perform any necessary finalization.
//Step 4: In case there are multiple catch blocks,
//the most specific exception should be caught first and then the more general exceptions should be caught later.
//Note: Exception class is the base class for all exceptions in C#.
//It is recommended to catch specific exceptions rather than catching the base Exception class,
//as it allows for better error handling and debugging.



//There are cases where we can not rely on exceptions provided by the system like 
        //1) Checking for Minor age and raising an exception if the age is less than 18.
        //2) Checking for negative numbers and raising an exception if the number is negative.
        //3) Checking for null values and raising an exception if the value is null.
        //4) Checking for out of range values and raising an exception if the value is out of range.


        //All above exception are user defined exceptions, we can create our own custom exceptions by
        //inheriting from the base Exception class.

        //Steps for getting startedw with User define exceptions:
        //Step 1: Create a new class that inherits from the base Exception class.
        //Step 2: Define a constructor that takes a message parameter and passes it to the base Exception class constructor.
        //Step 3: Optionally, you can also define additional properties or methods to provide more information about the exception.
        //Step 4: Throw the custom exception in your code when the specific condition is met.
        //Step 5: Catch the custom exception in a catch block and handle it accordingly.
        //Step 6: Optionally, you can also log the exception or perform any necessary cleanup in the catch block.



        // so that all methods and properties of the base Exception class are available in this class.

    //There are cases where we can not rely on exceptions provided by the system like 
    //1) Checking for Minor age and raising an exception if the age is less than 18.
    //2) Checking for negative numbers and raising an exception if the number is negative.
    //3) Checking for null values and raising an exception if the value is null.
    //4) Checking for out of range values and raising an exception if the value is out of range.


    //All above exception are user defined exceptions, we can create our own custom exceptions by
    //inheriting from the base Exception class.

    //Steps for getting startedw with User define exceptions:

    //Step 1: Create a new class that inherits from the base Exception class.
    //Step 2: Define a constructor that takes a message parameter and passes it to the base Exception class constructor.
    //Step 3: Optionally, you can also define additional properties or methods to provide more information about the exception.
    //Step 4: Throw the custom exception in your code when the specific condition is met.
    //Step 5: Catch the custom exception in a catch block and handle it accordingly.
    //Step 6: Optionally, you can also log the exception or perform any necessary cleanup in the catch block.
