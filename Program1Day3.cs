Console.WriteLine("Boxing and Unboxing demo in C#");
//value type variables 
int a = 10;
//Boxing : Converting value type to reference type
object obj = a; // Boxing the integer value into an object
                //Object is the gloabal base class in C# and all the types in C# are derived from object class
Console.WriteLine(obj);