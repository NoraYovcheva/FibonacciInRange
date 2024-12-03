using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class FibonacciTests
{

    [Test]
    public void Test_FibonacciInRange_StartNumberGreaterThanEndNumber_ReturnsErrorMessage()
    {
        //Arrange
        int start = 10;
        int end = 1;
        string expected = "Start number should be less than end number.";

        //Act 
        string result = Fibonacci.FibonacciInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FibonacciInRange_StartAndEndNumberEqualToZero_ReturnsZero()
    {
        //Arrange
        int start = 0;
        int end = 0;
        string expected = "0";

        //Act 
        string result = Fibonacci.FibonacciInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FibonacciInRange_StartAndEndNumberEqualToOne_ReturnsTwoTimesOne()
    {
        //Arrange
        int start = 1;
        int end = 1;
        string expected = "1 1";

        //Act 
        string result = Fibonacci.FibonacciInRange(start, end);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FibonacciInRange_NoFibonacciNumberBetweenStartAndEndNumbers_ReturnsEmptyString()
    {
        //Arrange
        int start = 9;
        int end = 12;
        string expected = string.Empty;

        //Act 
        string result = Fibonacci.FibonacciInRange(start, end);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FibonacciInRange_ValidRange_ReturnsFibonacciSequence()
    {
        //Arrange
        int start = 2;
        int end = 90;
        string expected = "2 3 5 8 13 21 34 55 89";

        //Act 
        string result = Fibonacci.FibonacciInRange(start, end);

        //Assert
       Assert.That(result, Is.EqualTo(expected));
    }
}

