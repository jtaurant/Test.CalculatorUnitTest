using System;
using Xunit;
using CalculatorLib;
using System.Diagnostics.CodeAnalysis;
using Moq;

namespace TDD.xUnit.net.Client
{
    [ExcludeFromCodeCoverage]
    public class CalculatorTests
    {
        [Fact]
        public void PassingTest()
        {
            //arrange
            var calculator = new Mock<ICalculator>();

            //act
            calculator.Setup(x=> x.Add(2,2)).Returns(4);

            //Assert
            Assert.Equal(4, calculator.Object.Add(2, 2));
           // Assert.Equal(0, calculator.Add(0, 0));
        }
    }
}
