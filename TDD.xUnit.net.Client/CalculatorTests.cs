using System;
using Xunit;
using CalculatorLib;

namespace TDD.xUnit.net.Client
{
    public class CalculatorTests
    {
        [Fact]
        public void PassingTest()
        {
            var calculator = new Calculator();
            Assert.Equal(4, calculator.Add(2,2));
            Assert.Equal(0, calculator.Add(0, 0));
        }
    }
}
