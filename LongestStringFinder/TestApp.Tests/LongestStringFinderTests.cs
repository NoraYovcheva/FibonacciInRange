using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

public class LongestStringFinderTests
{

    [Test]
    public void Test_GetLongestString_EmptyList_ReturnsEmptyString()
    {
        //Arrange
        List<string> strings = new List<string>();
        string expected = string.Empty;

        //Act 
        string result = LongestStringFinder.GetLongestString(strings);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetLongestString_NullList_ReturnsEmptyString()
    {
        //Arrange
        List<string> strings = null;
        string expected = string.Empty;

        //Act 
        string result = LongestStringFinder.GetLongestString(strings);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetLongestString_OneElementInList_ReturnsThisWordAsString()
    {
        //Arrange
        List<string> strings = new List<string> { "a" };
        string expected = "a";

        //Act 
        string result = LongestStringFinder.GetLongestString(strings);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLongestString_ManyWordWithDiffrentLength_ReturnsLongestWord()
    {
        //Arrange
        List<string> strings = new List<string> { "Nora", "Hi", "success", "apple" };
        string expected = "success";

        //Act 
        string result = LongestStringFinder.GetLongestString(strings);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLongestString_ManyWordWithSameLength_ReturnsFirstWordOfThem()
    {
        //Arrange
        List<string> strings = new List<string> { "success", "weekend", "iceberg", "pacific" };
        string expected = "success";

        //Act 
        string result = LongestStringFinder.GetLongestString(strings);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
