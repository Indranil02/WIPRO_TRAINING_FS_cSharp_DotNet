using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
        public class Calculator
        {
            // User Story 1: Addition [cite: 19]
            public double Add(double a, double b) => a + b;

            // User Story 1: Subtraction [cite: 20]
            public double Subtract(double a, double b) => a - b;

            // User Story 1: Multiplication [cite: 21]
            public double Multiply(double a, double b) => a * b;

            // User Story 1: Division with Exception Handling [cite: 22, 53]
            public double Divide(double a, double b)
            {
                if (b == 0)
                {
                    // Requirement: Handle division by zero with an appropriate exception 
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return a / b;
            }
        }
    
}
