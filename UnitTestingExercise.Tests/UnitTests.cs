using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(0,0,0,0)]
        [InlineData(2, 3, 5, 10)]
        [InlineData(0, 3, 4, 7)]
        [InlineData(-2, 3, 5, 6)]
        [InlineData(-1, -3, 5, 1)]
        [InlineData(-5, -3, -4, -12)]
        [InlineData(-5, 0, -4, -9)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var instance = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = instance.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(10,2,8)]
        [InlineData(-4,2,-6)]
        [InlineData(-4,-2,-2)]
        [InlineData(4,0,4)]
        [InlineData(0,0,0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(2,0,0)]
        [InlineData(-1,1,-1)]
        [InlineData(-2,-4,8)]
        [InlineData(-2, 5, -10)]
        [InlineData(0,0,0)]
        [InlineData(4,1,4)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,1)]
        [InlineData(2,1,2)]
        [InlineData(4,1,4)]
        [InlineData(4,-2,-2)]
        [InlineData(-8,-4,2)]
        [InlineData(15,3,5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
