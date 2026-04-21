using System;

namespace DelegateDemo
{
    public delegate int MathOperation(int a, int b);

    class Program
    {
        static void main(String[] args)
        {
            MathOperation operation = Add;
            Console.WriteLine("Delegate ref is created and it is currently pointing to Add()");
            int result = operation(10,5);
            Console.WriteLine("Since delegate is pointing to Add(), the result of Addition is "+ result);
            Console.WriteLine();
            operation = Subtract();
            Console.WriteLine("Delegate ref is changed and currently pointing to Subtract()");
            result = operation(10,5);
            Console.WriteLine("Since delegate is now pointing to Subtract(), the result of Subtraction is "+ result);
            operation = Multiply();
            result = operation(10,5);
            Console.WriteLine("Since delegate is now pointing to Multiply(), the result of Multiplication is "+ result);
            

        }
    }
}