using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        // Setup the calculator instance for testing
        private readonly Calculator _calculator = new Calculator();

        [Fact] // Task 3: Verify correct results for valid inputs
        public void Add_ShouldReturnCorrectSum()
        {
            double result = _calculator.Add(10, 5);
            Assert.Equal(15, result);
        }

        [Fact] // Task 3: Verify edge cases (adding zero)
        public void Add_Zero_ShouldReturnSameNumber()
        {
            double result = _calculator.Add(10, 0);
            Assert.Equal(10, result);
        }

        [Fact] // Task 3: Verify handling of division by zero
        public void Divide_ByZero_ShouldThrowException()
        {
            // Verifies the "appropriate exception" requirement
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }
    }
}
